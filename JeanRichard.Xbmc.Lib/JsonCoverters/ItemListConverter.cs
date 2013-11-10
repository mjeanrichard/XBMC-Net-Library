using System;
using System.Linq;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Item;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.JsonCoverters
{
    public class ItemListConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsGenericType && objectType.GenericTypeArguments.Length == 1;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var itemType = objectType.GenericTypeArguments.Single();
            if (reader.TokenType == JsonToken.StartObject)
            {
                object itemsArray = null;
                LimitsReturned limitsReturned = null;
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartArray)
                    {
                        //Items Array
                        itemsArray = serializer.Deserialize(reader, itemType.MakeArrayType());
                    } 
                    else if (reader.TokenType == JsonToken.PropertyName && ((string)reader.Value).Equals("limits", StringComparison.OrdinalIgnoreCase))
                    {
                        reader.Read();
                        limitsReturned = serializer.Deserialize<LimitsReturned>(reader);
                    }
                }
                if (limitsReturned == null)
                {
                    throw new InvalidOperationException("Limits nicht gefunden!");
                }

                return Activator.CreateInstance(objectType, itemsArray, limitsReturned);
            }
            throw new InvalidOperationException("Der JsonReader muss auf einem Objekt stehen!");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }

    public class MediaDetailsBaseConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(MediaDetailsBase);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);

            JToken typeToken = token["type"];
            MediaItemTypes mediaItemType = typeToken.ToObject<MediaItemTypes>(serializer);
    
            MediaDetailsBase result;
            switch (mediaItemType)
            {
                case MediaItemTypes.Unknown:
                    result = null;
                    break;
                case MediaItemTypes.Movie:
                    result = null;
                    break;
                case MediaItemTypes.Episode:
                    result = null;
                    break;
                case MediaItemTypes.MusicVideo:
                    result = null;
                    break;
                case MediaItemTypes.Song:
                    result = token.ToObject<Song>(serializer);
                    break;
                case MediaItemTypes.Picture:
                    result = null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("mediaType", String.Format("MediaItemType [{0}] is unknown.", mediaItemType));
            }

            //int? id = jToken.Value<int?>("id");
            //if (id.HasValue)
            //{
            //    result.Id = id;
            //}
            return result;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}