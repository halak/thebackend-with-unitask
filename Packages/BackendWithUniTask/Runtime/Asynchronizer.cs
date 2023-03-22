using System;
using BackEnd;
using Cysharp.Threading.Tasks;

namespace Halak
{
    internal static class Asynchronizer
    {
        public static UniTask<BackendReturnObject> Make(Action<Backend.BackendCallback> function)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            var tcs = new UniTaskCompletionSource<BackendReturnObject>();
            function((bro) => tcs.TrySetResult(bro));
            return tcs.Task;
        }

        public static UniTask<BackendReturnObject> Make<T1>(Action<T1, Backend.BackendCallback> function, T1 arg1)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            var tcs = new UniTaskCompletionSource<BackendReturnObject>();
            function(arg1, (bro) => tcs.TrySetResult(bro));
            return tcs.Task;
        }

        public static UniTask<BackendReturnObject> Make<T1, T2>(Action<T1, T2, Backend.BackendCallback> function, T1 arg1, T2 arg2)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            var tcs = new UniTaskCompletionSource<BackendReturnObject>();
            function(arg1, arg2, (bro) => tcs.TrySetResult(bro));
            return tcs.Task;
        }

        public static UniTask<BackendReturnObject> Make<T1, T2, T3>(Action<T1, T2, T3, Backend.BackendCallback> function, T1 arg1, T2 arg2, T3 arg3)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            var tcs = new UniTaskCompletionSource<BackendReturnObject>();
            function(arg1, arg2, arg3, (bro) => tcs.TrySetResult(bro));
            return tcs.Task;
        }

        public static UniTask<BackendReturnObject> Make<T1, T2, T3, T4>(Action<T1, T2, T3, T4, Backend.BackendCallback> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            var tcs = new UniTaskCompletionSource<BackendReturnObject>();
            function(arg1, arg2, arg3, arg4, (bro) => tcs.TrySetResult(bro));
            return tcs.Task;
        }

        public static UniTask<BackendReturnObject> Make<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5, Backend.BackendCallback> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            var tcs = new UniTaskCompletionSource<BackendReturnObject>();
            function(arg1, arg2, arg3, arg4, arg5, (bro) => tcs.TrySetResult(bro));
            return tcs.Task;
        }

        public static UniTask<BackendReturnObject> Make<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6, Backend.BackendCallback> function, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (function == null)
                throw new ArgumentNullException(nameof(function));

            var tcs = new UniTaskCompletionSource<BackendReturnObject>();
            function(arg1, arg2, arg3, arg4, arg5, arg6, (bro) => tcs.TrySetResult(bro));
            return tcs.Task;
        }
    }
}
