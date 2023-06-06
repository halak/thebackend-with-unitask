using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BProbabilityExtensions
    {
        public static UniTask<BackendReturnObject> GetProbabilityAsync(this BProbability self, string CardFileId)
            => Asynchronizer.Make(self.GetProbability, CardFileId);
        public static UniTask<BackendReturnObject> GetProbabilityAsync(this BProbability self, string CardFileId, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetProbability, CardFileId, cancellationToken);

        public static UniTask<BackendReturnObject> GetProbabilityCardListAsync(this BProbability self)
            => Asynchronizer.Make(self.GetProbabilityCardList);
        public static UniTask<BackendReturnObject> GetProbabilityCardListAsync(this BProbability self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetProbabilityCardList, cancellationToken);

        public static UniTask<BackendReturnObject> GetProbabilityCardListV2Async(this BProbability self)
            => Asynchronizer.Make(self.GetProbabilityCardListV2);
        public static UniTask<BackendReturnObject> GetProbabilityCardListV2Async(this BProbability self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetProbabilityCardListV2, cancellationToken);

        public static UniTask<BackendReturnObject> GetProbabilitysAsync(this BProbability self, string CardFileID, int count)
            => Asynchronizer.Make(self.GetProbabilitys, CardFileID, count);
        public static UniTask<BackendReturnObject> GetProbabilitysAsync(this BProbability self, string CardFileID, int count, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetProbabilitys, CardFileID, count, cancellationToken);
    }
}
