using System;
using System.Threading;
using BackEnd;
using BackEnd.NativeInstance;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class iOSInstanceExtensions
    {
        public static UniTask<BackendReturnObject> AgreeNightPushNotificationAsync(this iOSInstance self, bool isAgree)
            => Asynchronizer.Make(self.AgreeNightPushNotification, isAgree);
        public static UniTask<BackendReturnObject> AgreeNightPushNotificationAsync(this iOSInstance self, bool isAgree, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.AgreeNightPushNotification, isAgree, cancellationToken);

        public static UniTask<BackendReturnObject> DeleteDeviceTokenAsync(this iOSInstance self)
            => Asynchronizer.Make(self.DeleteDeviceToken);
        public static UniTask<BackendReturnObject> DeleteDeviceTokenAsync(this iOSInstance self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.DeleteDeviceToken, cancellationToken);

        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this iOSInstance self, isDevelopment isDevelopment)
            => Asynchronizer.Make(self.PutDeviceToken, isDevelopment);
        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this iOSInstance self, isDevelopment isDevelopment, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.PutDeviceToken, isDevelopment, cancellationToken);
        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this iOSInstance self, string deviceToken, isDevelopment isDevelopment)
            => Asynchronizer.Make(self.PutDeviceToken, deviceToken, isDevelopment);
        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this iOSInstance self, string deviceToken, isDevelopment isDevelopment, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.PutDeviceToken, deviceToken, isDevelopment, cancellationToken);
    }
}
