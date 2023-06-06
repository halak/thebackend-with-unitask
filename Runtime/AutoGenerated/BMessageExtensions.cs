using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BMessageExtensions
    {
        public static UniTask<BackendReturnObject> DeleteReceivedMessageAsync(this BMessage self, string messageIndate)
            => Asynchronizer.Make(self.DeleteReceivedMessage, messageIndate);
        public static UniTask<BackendReturnObject> DeleteReceivedMessageAsync(this BMessage self, string messageIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.DeleteReceivedMessage, messageIndate, cancellationToken);

        public static UniTask<BackendReturnObject> DeleteSentMessageAsync(this BMessage self, string messageIndate)
            => Asynchronizer.Make(self.DeleteSentMessage, messageIndate);
        public static UniTask<BackendReturnObject> DeleteSentMessageAsync(this BMessage self, string messageIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.DeleteSentMessage, messageIndate, cancellationToken);

        public static UniTask<BackendReturnObject> GetReceivedMessageAsync(this BMessage self, string indate)
            => Asynchronizer.Make(self.GetReceivedMessage, indate);
        public static UniTask<BackendReturnObject> GetReceivedMessageAsync(this BMessage self, string indate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetReceivedMessage, indate, cancellationToken);

        public static UniTask<BackendReturnObject> GetReceivedMessageListAsync(this BMessage self)
            => Asynchronizer.Make(self.GetReceivedMessageList);
        public static UniTask<BackendReturnObject> GetReceivedMessageListAsync(this BMessage self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetReceivedMessageList, cancellationToken);

        public static UniTask<BackendReturnObject> GetSentMessageAsync(this BMessage self, string indate)
            => Asynchronizer.Make(self.GetSentMessage, indate);
        public static UniTask<BackendReturnObject> GetSentMessageAsync(this BMessage self, string indate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetSentMessage, indate, cancellationToken);

        public static UniTask<BackendReturnObject> GetSentMessageListAsync(this BMessage self)
            => Asynchronizer.Make(self.GetSentMessageList);
        public static UniTask<BackendReturnObject> GetSentMessageListAsync(this BMessage self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetSentMessageList, cancellationToken);

        public static UniTask<BackendReturnObject> SendMessageAsync(this BMessage self, string receiverIndate, string contents)
            => Asynchronizer.Make(self.SendMessage, receiverIndate, contents);
        public static UniTask<BackendReturnObject> SendMessageAsync(this BMessage self, string receiverIndate, string contents, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.SendMessage, receiverIndate, contents, cancellationToken);
    }
}
