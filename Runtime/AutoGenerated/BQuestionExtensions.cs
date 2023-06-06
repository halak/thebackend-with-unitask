using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BQuestionExtensions
    {
        public static UniTask<BackendReturnObject> GetDefaultQuestionFormAsync(this BQuestion self)
            => Asynchronizer.Make(self.GetDefaultQuestionForm);
        public static UniTask<BackendReturnObject> GetDefaultQuestionFormAsync(this BQuestion self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetDefaultQuestionForm, cancellationToken);

        public static UniTask<BackendReturnObject> GetQuestionAuthorizeAsync(this BQuestion self)
            => Asynchronizer.Make(self.GetQuestionAuthorize);
        public static UniTask<BackendReturnObject> GetQuestionAuthorizeAsync(this BQuestion self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetQuestionAuthorize, cancellationToken);

        public static UniTask<BackendReturnObject> GetQuestionListAsync(this BQuestion self)
            => Asynchronizer.Make(self.GetQuestionList);
        public static UniTask<BackendReturnObject> GetQuestionListAsync(this BQuestion self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetQuestionList, cancellationToken);
        public static UniTask<BackendReturnObject> GetQuestionListAsync(this BQuestion self, string firstKey)
            => Asynchronizer.Make(self.GetQuestionList, firstKey);
        public static UniTask<BackendReturnObject> GetQuestionListAsync(this BQuestion self, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetQuestionList, firstKey, cancellationToken);

        public static UniTask<BackendReturnObject> GetQuestionOneAsync(this BQuestion self, string questionIndate)
            => Asynchronizer.Make(self.GetQuestionOne, questionIndate);
        public static UniTask<BackendReturnObject> GetQuestionOneAsync(this BQuestion self, string questionIndate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetQuestionOne, questionIndate, cancellationToken);

        public static UniTask<BackendReturnObject> SendQuestionAsync(this BQuestion self, QuestionType questionType, string title, string content)
            => Asynchronizer.Make(self.SendQuestion, questionType, title, content);
        public static UniTask<BackendReturnObject> SendQuestionAsync(this BQuestion self, QuestionType questionType, string title, string content, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.SendQuestion, questionType, title, content, cancellationToken);

        public static UniTask<BackendReturnObject> UploadQuestionImageAsync(this BQuestion self)
            => Asynchronizer.Make(self.UploadQuestionImage);
        public static UniTask<BackendReturnObject> UploadQuestionImageAsync(this BQuestion self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UploadQuestionImage, cancellationToken);
    }
}
