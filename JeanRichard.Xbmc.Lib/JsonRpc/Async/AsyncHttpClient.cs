using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc.Async
{
    public class AsyncHttpClient
    {
        public Uri BaseUri { get; set; }

        private readonly JsonRpcSerializer _serializer;
        private static readonly System.Net.Http.HttpClient HttpClient = new System.Net.Http.HttpClient();

        public AsyncHttpClient(JsonRpcSerializer serializer)
        {
            _serializer = serializer;
            HttpClient.DefaultRequestHeaders.ExpectContinue = false;
        }

        public async Task<TResult> PostAsync<TResult>(string methodName, Func<JToken, TResult> parser, params JsonParam[] parameters)
        {
            JsonRequest jsonRequest = new JsonRequest(1, methodName, parameters);
            return await PostAsync(jsonRequest, parser);
        }

        public async Task PostWithoutResultAsync(string methodName, params JsonParam[] parameters)
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
            Interlocked.Increment(ref _requestsInProgress);
            OnRequestsInProgressChanged();
            try
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, BaseUri);
                message.Content = new StringContent(_serializer.Serialize(jsonRequest), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await HttpClient.SendAsync(message);

                string jsonData = await response.Content.ReadAsStringAsync();
                JObject responseObject = JObject.Parse(jsonData);
                JsonResult jsonResult = JsonResult.LoadFrom(responseObject);
                if (jsonResult.Error != null)
                {
                    throw new JsonRpcException(jsonResult.Error);
                }
                try
                {
                    TResult result = parser(jsonResult.Result);
                    return result;
                }
                catch (Exception e)
                {
                    throw new JsonRpcException(e, "Fehler beim parsen der Reponse!\n{0}", jsonData);
                }
            }
            finally
            {
                Interlocked.Decrement(ref _requestsInProgress);
                OnRequestsInProgressChanged();
            }
        }

        public event EventHandler RequestsInProgressChanged;

        private int _requestsInProgress;

        public int RequestsInProgress
        {
            get { return _requestsInProgress; }
        }

        public virtual void OnRequestsInProgressChanged()
        {
            EventHandler handler = RequestsInProgressChanged;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }
    }
}