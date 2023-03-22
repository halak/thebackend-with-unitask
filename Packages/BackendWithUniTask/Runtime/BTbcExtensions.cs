using System;
using BackEnd;
using BackEnd.Game.Payment;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BTbcExtensions
    {
        public static UniTask<BackendReturnObject> ChargeTBCAsync(this BTbc self, string receiptJson, string details)
            => Asynchronizer.Make(self.ChargeTBC, receiptJson, details);
        public static UniTask<BackendReturnObject> ChargeTBCAsync(this BTbc self, string productId, string receiptToken, string details)
            => Asynchronizer.Make(self.ChargeTBC, productId, receiptToken, details);

        public static UniTask<BackendReturnObject> GetProductListAsync(this BTbc self)
            => Asynchronizer.Make(self.GetProductList);

        public static UniTask<BackendReturnObject> GetTBCAsync(this BTbc self)
            => Asynchronizer.Make(self.GetTBC);

        public static UniTask<BackendReturnObject> UseTBCAsync(this BTbc self, string productUuid, string details)
            => Asynchronizer.Make(self.UseTBC, productUuid, details);
    }
}
