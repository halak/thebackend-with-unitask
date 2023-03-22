using System;
using BackEnd;
using BackEnd.Game.Payment;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BReceiptExtensions
    {
        public static UniTask<BackendReturnObject> IsValidateApplePurchaseAsync(this BReceipt self, string json, string receiptDescription)
            => Asynchronizer.Make(self.IsValidateApplePurchase, json, receiptDescription);

        public static UniTask<BackendReturnObject> IsValidateGooglePurchaseAsync(this BReceipt self, string json, string receiptDescription)
            => Asynchronizer.Make(self.IsValidateGooglePurchase, json, receiptDescription);
        public static UniTask<BackendReturnObject> IsValidateGooglePurchaseAsync(this BReceipt self, string json, string receiptDescription, bool isSubscription)
            => Asynchronizer.Make(self.IsValidateGooglePurchase, json, receiptDescription, isSubscription);
        public static UniTask<BackendReturnObject> IsValidateGooglePurchaseAsync(this BReceipt self, string productId, string token, string receiptDescription)
            => Asynchronizer.Make(self.IsValidateGooglePurchase, productId, token, receiptDescription);
        public static UniTask<BackendReturnObject> IsValidateGooglePurchaseAsync(this BReceipt self, string productId, string token, string receiptDescription, bool isSubscription)
            => Asynchronizer.Make(self.IsValidateGooglePurchase, productId, token, receiptDescription, isSubscription);
    }
}
