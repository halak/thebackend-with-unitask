using System;
using System.Threading;
using BackEnd;
using BackEnd.Game;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BFunctionExtensions
    {
        public static UniTask<BackendReturnObject> GetFunctionListAsync(this BFunction self)
            => Asynchronizer.Make(self.GetFunctionList);
        public static UniTask<BackendReturnObject> GetFunctionListAsync(this BFunction self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetFunctionList, cancellationToken);

        public static UniTask<BackendReturnObject> InvokeFunctionAsync(this BFunction self, string funcName, Param body)
            => Asynchronizer.Make(self.InvokeFunction, funcName, body);
        public static UniTask<BackendReturnObject> InvokeFunctionAsync(this BFunction self, string funcName, Param body, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.InvokeFunction, funcName, body, cancellationToken);
    }
}
