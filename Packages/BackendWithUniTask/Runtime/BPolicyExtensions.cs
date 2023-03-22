using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BPolicyExtensions
    {
        public static UniTask<BackendReturnObject> GetPolicyAsync(this BPolicy self)
            => Asynchronizer.Make(self.GetPolicy);
    }
}
