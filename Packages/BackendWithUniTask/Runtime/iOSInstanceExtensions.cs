using BackEnd;
using BackEnd.NativeInstance;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class iOSInstanceExtensions
    {
        public static UniTask<BackendReturnObject> DeleteDeviceTokenAsync(this iOSInstance self)
            => Asynchronizer.Make(self.DeleteDeviceToken);

        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this iOSInstance self, isDevelopment isDevelopment)
            => Asynchronizer.Make(self.PutDeviceToken, isDevelopment);
    }
}
