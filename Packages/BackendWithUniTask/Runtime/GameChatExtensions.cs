using System;
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

        public static UniTask<BackendReturnObject> GetGroupChannelListAsync(this GameChat self, string groupName)
            => Asynchronizer.Make(self.GetGroupChannelList, groupName);

        public static UniTask<BackendReturnObject> GetRecentChatAsync(this GameChat self, ChannelType channelType, string channelinDate)
            => Asynchronizer.Make(self.GetRecentChat, channelType, channelinDate);
        public static UniTask<BackendReturnObject> GetRecentChatAsync(this GameChat self, ChannelType channelType, string channelinDate, int limit)
            => Asynchronizer.Make(self.GetRecentChat, channelType, channelinDate, limit);

        public static UniTask<BackendReturnObject> ReportUserAsync(this GameChat self, string SelectedNickname, string Details)
            => Asynchronizer.Make(self.ReportUser, SelectedNickname, Details);
        public static UniTask<BackendReturnObject> ReportUserAsync(this GameChat self, string SelectedNickname, string Reason, string Details)
            => Asynchronizer.Make(self.ReportUser, SelectedNickname, Reason, Details);
    }
}
