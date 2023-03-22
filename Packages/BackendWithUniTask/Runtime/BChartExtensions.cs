using System;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BChartExtensions
    {
        public static UniTask<BackendReturnObject> GetAllChartAndSaveAsync(this BChart self, bool isChartKeyIsName)
            => Asynchronizer.Make(self.GetAllChartAndSave, isChartKeyIsName);

        public static UniTask<BackendReturnObject> GetChartByFolderAndSaveAsync(this BChart self, int folderId, bool isChartKeyIsName)
            => Asynchronizer.Make(self.GetChartByFolderAndSave, folderId, isChartKeyIsName);

        public static UniTask<BackendReturnObject> GetChartContentsAsync(this BChart self, string chartFileId)
            => Asynchronizer.Make(self.GetChartContents, chartFileId);

        public static UniTask<BackendReturnObject> GetChartListAsync(this BChart self)
            => Asynchronizer.Make(self.GetChartList);

        public static UniTask<BackendReturnObject> GetChartListByFolderAsync(this BChart self, int folderId)
            => Asynchronizer.Make(self.GetChartListByFolder, folderId);

        public static UniTask<BackendReturnObject> GetOneChartAndSaveAsync(this BChart self, string chartFileId)
            => Asynchronizer.Make(self.GetOneChartAndSave, chartFileId);
        public static UniTask<BackendReturnObject> GetOneChartAndSaveAsync(this BChart self, string chartFileId, string chartName)
            => Asynchronizer.Make(self.GetOneChartAndSave, chartFileId, chartName);
    }
}
