using System;
using System.IO;
using System.Net;

using JeanRichard.Xbmc.Lib.JsonHelpers;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc.HttpClient
{
    public class JsonRpcHttpClient : IRpcClient
    {
        private readonly JsonRpcSerializer _serializer;
        private readonly Uri _uri;

        private static readonly System.Net.Http.HttpClient _httpClient = new System.Net.Http.HttpClient();

        public JsonRpcHttpClient(JsonRpcSerializer serializer, Uri uri)
        {
            _serializer = serializer;
            _uri = uri;
        }

        protected virtual void BeginExecuteRequest<TResult>(JsonRequest jsonRequest, Func<JToken, TResult> parser, Action<TResult, ErrorData> resultAction)
        {
            WebRequest webRequest = WebRequest.Create(_uri);
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            webRequest.BeginGetRequestStream(ar => ExecuteRequest(ar, jsonRequest, parser, resultAction), webRequest);
        }

        private void ExecuteRequest<TResult>(IAsyncResult asyncResult, JsonRequest jsonRequest, Func<JToken, TResult> parser, Action<TResult, ErrorData> resultAction)
        {
            try
            {
                WebRequest webRequest = (WebRequest)asyncResult.AsyncState;

                using (Stream stream = webRequest.EndGetRequestStream(asyncResult))
                {
                    _serializer.Serialize(jsonRequest, stream);
                }
                webRequest.BeginGetResponse(ar => GetJsonResult(ar, parser, resultAction), webRequest);
            }
            catch (WebException e)
            {
                resultAction(default(TResult), new ErrorData(e));
            }
        }

        protected void GetJsonResult<TResult>(IAsyncResult asyncResult, Func<JToken, TResult> parser, Action<TResult, ErrorData> resultAction)
        {
            WebRequest webRequest = (WebRequest)asyncResult.AsyncState;

            using (HttpWebResponse response = (HttpWebResponse)webRequest.EndGetResponse(asyncResult))
            {
                using (Stream stream = response.GetResponseStream())
                {
                    if (resultAction == null)
                    {
                        return;
                    }

                    string jsonData;
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        jsonData = reader.ReadToEnd();
                    }
                    JObject responseObject = JObject.Parse(jsonData);
                    JsonResult jsonResult = JsonResult.LoadFrom(responseObject);
                    if (jsonResult.Error != null)
                    {
                        resultAction(default(TResult), new ErrorData(jsonResult.Error));
                    }
                    else
                    {
                        TResult result = parser(jsonResult.Result);
                        resultAction(result, null);
                    }
                }
            }
        }

        public void Invoke<TResult>(string methodName, Func<JToken, TResult> parser, Action<TResult, ErrorData> resultAction, params JsonParam[] parameters)
        {
            JsonRequest jsonRequest = new JsonRequest(1, methodName, parameters);
            BeginExecuteRequest(jsonRequest, parser, resultAction);
        }

        public void InvokeForOkResult(string methodName, Action<bool, ErrorData> resultAction, params JsonParam[] parameters)
        {
            Invoke(methodName, r => r.ToString().Equals("OK", StringComparison.OrdinalIgnoreCase), resultAction, parameters);
        }

        public void InvokeSimple<TSimpleType>(string methodName, Action<TSimpleType, ErrorData> resultAction, params JsonParam[] parameters)
        {
            Invoke(methodName, r => r.ParseSimpleValue<TSimpleType>(), resultAction, parameters);
        }
    }
}