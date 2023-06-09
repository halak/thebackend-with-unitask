using System;
using System.Threading;
using BackEnd;
using BackEnd.Game.Guild;
using BackEnd.GlobalSupport;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BGuildExtensions
    {
        public static UniTask<BackendReturnObject> ApplyGuildV3Async(this BGuild self, string guildIndate)
            => Asynchronizer.Make(self.ApplyGuildV3, guildIndate);
        public static UniTask<BackendReturnObject> ApplyGuildV3Async(this BGuild self, string guildIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ApplyGuildV3, guildIndate, cancellationToken);

        public static UniTask<BackendReturnObject> ApproveApplicantV3Async(this BGuild self, string gamerIndate)
            => Asynchronizer.Make(self.ApproveApplicantV3, gamerIndate);
        public static UniTask<BackendReturnObject> ApproveApplicantV3Async(this BGuild self, string gamerIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ApproveApplicantV3, gamerIndate, cancellationToken);

        public static UniTask<BackendReturnObject> ContributeGoodsV3Async(this BGuild self, goodsType type, int amount)
            => Asynchronizer.Make(self.ContributeGoodsV3, type, amount);
        public static UniTask<BackendReturnObject> ContributeGoodsV3Async(this BGuild self, goodsType type, int amount, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ContributeGoodsV3, type, amount, cancellationToken);

        public static UniTask<BackendReturnObject> ContributeGoodsV4Async(this BGuild self, goodsType type, int amount)
            => Asynchronizer.Make(self.ContributeGoodsV4, type, amount);
        public static UniTask<BackendReturnObject> ContributeGoodsV4Async(this BGuild self, goodsType type, int amount, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ContributeGoodsV4, type, amount, cancellationToken);

        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount)
            => Asynchronizer.Make(self.CreateGuildV3, guildName, goodsCount);
        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CreateGuildV3, guildName, goodsCount, cancellationToken);
        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount, CountryCode countryCode)
            => Asynchronizer.Make(self.CreateGuildV3, guildName, goodsCount, countryCode);
        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount, CountryCode countryCode, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CreateGuildV3, guildName, goodsCount, countryCode, cancellationToken);
        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount, Param param)
            => Asynchronizer.Make(self.CreateGuildV3, guildName, goodsCount, param);
        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CreateGuildV3, guildName, goodsCount, param, cancellationToken);
        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount, Param param, CountryCode countryCode)
            => Asynchronizer.Make(self.CreateGuildV3, guildName, goodsCount, param, countryCode);
        public static UniTask<BackendReturnObject> CreateGuildV3Async(this BGuild self, string guildName, int goodsCount, Param param, CountryCode countryCode, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.CreateGuildV3, guildName, goodsCount, param, countryCode, cancellationToken);

        public static UniTask<BackendReturnObject> ExpelMemberV3Async(this BGuild self, string gamerIndate)
            => Asynchronizer.Make(self.ExpelMemberV3, gamerIndate);
        public static UniTask<BackendReturnObject> ExpelMemberV3Async(this BGuild self, string gamerIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ExpelMemberV3, gamerIndate, cancellationToken);

        public static UniTask<BackendReturnObject> GetApplicantsV3Async(this BGuild self)
            => Asynchronizer.Make(self.GetApplicantsV3);
        public static UniTask<BackendReturnObject> GetApplicantsV3Async(this BGuild self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetApplicantsV3, cancellationToken);
        public static UniTask<BackendReturnObject> GetApplicantsV3Async(this BGuild self, int limit)
            => Asynchronizer.Make(self.GetApplicantsV3, limit);
        public static UniTask<BackendReturnObject> GetApplicantsV3Async(this BGuild self, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetApplicantsV3, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetApplicantsV3Async(this BGuild self, int limit, int offset)
            => Asynchronizer.Make(self.GetApplicantsV3, limit, offset);
        public static UniTask<BackendReturnObject> GetApplicantsV3Async(this BGuild self, int limit, int offset, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetApplicantsV3, limit, offset, cancellationToken);

        public static UniTask<BackendReturnObject> GetGuildGoodsByIndateV3Async(this BGuild self, string guildIndate)
            => Asynchronizer.Make(self.GetGuildGoodsByIndateV3, guildIndate);
        public static UniTask<BackendReturnObject> GetGuildGoodsByIndateV3Async(this BGuild self, string guildIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildGoodsByIndateV3, guildIndate, cancellationToken);

        public static UniTask<BackendReturnObject> GetGuildIndateByGuildNameV3Async(this BGuild self, string guildName)
            => Asynchronizer.Make(self.GetGuildIndateByGuildNameV3, guildName);
        public static UniTask<BackendReturnObject> GetGuildIndateByGuildNameV3Async(this BGuild self, string guildName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildIndateByGuildNameV3, guildName, cancellationToken);

        public static UniTask<BackendReturnObject> GetGuildInfoV3Async(this BGuild self, string guildIndate)
            => Asynchronizer.Make(self.GetGuildInfoV3, guildIndate);
        public static UniTask<BackendReturnObject> GetGuildInfoV3Async(this BGuild self, string guildIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildInfoV3, guildIndate, cancellationToken);

        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self)
            => Asynchronizer.Make(self.GetGuildListV3);
        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildListV3, cancellationToken);
        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self, int limit)
            => Asynchronizer.Make(self.GetGuildListV3, limit);
        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildListV3, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self, string firstKey)
            => Asynchronizer.Make(self.GetGuildListV3, firstKey);
        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildListV3, firstKey, cancellationToken);
        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self, int limit, string firstKey)
            => Asynchronizer.Make(self.GetGuildListV3, limit, firstKey);
        public static UniTask<BackendReturnObject> GetGuildListV3Async(this BGuild self, int limit, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildListV3, limit, firstKey, cancellationToken);

        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate)
            => Asynchronizer.Make(self.GetGuildMemberListV3, guildIndate);
        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildMemberListV3, guildIndate, cancellationToken);
        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate, string firstKey)
            => Asynchronizer.Make(self.GetGuildMemberListV3, guildIndate, firstKey);
        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildMemberListV3, guildIndate, firstKey, cancellationToken);
        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate, int limit)
            => Asynchronizer.Make(self.GetGuildMemberListV3, guildIndate, limit);
        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildMemberListV3, guildIndate, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate, int limit, string firstKey)
            => Asynchronizer.Make(self.GetGuildMemberListV3, guildIndate, limit, firstKey);
        public static UniTask<BackendReturnObject> GetGuildMemberListV3Async(this BGuild self, string guildIndate, int limit, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGuildMemberListV3, guildIndate, limit, firstKey, cancellationToken);

        public static UniTask<BackendReturnObject> GetMyGuildGoodsV3Async(this BGuild self)
            => Asynchronizer.Make(self.GetMyGuildGoodsV3);
        public static UniTask<BackendReturnObject> GetMyGuildGoodsV3Async(this BGuild self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyGuildGoodsV3, cancellationToken);

        public static UniTask<BackendReturnObject> GetMyGuildInfoV3Async(this BGuild self)
            => Asynchronizer.Make(self.GetMyGuildInfoV3);
        public static UniTask<BackendReturnObject> GetMyGuildInfoV3Async(this BGuild self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyGuildInfoV3, cancellationToken);

        [Obsolete("GetRandomGuildInfoV3 is deprecated, please use RandomInfo function instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> GetRandomGuildInfoV3Async(this BGuild self, int limit)
            => Asynchronizer.Make(self.GetRandomGuildInfoV3, limit);
        [Obsolete("GetRandomGuildInfoV3 is deprecated, please use RandomInfo function instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> GetRandomGuildInfoV3Async(this BGuild self, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetRandomGuildInfoV3, limit, cancellationToken);
        [Obsolete("GetRandomGuildInfoV3 is deprecated, please use RandomInfo function instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> GetRandomGuildInfoV3Async(this BGuild self, string metaKey, int value, int gap, int limit)
            => Asynchronizer.Make(self.GetRandomGuildInfoV3, metaKey, value, gap, limit);
        [Obsolete("GetRandomGuildInfoV3 is deprecated, please use RandomInfo function instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> GetRandomGuildInfoV3Async(this BGuild self, string metaKey, int value, int gap, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetRandomGuildInfoV3, metaKey, value, gap, limit, cancellationToken);
        [Obsolete("GetRandomGuildInfoV3 is deprecated, please use RandomInfo function instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> GetRandomGuildInfoV3Async(this BGuild self, string metaKey, long value, long gap, int limit)
            => Asynchronizer.Make(self.GetRandomGuildInfoV3, metaKey, value, gap, limit);
        [Obsolete("GetRandomGuildInfoV3 is deprecated, please use RandomInfo function instead.(This function will be removed in SDK-6.0.0 version.)")]
        public static UniTask<BackendReturnObject> GetRandomGuildInfoV3Async(this BGuild self, string metaKey, long value, long gap, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetRandomGuildInfoV3, metaKey, value, gap, limit, cancellationToken);

        public static UniTask<BackendReturnObject> ModifyGuildV3Async(this BGuild self, Param param)
            => Asynchronizer.Make(self.ModifyGuildV3, param);
        public static UniTask<BackendReturnObject> ModifyGuildV3Async(this BGuild self, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ModifyGuildV3, param, cancellationToken);

        public static UniTask<BackendReturnObject> ModifyGuildV4Async(this BGuild self, Param param)
            => Asynchronizer.Make(self.ModifyGuildV4, param);
        public static UniTask<BackendReturnObject> ModifyGuildV4Async(this BGuild self, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ModifyGuildV4, param, cancellationToken);

        public static UniTask<BackendReturnObject> NominateMasterV3Async(this BGuild self, string gamerIndate)
            => Asynchronizer.Make(self.NominateMasterV3, gamerIndate);
        public static UniTask<BackendReturnObject> NominateMasterV3Async(this BGuild self, string gamerIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.NominateMasterV3, gamerIndate, cancellationToken);

        public static UniTask<BackendReturnObject> NominateViceMasterV3Async(this BGuild self, string gamerIndate)
            => Asynchronizer.Make(self.NominateViceMasterV3, gamerIndate);
        public static UniTask<BackendReturnObject> NominateViceMasterV3Async(this BGuild self, string gamerIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.NominateViceMasterV3, gamerIndate, cancellationToken);

        public static UniTask<BackendReturnObject> RejectApplicantV3Async(this BGuild self, string gamerIndate)
            => Asynchronizer.Make(self.RejectApplicantV3, gamerIndate);
        public static UniTask<BackendReturnObject> RejectApplicantV3Async(this BGuild self, string gamerIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.RejectApplicantV3, gamerIndate, cancellationToken);

        public static UniTask<BackendReturnObject> ReleaseViceMasterV3Async(this BGuild self, string gamerIndate)
            => Asynchronizer.Make(self.ReleaseViceMasterV3, gamerIndate);
        public static UniTask<BackendReturnObject> ReleaseViceMasterV3Async(this BGuild self, string gamerIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ReleaseViceMasterV3, gamerIndate, cancellationToken);

        public static UniTask<BackendReturnObject> SetRegistrationValueV3Async(this BGuild self, bool immediateFlag)
            => Asynchronizer.Make(self.SetRegistrationValueV3, immediateFlag);
        public static UniTask<BackendReturnObject> SetRegistrationValueV3Async(this BGuild self, bool immediateFlag, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.SetRegistrationValueV3, immediateFlag, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateCountryCodeV3Async(this BGuild self, CountryCode code)
            => Asynchronizer.Make(self.UpdateCountryCodeV3, code);
        public static UniTask<BackendReturnObject> UpdateCountryCodeV3Async(this BGuild self, CountryCode code, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateCountryCodeV3, code, cancellationToken);

        public static UniTask<BackendReturnObject> UseGoodsV3Async(this BGuild self, goodsType type, int amount)
            => Asynchronizer.Make(self.UseGoodsV3, type, amount);
        public static UniTask<BackendReturnObject> UseGoodsV3Async(this BGuild self, goodsType type, int amount, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UseGoodsV3, type, amount, cancellationToken);

        public static UniTask<BackendReturnObject> UseGoodsV4Async(this BGuild self, goodsType type, int amount)
            => Asynchronizer.Make(self.UseGoodsV4, type, amount);
        public static UniTask<BackendReturnObject> UseGoodsV4Async(this BGuild self, goodsType type, int amount, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UseGoodsV4, type, amount, cancellationToken);

        public static UniTask<BackendReturnObject> WithdrawGuildV3Async(this BGuild self)
            => Asynchronizer.Make(self.WithdrawGuildV3);
        public static UniTask<BackendReturnObject> WithdrawGuildV3Async(this BGuild self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.WithdrawGuildV3, cancellationToken);
    }
}
