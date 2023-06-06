using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BChartExtensions
    {
        public static UniTask<BackendReturnObject> GetAllChartAndSaveAsync(this BChart self, bool isChartKeyIsName)
            => Asynchronizer.Make(self.GetAllChartAndSave, isChartKeyIsName);
        public static UniTask<BackendReturnObject> GetAllChartAndSaveAsync(this BChart self, bool isChartKeyIsName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetAllChartAndSave, isChartKeyIsName, cancellationToken);

        public static UniTask<BackendReturnObject> GetAllChartAndSaveV2Async(this BChart self, bool isChartKeyIsName)
            => Asynchronizer.Make(self.GetAllChartAndSaveV2, isChartKeyIsName);
        public static UniTask<BackendReturnObject> GetAllChartAndSaveV2Async(this BChart self, bool isChartKeyIsName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetAllChartAndSaveV2, isChartKeyIsName, cancellationToken);

        public static UniTask<BackendReturnObject> GetChartByFolderAndSaveAsync(this BChart self, int folderId, bool isChartKeyIsName)
            => Asynchronizer.Make(self.GetChartByFolderAndSave, folderId, isChartKeyIsName);
        public static UniTask<BackendReturnObject> GetChartByFolderAndSaveAsync(this BChart self, int folderId, bool isChartKeyIsName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChartByFolderAndSave, folderId, isChartKeyIsName, cancellationToken);

        public static UniTask<BackendReturnObject> GetChartByFolderAndSaveV2Async(this BChart self, int folderId, bool isChartKeyIsName)
            => Asynchronizer.Make(self.GetChartByFolderAndSaveV2, folderId, isChartKeyIsName);
        public static UniTask<BackendReturnObject> GetChartByFolderAndSaveV2Async(this BChart self, int folderId, bool isChartKeyIsName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChartByFolderAndSaveV2, folderId, isChartKeyIsName, cancellationToken);

        public static UniTask<BackendReturnObject> GetChartContentsAsync(this BChart self, string chartFileId)
            => Asynchronizer.Make(self.GetChartContents, chartFileId);
        public static UniTask<BackendReturnObject> GetChartContentsAsync(this BChart self, string chartFileId, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChartContents, chartFileId, cancellationToken);

        public static UniTask<BackendReturnObject> GetChartListAsync(this BChart self)
            => Asynchronizer.Make(self.GetChartList);
        public static UniTask<BackendReturnObject> GetChartListAsync(this BChart self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChartList, cancellationToken);

        public static UniTask<BackendReturnObject> GetChartListByFolderAsync(this BChart self, int folderId)
            => Asynchronizer.Make(self.GetChartListByFolder, folderId);
        public static UniTask<BackendReturnObject> GetChartListByFolderAsync(this BChart self, int folderId, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChartListByFolder, folderId, cancellationToken);

        public static UniTask<BackendReturnObject> GetChartListByFolderV2Async(this BChart self, int folderId)
            => Asynchronizer.Make(self.GetChartListByFolderV2, folderId);
        public static UniTask<BackendReturnObject> GetChartListByFolderV2Async(this BChart self, int folderId, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChartListByFolderV2, folderId, cancellationToken);

        public static UniTask<BackendReturnObject> GetChartListV2Async(this BChart self)
            => Asynchronizer.Make(self.GetChartListV2);
        public static UniTask<BackendReturnObject> GetChartListV2Async(this BChart self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetChartListV2, cancellationToken);

        public static UniTask<BackendReturnObject> GetOneChartAndSaveAsync(this BChart self, string chartFileId)
            => Asynchronizer.Make(self.GetOneChartAndSave, chartFileId);
        public static UniTask<BackendReturnObject> GetOneChartAndSaveAsync(this BChart self, string chartFileId, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetOneChartAndSave, chartFileId, cancellationToken);
        public static UniTask<BackendReturnObject> GetOneChartAndSaveAsync(this BChart self, string chartFileId, string chartName)
            => Asynchronizer.Make(self.GetOneChartAndSave, chartFileId, chartName);
        public static UniTask<BackendReturnObject> GetOneChartAndSaveAsync(this BChart self, string chartFileId, string chartName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetOneChartAndSave, chartFileId, chartName, cancellationToken);

        public static UniTask<BackendReturnObject> GetOneChartAndSaveV2Async(this BChart self, string chartFileId)
            => Asynchronizer.Make(self.GetOneChartAndSaveV2, chartFileId);
        public static UniTask<BackendReturnObject> GetOneChartAndSaveV2Async(this BChart self, string chartFileId, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetOneChartAndSaveV2, chartFileId, cancellationToken);
        public static UniTask<BackendReturnObject> GetOneChartAndSaveV2Async(this BChart self, string chartFileId, string chartName)
            => Asynchronizer.Make(self.GetOneChartAndSaveV2, chartFileId, chartName);
        public static UniTask<BackendReturnObject> GetOneChartAndSaveV2Async(this BChart self, string chartFileId, string chartName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetOneChartAndSaveV2, chartFileId, chartName, cancellationToken);
    }
}
