using System;
using System.Threading;
using BackEnd;
using BackEnd.Game.Payment;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BTbcExtensions
    {
        public static UniTask<BackendReturnObject> ChargeTBCAsync(this BTbc self, string receiptJson, string details)
            => Asynchronizer.Make(self.ChargeTBC, receiptJson, details);
        public static UniTask<BackendReturnObject> ChargeTBCAsync(this BTbc self, string receiptJson, string details, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ChargeTBC, receiptJson, details, cancellationToken);
        public static UniTask<BackendReturnObject> ChargeTBCAsync(this BTbc self, string productId, string receiptToken, string details)
            => Asynchronizer.Make(self.ChargeTBC, productId, receiptToken, details);
        public static UniTask<BackendReturnObject> ChargeTBCAsync(this BTbc self, string productId, string receiptToken, string details, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ChargeTBC, productId, receiptToken, details, cancellationToken);

        public static UniTask<BackendReturnObject> GetProductListAsync(this BTbc self)
            => Asynchronizer.Make(self.GetProductList);
        public static UniTask<BackendReturnObject> GetProductListAsync(this BTbc self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetProductList, cancellationToken);

        public static UniTask<BackendReturnObject> GetTBCAsync(this BTbc self)
            => Asynchronizer.Make(self.GetTBC);
        public static UniTask<BackendReturnObject> GetTBCAsync(this BTbc self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetTBC, cancellationToken);

        public static UniTask<BackendReturnObject> UseTBCAsync(this BTbc self, string productUuid, string details)
            => Asynchronizer.Make(self.UseTBC, productUuid, details);
        public static UniTask<BackendReturnObject> UseTBCAsync(this BTbc self, string productUuid, string details, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UseTBC, productUuid, details, cancellationToken);
    }
}
