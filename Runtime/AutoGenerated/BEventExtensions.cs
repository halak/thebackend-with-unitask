using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BEventExtensions
    {
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self)
            => Asynchronizer.Make(self.EventList);
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.EventList, cancellationToken);
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self, int limit)
            => Asynchronizer.Make(self.EventList, limit);
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.EventList, limit, cancellationToken);
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self, int limit, string offset)
            => Asynchronizer.Make(self.EventList, limit, offset);
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self, int limit, string offset, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.EventList, limit, offset, cancellationToken);

        public static UniTask<BackendReturnObject> EventOneAsync(this BEvent self, string inDate)
            => Asynchronizer.Make(self.EventOne, inDate);
        public static UniTask<BackendReturnObject> EventOneAsync(this BEvent self, string inDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.EventOne, inDate, cancellationToken);
    }
}
