using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BLogExtensions
    {
        public static UniTask<BackendReturnObject> GetLogAsync(this BLog self, string logType)
            => Asynchronizer.Make(self.GetLog, logType);
        public static UniTask<BackendReturnObject> GetLogAsync(this BLog self, string logType, int limit)
            => Asynchronizer.Make(self.GetLog, logType, limit);
        public static UniTask<BackendReturnObject> GetLogAsync(this BLog self, string logType, int limit, string firstKey)
            => Asynchronizer.Make(self.GetLog, logType, limit, firstKey);

        public static UniTask<BackendReturnObject> InsertLogAsync(this BLog self, string logType, Param param)
            => Asynchronizer.Make(self.InsertLog, logType, param);
        public static UniTask<BackendReturnObject> InsertLogAsync(this BLog self, string logType, Param param, int graceDays)
            => Asynchronizer.Make(self.InsertLog, logType, param, graceDays);
    }
}
