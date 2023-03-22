using System;
using BackEnd;
using BackEnd.NativeInstance;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class AndroidInstanceExtensions
    {
        public static UniTask<BackendReturnObject> DeleteDeviceTokenAsync(this AndroidInstance self)
            => Asynchronizer.Make(self.DeleteDeviceToken);

        public static UniTask<BackendReturnObject> PutDeviceTokenAsync(this AndroidInstance self, string deviceToken)
            => Asynchronizer.Make(self.PutDeviceToken, deviceToken);
    }
}
