using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BCouponExtensions
    {
        public static UniTask<BackendReturnObject> CouponListAsync(this BCoupon self)
            => Asynchronizer.Make(self.CouponList);

        public static UniTask<BackendReturnObject> UseCouponAsync(this BCoupon self, string couponCode)
            => Asynchronizer.Make(self.UseCoupon, couponCode);
    }
}
