using System;
using System.Globalization;

namespace JeanRichard.Xbmc.Lib.JsonRpc.Async
{
    public class JsonRpcException : Exception
    {
        private readonly JsonError _error;

        public JsonError Error
        {
            get { return _error; }
        }

        public JsonRpcException()
        {
        }

        public JsonRpcException(string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {
        }

        public JsonRpcException(Exception innerException, string message, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, message, args), innerException)
        {
        }

        public JsonRpcException(JsonError error)
            : base(error.Message)
        {
            _error = error;
        }
    }
}