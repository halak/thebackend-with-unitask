using System;
using System.Threading;
using BackEnd;
using BackEnd.RealTime;
using BackEnd.Tcp;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class GameMatchExtensions
    {
        public static UniTask<BackendReturnObject> GetMatchListAsync(this GameMatch self)
            => Asynchronizer.Make(self.GetMatchList);
        public static UniTask<BackendReturnObject> GetMatchListAsync(this GameMatch self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMatchList, cancellationToken);

        public static UniTask<BackendReturnObject> GetMatchRecordAsync(this GameMatch self, string gamerIndate, MatchType matchType, MatchModeType matchModeType, string matchCardIndate)
            => Asynchronizer.Make(self.GetMatchRecord, gamerIndate, matchType, matchModeType, matchCardIndate);
        public static UniTask<BackendReturnObject> GetMatchRecordAsync(this GameMatch self, string gamerIndate, MatchType matchType, MatchModeType matchModeType, string matchCardIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMatchRecord, gamerIndate, matchType, matchModeType, matchCardIndate, cancellationToken);
        public static UniTask<BackendReturnObject> GetMatchRecordAsync(this GameMatch self, string gamerIndate, MatchType matchType, MatchModeType matchModeType, string matchCardIndate, int limit)
            => Asynchronizer.Make(self.GetMatchRecord, gamerIndate, matchType, matchModeType, matchCardIndate, limit);
        public static UniTask<BackendReturnObject> GetMatchRecordAsync(this GameMatch self, string gamerIndate, MatchType matchType, MatchModeType matchModeType, string matchCardIndate, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMatchRecord, gamerIndate, matchType, matchModeType, matchCardIndate, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetMatchRecordAsync(this GameMatch self, string gamerIndate, MatchType matchType, MatchModeType matchModeType, string matchCardIndate, int limit, string offset)
            => Asynchronizer.Make(self.GetMatchRecord, gamerIndate, matchType, matchModeType, matchCardIndate, limit, offset);
        public static UniTask<BackendReturnObject> GetMatchRecordAsync(this GameMatch self, string gamerIndate, MatchType matchType, MatchModeType matchModeType, string matchCardIndate, int limit, string offset, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMatchRecord, gamerIndate, matchType, matchModeType, matchCardIndate, limit, offset, cancellationToken);

        public static UniTask<BackendReturnObject> IsGameRoomActivateAsync(this GameMatch self)
            => Asynchronizer.Make(self.IsGameRoomActivate);
        public static UniTask<BackendReturnObject> IsGameRoomActivateAsync(this GameMatch self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.IsGameRoomActivate, cancellationToken);
    }
}
