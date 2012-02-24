using System;

namespace JeanRichard.Xbmc.Lib.JsonRpc.HttpClient
{
    public class ErrorData
    {
        public ErrorData(JsonError jsonError)
        {
            JsonError = jsonError;
        }

        public ErrorData(Exception exception)
        {
            Exception = exception;
        }

        public ErrorData(Exception exception, JsonError jsonError)
        {
            Exception = exception;
            JsonError = jsonError;
        }

        public Exception Exception { get; private set; }
        public JsonError JsonError { get; private set; }
    }
}