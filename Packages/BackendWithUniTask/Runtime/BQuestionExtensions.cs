using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BQuestionExtensions
    {
        public static UniTask<BackendReturnObject> GetQuestionAuthorizeAsync(this BQuestion self)
            => Asynchronizer.Make(self.GetQuestionAuthorize);
    }
}
