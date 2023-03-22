using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BEventExtensions
    {
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self)
            => Asynchronizer.Make(self.EventList);
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self, int limit)
            => Asynchronizer.Make(self.EventList, limit);
        public static UniTask<BackendReturnObject> EventListAsync(this BEvent self, int limit, string offset)
            => Asynchronizer.Make(self.EventList, limit, offset);

        public static UniTask<BackendReturnObject> EventOneAsync(this BEvent self, string inDate)
            => Asynchronizer.Make(self.EventOne, inDate);
    }
}
