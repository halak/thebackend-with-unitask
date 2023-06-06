using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BLogExtensions
    {
        public static UniTask<BackendReturnObject> InsertLogAsync(this BLog self, string logType, Param param)
            => Asynchronizer.Make(self.InsertLog, logType, param);
        public static UniTask<BackendReturnObject> InsertLogAsync(this BLog self, string logType, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.InsertLog, logType, param, cancellationToken);
        public static UniTask<BackendReturnObject> InsertLogAsync(this BLog self, string logType, Param param, int graceDays)
            => Asynchronizer.Make(self.InsertLog, logType, param, graceDays);
        public static UniTask<BackendReturnObject> InsertLogAsync(this BLog self, string logType, Param param, int graceDays, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.InsertLog, logType, param, graceDays, cancellationToken);

        public static UniTask<BackendReturnObject> InsertLogV2Async(this BLog self, string logType, Param param)
            => Asynchronizer.Make(self.InsertLogV2, logType, param);
        public static UniTask<BackendReturnObject> InsertLogV2Async(this BLog self, string logType, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.InsertLogV2, logType, param, cancellationToken);
        public static UniTask<BackendReturnObject> InsertLogV2Async(this BLog self, string logType, Param param, int expirationDays)
            => Asynchronizer.Make(self.InsertLogV2, logType, param, expirationDays);
        public static UniTask<BackendReturnObject> InsertLogV2Async(this BLog self, string logType, Param param, int expirationDays, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.InsertLogV2, logType, param, expirationDays, cancellationToken);
    }
}
