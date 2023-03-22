using BackEnd;
using BackEnd.Util;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BackendUtilsExtensions
    {
        public static UniTask<BackendReturnObject> GetLatestVersionAsync(this BackendUtils self)
            => Asynchronizer.Make(self.GetLatestVersion);

        public static UniTask<BackendReturnObject> GetServerStatusAsync(this BackendUtils self)
            => Asynchronizer.Make(self.GetServerStatus);

        public static UniTask<BackendReturnObject> GetServerTimeAsync(this BackendUtils self)
            => Asynchronizer.Make(self.GetServerTime);
    }
}
