using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BRandomInfoExtensions
    {
        public static UniTask<BackendReturnObject> DeleteRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid)
            => Asynchronizer.Make(self.DeleteRandomData, randomType, uuid);

        public static UniTask<BackendReturnObject> GetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, int pivot, int gap, int count)
            => Asynchronizer.Make(self.GetRandomData, randomType, uuid, pivot, gap, count);
        public static UniTask<BackendReturnObject> GetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, long pivot, int gap, int count)
            => Asynchronizer.Make(self.GetRandomData, randomType, uuid, pivot, gap, count);
        public static UniTask<BackendReturnObject> GetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, float pivot, int gap, int count)
            => Asynchronizer.Make(self.GetRandomData, randomType, uuid, pivot, gap, count);
        public static UniTask<BackendReturnObject> GetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, double pivot, int gap, int count)
            => Asynchronizer.Make(self.GetRandomData, randomType, uuid, pivot, gap, count);

        public static UniTask<BackendReturnObject> GetRandomDataTableListAsync(this BRandomInfo self)
            => Asynchronizer.Make(self.GetRandomDataTableList);

        public static UniTask<BackendReturnObject> SetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, int value)
            => Asynchronizer.Make(self.SetRandomData, randomType, uuid, value);
        public static UniTask<BackendReturnObject> SetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, long value)
            => Asynchronizer.Make(self.SetRandomData, randomType, uuid, value);
        public static UniTask<BackendReturnObject> SetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, float value)
            => Asynchronizer.Make(self.SetRandomData, randomType, uuid, value);
        public static UniTask<BackendReturnObject> SetRandomDataAsync(this BRandomInfo self, RandomType randomType, string uuid, double value)
            => Asynchronizer.Make(self.SetRandomData, randomType, uuid, value);
    }
}
