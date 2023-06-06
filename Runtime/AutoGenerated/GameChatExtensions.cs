using System;
using System.Threading;
using BackEnd;
using BackEnd.RealTime;
using BackEnd.Tcp;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class GameChatExtensions
    {
        public static UniTask<BackendReturnObject> GetChatStatusAsync(this GameChat self)
            => Asynchronizer.Make(self.GetChatStatus);
        public static UniTask<BackendReturnObject> GetChatStatusAsync(this GameChat self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChatStatus, cancellationToken);

        public static UniTask<BackendReturnObject> GetGroupChannelListAsync(this GameChat self, string groupName)
            => Asynchronizer.Make(self.GetGroupChannelList, groupName);
        public static UniTask<BackendReturnObject> GetGroupChannelListAsync(this GameChat self, string groupName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetGroupChannelList, groupName, cancellationToken);

        public static UniTask<BackendReturnObject> GetRecentChatAsync(this GameChat self, ChannelType channelType, string channelinDate)
            => Asynchronizer.Make(self.GetRecentChat, channelType, channelinDate);
        public static UniTask<BackendReturnObject> GetRecentChatAsync(this GameChat self, ChannelType channelType, string channelinDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetRecentChat, channelType, channelinDate, cancellationToken);
        public static UniTask<BackendReturnObject> GetRecentChatAsync(this GameChat self, ChannelType channelType, string channelinDate, int limit)
            => Asynchronizer.Make(self.GetRecentChat, channelType, channelinDate, limit);
        public static UniTask<BackendReturnObject> GetRecentChatAsync(this GameChat self, ChannelType channelType, string channelinDate, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetRecentChat, channelType, channelinDate, limit, cancellationToken);

        public static UniTask<BackendReturnObject> ReportUserAsync(this GameChat self, string SelectedNickname, string Details)
            => Asynchronizer.Make(self.ReportUser, SelectedNickname, Details);
        public static UniTask<BackendReturnObject> ReportUserAsync(this GameChat self, string SelectedNickname, string Details, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ReportUser, SelectedNickname, Details, cancellationToken);
        public static UniTask<BackendReturnObject> ReportUserAsync(this GameChat self, string SelectedNickname, string Reason, string Details)
            => Asynchronizer.Make(self.ReportUser, SelectedNickname, Reason, Details);
        public static UniTask<BackendReturnObject> ReportUserAsync(this GameChat self, string SelectedNickname, string Reason, string Details, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.ReportUser, SelectedNickname, Reason, Details, cancellationToken);
    }
}
