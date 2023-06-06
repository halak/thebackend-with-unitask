using System;
using System.Threading;
using BackEnd;
using BackEnd.NativeInstance;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class AndroidInstanceExtensions
    {
        public static UniTask<BackendReturnObject> AgreeNightPushNotificationAsync(this AndroidInstance self, bool isAgree)
            => Asynchronizer.Make(self.AgreeNightPushNotification, isAgree);
        public static UniTask<BackendReturnObject> AgreeNightPushNotificationAsync(this AndroidInstance self, bool isAgree, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.AgreeNightPushNotification, isAgree, cancellationToken);

        public static UniTask<BackendReturnObject> DeleteDeviceTokenAsync(this AndroidInstance self)
            => Asynchronizer.Make(self.DeleteDeviceToken);
        public static UniTask<BackendReturnObject> DeleteDeviceTokenAsync(this AndroidInstance self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.DeleteDeviceToken, cancellationToken);

        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this AndroidInstance self, string deviceToken)
            => Asynchronizer.Make(self.PutDeviceToken, deviceToken);
        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this AndroidInstance self, string deviceToken, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.PutDeviceToken, deviceToken, cancellationToken);
    }
}
