using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BUpgradePostExtensions
    {
        public static UniTask<BackendReturnObject> DeleteUserPostAsync(this BUpgradePost self, string postIndate)
            => Asynchronizer.Make(self.DeleteUserPost, postIndate);

        public static UniTask<BackendReturnObject> GetPostListAsync(this BUpgradePost self, PostType postType)
            => Asynchronizer.Make(self.GetPostList, postType);
        public static UniTask<BackendReturnObject> GetPostListAsync(this BUpgradePost self, PostType postType, int limit)
            => Asynchronizer.Make(self.GetPostList, postType, limit);

        public static UniTask<BackendReturnObject> ReceivePostItemAsync(this BUpgradePost self, PostType postType, string postIndate)
            => Asynchronizer.Make(self.ReceivePostItem, postType, postIndate);

        public static UniTask<BackendReturnObject> ReceivePostItemAllAsync(this BUpgradePost self, PostType postType)
            => Asynchronizer.Make(self.ReceivePostItemAll, postType);

        public static UniTask<BackendReturnObject> SendUserPostAsync(this BUpgradePost self, string ReceiverIndate, PostItem item)
            => Asynchronizer.Make(self.SendUserPost, ReceiverIndate, item);
    }
}
