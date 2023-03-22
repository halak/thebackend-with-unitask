using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BProbabilityExtensions
    {
        public static UniTask<BackendReturnObject> GetProbabilityAsync(this BProbability self, string CardFileId)
            => Asynchronizer.Make(self.GetProbability, CardFileId);

        public static UniTask<BackendReturnObject> GetProbabilityCardListAsync(this BProbability self)
            => Asynchronizer.Make(self.GetProbabilityCardList);

        public static UniTask<BackendReturnObject> GetProbabilitysAsync(this BProbability self, string CardFileID, int count)
            => Asynchronizer.Make(self.GetProbabilitys, CardFileID, count);
    }
}
