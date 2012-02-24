using System;
using System.Collections.Generic;

namespace JeanRichard.Xbmc.Lib.JsonRpc
{
    public class JsonParam
    {
        public JsonParam(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public object Value { get; set; }
    }

    public class JsonParamObject : JsonParam
    {
        private readonly IEnumerable<JsonParam> _parameters;

        public JsonParamObject(string name, IEnumerable<JsonParam> parameters)
            : base(name, null)
        {
            _parameters = parameters;
            Value = this;
        }

        public JsonParamObject(string name, params JsonParam[] parameters)
            : base(name, null)
        {
            _parameters = parameters;
            Value = this;
        }

        public IEnumerable<JsonParam> Parameters
        {
            get { return _parameters; }
        }
    }
}