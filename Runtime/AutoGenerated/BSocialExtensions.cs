using System;
using System.Threading;
using BackEnd;
using BackEnd.Social;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BSocialExtensions
    {
        public static UniTask<BackendReturnObject> GetUserInfoByInDateAsync(this BSocial self, string gamerInDate)
            => Asynchronizer.Make(self.GetUserInfoByInDate, gamerInDate);
        public static UniTask<BackendReturnObject> GetUserInfoByInDateAsync(this BSocial self, string gamerInDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetUserInfoByInDate, gamerInDate, cancellationToken);

        public static UniTask<BackendReturnObject> GetUserInfoByNickNameAsync(this BSocial self, string nickName)
            => Asynchronizer.Make(self.GetUserInfoByNickName, nickName);
        public static UniTask<BackendReturnObject> GetUserInfoByNickNameAsync(this BSocial self, string nickName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetUserInfoByNickName, nickName, cancellationToken);
    }
}
