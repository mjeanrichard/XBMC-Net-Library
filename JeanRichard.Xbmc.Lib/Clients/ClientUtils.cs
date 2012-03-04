using System;
using System.Collections.Generic;

using JeanRichard.Xbmc.Lib.JsonHelpers;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.Audio.Details;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;
using JeanRichard.Xbmc.Lib.XbmcEntities.List.Item;
using JeanRichard.Xbmc.Lib.XbmcEntities.Media;

using Newtonsoft.Json.Linq;

namespace JeanRichard.Xbmc.Lib.Clients
{
    internal static class ClientUtils
    {
        public static MediaDetailsBase CreateMediaDetails(JToken jToken)
        {
            MediaItemTypes mediaType = jToken.ParseEnum<MediaItemTypes>("type");
            MediaDetailsBase result;
            switch (mediaType)
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
                    result = JsonRpcItem.LoadFrom<Song>(jToken);
                    break;
                case MediaItemTypes.Picture:
                    result = null;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("mediaType", String.Format("MediaItemType [{0}] is unknown.", mediaType));
            }

            int? id = jToken.ParseSimpleValue<int?>("id");
            if (id.HasValue)
            {
                result.Id = id;
            }
            return result;
        }

        public static IEnumerable<JsonParam> GetLimitsParameter(int? startIndex, int? endIndex)
        {
            if (startIndex.HasValue || endIndex.HasValue)
            {
                Limits limits = new Limits();
                limits.Start = startIndex ?? 0;
                limits.End = endIndex;
                yield return new JsonParam("limits", limits);
            }
        }

        public static IEnumerable<JsonParam> GetOptionalParameter<T>(T? libraryId, string propertyName) where T : struct
        {
            if (libraryId.HasValue)
            {
                yield return new JsonParam(propertyName, libraryId);
            }
        }

        public static IEnumerable<JsonParam> GetSortOrderParameter(SortMethods? sortMethod, Orders? order)
        {
            yield return new JsonParam("sort", new Sort { Method = sortMethod ?? SortMethods.Title, Order = order ?? Orders.Descending, IgnoreArticle = true });
        }
    }
}