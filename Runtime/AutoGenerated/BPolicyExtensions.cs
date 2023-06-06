using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BPolicyExtensions
    {
        public static UniTask<BackendReturnObject> GetPolicyAsync(this BPolicy self)
            => Asynchronizer.Make(self.GetPolicy);
        public static UniTask<BackendReturnObject> GetPolicyAsync(this BPolicy self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetPolicy, cancellationToken);

        public static UniTask<BackendReturnObject> GetPolicyV2Async(this BPolicy self)
            => Asynchronizer.Make(self.GetPolicyV2);
        public static UniTask<BackendReturnObject> GetPolicyV2Async(this BPolicy self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetPolicyV2, cancellationToken);
    }
}
