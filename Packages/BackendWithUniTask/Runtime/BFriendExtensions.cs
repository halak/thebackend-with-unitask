using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BFriendExtensions
    {
        public static UniTask<BackendReturnObject> AcceptFriendAsync(this BFriend self, string gamerInDate)
            => Asynchronizer.Make(self.AcceptFriend, gamerInDate);

        public static UniTask<BackendReturnObject> BreakFriendAsync(this BFriend self, string gamerInDate)
            => Asynchronizer.Make(self.BreakFriend, gamerInDate);

        public static UniTask<BackendReturnObject> GetFriendListAsync(this BFriend self)
            => Asynchronizer.Make(self.GetFriendList);
        public static UniTask<BackendReturnObject> GetFriendListAsync(this BFriend self, int limit)
            => Asynchronizer.Make(self.GetFriendList, limit);
        public static UniTask<BackendReturnObject> GetFriendListAsync(this BFriend self, int limit, int offset)
            => Asynchronizer.Make(self.GetFriendList, limit, offset);

        public static UniTask<BackendReturnObject> GetReceivedRequestListAsync(this BFriend self)
            => Asynchronizer.Make(self.GetReceivedRequestList);
        public static UniTask<BackendReturnObject> GetReceivedRequestListAsync(this BFriend self, int limit)
            => Asynchronizer.Make(self.GetReceivedRequestList, limit);
        public static UniTask<BackendReturnObject> GetReceivedRequestListAsync(this BFriend self, int limit, int offset)
            => Asynchronizer.Make(self.GetReceivedRequestList, limit, offset);

        public static UniTask<BackendReturnObject> GetSentRequestListAsync(this BFriend self)
            => Asynchronizer.Make(self.GetSentRequestList);
        public static UniTask<BackendReturnObject> GetSentRequestListAsync(this BFriend self, int limit)
            => Asynchronizer.Make(self.GetSentRequestList, limit);
        public static UniTask<BackendReturnObject> GetSentRequestListAsync(this BFriend self, int limit, int offset)
            => Asynchronizer.Make(self.GetSentRequestList, limit, offset);

        public static UniTask<BackendReturnObject> RejectFriendAsync(this BFriend self, string gamerInDate)
            => Asynchronizer.Make(self.RejectFriend, gamerInDate);

        public static UniTask<BackendReturnObject> RequestFriendAsync(this BFriend self, string gamerInDate)
            => Asynchronizer.Make(self.RequestFriend, gamerInDate);

        public static UniTask<BackendReturnObject> RevokeSentRequestAsync(this BFriend self, string gamerInDate)
            => Asynchronizer.Make(self.RevokeSentRequest, gamerInDate);
    }
}
