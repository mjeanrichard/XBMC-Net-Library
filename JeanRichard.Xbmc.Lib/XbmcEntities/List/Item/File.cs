using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Item;
using Newtonsoft.Json;

namespace JeanRichard.Xbmc.Lib.XbmcEntities.List.Item
{
    /// <jsonId>
    /// List.Item.File
    /// </jsonId>
    /// <json>
    /// {
    ///  "extends": "List.Item.Base",
    ///  "id": "List.Item.File",
    ///  "properties": {
    ///    "file": {
    ///      "required": true,
    ///      "type": "string"
    ///    },
    ///    "filetype": {
    ///      "enums": [
    ///        "file",
    ///        "directory"
    ///      ],
    ///      "required": true,
    ///      "type": "string"
    ///    },
    ///    "lastmodified": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "mimetype": {
    ///      "default": "",
    ///      "type": "string"
    ///    },
    ///    "size": {
    ///      "default": 0,
    ///      "description": "Size of the file in kB (1000 Byte)",
    ///      "type": "integer"
    ///    }
    ///  }
    ///}
    /// </json>
    public class File : XbmcItemBase
    {
        [JsonProperty(PropertyName = "file")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "filetype")]
        public FileType FileType { get; set; }

        [JsonProperty(PropertyName = "lastmodified")]
        public string LastModified { get; set; }

        [JsonProperty(PropertyName = "mimetype")]
        public string Mimetype { get; set; }

        /// <summary>
        /// Size of the file in kB (1000 Byte)
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }
    }
}