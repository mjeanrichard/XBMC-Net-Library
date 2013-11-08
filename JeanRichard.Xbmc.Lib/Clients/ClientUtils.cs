using System.Collections.Generic;
using JeanRichard.Xbmc.Lib.JsonRpc;
using JeanRichard.Xbmc.Lib.XbmcEntities.List;

namespace JeanRichard.Xbmc.Lib.Clients
{
    internal static class ClientUtils
    {
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
            yield return
                new JsonParam("sort",
                    new Sort
                    {
                        Method = sortMethod ?? SortMethods.Title,
                        Order = order ?? Orders.Descending,
                        IgnoreArticle = true
                    });
        }
    }
}