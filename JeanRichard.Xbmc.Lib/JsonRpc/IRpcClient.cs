using System;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    public interface IRpcClient
    {
        void Invoke<TResult>(string methodName, Func<JToken, TResult> parser, Action<TResult, ErrorData> resultAction, params JsonParam[] parameters);

        void InvokeForOkResult(string methodName, Action<bool, ErrorData> resultAction, params JsonParam[] parameters);

        void InvokeSimple<TSimpleType>(string methodName, Action<TSimpleType, ErrorData> resultAction, params JsonParam[] parameters);
    }
}