using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc.Async
{
    public class AsyncHttpClient
    {
        private readonly Uri _baseUri;
        private readonly JsonRpcSerializer _serializer;
        private static readonly System.Net.Http.HttpClient HttpClient = new System.Net.Http.HttpClient();

        public AsyncHttpClient(Uri baseUri, JsonRpcSerializer serializer)
        {
            _baseUri = baseUri;
            _serializer = serializer;
        }

        public async Task<TResult> PostAsync<TResult>(string methodName, Func<JToken, TResult> parser, params JsonParam[] parameters)
        {
            JsonRequest jsonRequest = new JsonRequest(1, methodName, parameters);
            return await PostAsync(jsonRequest, parser);
        }

        public async Task PostWithoutResult(string methodName, params JsonParam[] parameters)
        {
            JsonRequest jsonRequest = new JsonRequest(1, methodName, parameters);
            bool isSuccess = await PostAsync(jsonRequest, r => r.ToString().Equals("OK", StringComparison.OrdinalIgnoreCase));
            if (!isSuccess)
            {
                throw new JsonRpcException("Der Aufruf von '{0}' ist fehlgeschlagen.", methodName);
            }
        }

        private async Task<TResult> PostAsync<TResult>(JsonRequest jsonRequest, Func<JToken, TResult> parser)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, _baseUri);
            message.Content = new StringContent(_serializer.Serialize(jsonRequest), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await HttpClient.SendAsync(message);

            string jsonData = await response.Content.ReadAsStringAsync();
            JObject responseObject = JObject.Parse(jsonData);
            JsonResult jsonResult = JsonResult.LoadFrom(responseObject);
            if (jsonResult.Error != null)
            {
                throw new JsonReaderException(jsonData);
            }
            TResult result = parser(jsonResult.Result);
            return result;
        }

        //public void PostAsync<TSimpleType>(string methodName, Action<TSimpleType, ErrorData> resultAction, params JsonParam[] parameters)
        //{
        //    Invoke(methodName, r => r.ParseSimpleValue<TSimpleType>(), resultAction, parameters);
        //}
    }
}