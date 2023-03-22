using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BNoticeExtensions
    {
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self)
            => Asynchronizer.Make(self.NoticeList);
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self, int limit)
            => Asynchronizer.Make(self.NoticeList, limit);
        public static UniTask<BackendReturnObject> NoticeListAsync(this BNotice self, int limit, string offset)
            => Asynchronizer.Make(self.NoticeList, limit, offset);

        public static UniTask<BackendReturnObject> NoticeOneAsync(this BNotice self, string inDate)
            => Asynchronizer.Make(self.NoticeOne, inDate);
    }
}
