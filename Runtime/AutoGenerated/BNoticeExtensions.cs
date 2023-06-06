using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BNoticeExtensions
    {
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self)
            => Asynchronizer.Make(self.NoticeList);
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.NoticeList, cancellationToken);
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self, int limit)
            => Asynchronizer.Make(self.NoticeList, limit);
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.NoticeList, limit, cancellationToken);
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self, int limit, string offset)
            => Asynchronizer.Make(self.NoticeList, limit, offset);
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self, int limit, string offset, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.NoticeList, limit, offset, cancellationToken);

        public static UniTask<BackendReturnObject> NoticeOneAsync(this BNotice self, string inDate)
            => Asynchronizer.Make(self.NoticeOne, inDate);
        public static UniTask<BackendReturnObject> NoticeOneAsync(this BNotice self, string inDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.NoticeOne, inDate, cancellationToken);
    }
}
