using System;
using System.Collections.Generic;
using System.Threading;
using BackEnd;
using BackEnd.Game.GameInfo;
using Cysharp.Threading.Tasks;

namespace Halak
{
    public static class BGameDataExtensions
    {
        public static UniTask<BackendReturnObject> DeleteAsync(this BGameData self, string tableName, Where where)
            => Asynchronizer.Make(self.Delete, tableName, where);
        public static UniTask<BackendReturnObject> DeleteAsync(this BGameData self, string tableName, Where where, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Delete, tableName, where, cancellationToken);

        public static UniTask<BackendReturnObject> DeleteV2Async(this BGameData self, string tableName, string inDate, string owner_inDate)
            => Asynchronizer.Make(self.DeleteV2, tableName, inDate, owner_inDate);
        public static UniTask<BackendReturnObject> DeleteV2Async(this BGameData self, string tableName, string inDate, string owner_inDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.DeleteV2, tableName, inDate, owner_inDate, cancellationToken);

        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where)
            => Asynchronizer.Make(self.Get, tableName, where);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, cancellationToken);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, int limit)
            => Asynchronizer.Make(self.Get, tableName, where, limit);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, int limit, string firstKey)
            => Asynchronizer.Make(self.Get, tableName, where, limit, firstKey);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, int limit, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, limit, firstKey, cancellationToken);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, int limit, string firstKey, TableSortOrder tableSortOrder)
            => Asynchronizer.Make(self.Get, tableName, where, limit, firstKey, tableSortOrder);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, int limit, string firstKey, TableSortOrder tableSortOrder, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, limit, firstKey, tableSortOrder, cancellationToken);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select)
            => Asynchronizer.Make(self.Get, tableName, where, select);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, select, cancellationToken);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select, int limit)
            => Asynchronizer.Make(self.Get, tableName, where, select, limit);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, select, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select, int limit, string firstKey)
            => Asynchronizer.Make(self.Get, tableName, where, select, limit, firstKey);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select, int limit, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, select, limit, firstKey, cancellationToken);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select, int limit, string firstKey, TableSortOrder tableSortOrder)
            => Asynchronizer.Make(self.Get, tableName, where, select, limit, firstKey, tableSortOrder);
        public static UniTask<BackendReturnObject> GetAsync(this BGameData self, string tableName, Where where, string[] select, int limit, string firstKey, TableSortOrder tableSortOrder, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Get, tableName, where, select, limit, firstKey, tableSortOrder, cancellationToken);

        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, string inDate)
            => Asynchronizer.Make(self.GetMyData, tableName, inDate);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, string inDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, inDate, cancellationToken);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, string inDate, string[] select)
            => Asynchronizer.Make(self.GetMyData, tableName, inDate, select);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, string inDate, string[] select, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, inDate, select, cancellationToken);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where)
            => Asynchronizer.Make(self.GetMyData, tableName, where);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, where, cancellationToken);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, int limit)
            => Asynchronizer.Make(self.GetMyData, tableName, where, limit);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, where, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, int limit, string firstKey)
            => Asynchronizer.Make(self.GetMyData, tableName, where, limit, firstKey);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, int limit, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, where, limit, firstKey, cancellationToken);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, string[] select)
            => Asynchronizer.Make(self.GetMyData, tableName, where, select);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, string[] select, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, where, select, cancellationToken);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, string[] select, int limit)
            => Asynchronizer.Make(self.GetMyData, tableName, where, select, limit);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, string[] select, int limit, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, where, select, limit, cancellationToken);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, string[] select, int limit, string firstKey)
            => Asynchronizer.Make(self.GetMyData, tableName, where, select, limit, firstKey);
        public static UniTask<BackendReturnObject> GetMyDataAsync(this BGameData self, string tableName, Where where, string[] select, int limit, string firstKey, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetMyData, tableName, where, select, limit, firstKey, cancellationToken);

        public static UniTask<BackendReturnObject> GetTableListAsync(this BGameData self)
            => Asynchronizer.Make(self.GetTableList);
        public static UniTask<BackendReturnObject> GetTableListAsync(this BGameData self, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetTableList, cancellationToken);

        public static UniTask<BackendReturnObject> GetV2Async(this BGameData self, string tableName, string inDate, string owner_inDate)
            => Asynchronizer.Make(self.GetV2, tableName, inDate, owner_inDate);
        public static UniTask<BackendReturnObject> GetV2Async(this BGameData self, string tableName, string inDate, string owner_inDate, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetV2, tableName, inDate, owner_inDate, cancellationToken);
        public static UniTask<BackendReturnObject> GetV2Async(this BGameData self, string tableName, string inDate, string ownerInDate, string[] select)
            => Asynchronizer.Make(self.GetV2, tableName, inDate, ownerInDate, select);
        public static UniTask<BackendReturnObject> GetV2Async(this BGameData self, string tableName, string inDate, string ownerInDate, string[] select, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.GetV2, tableName, inDate, ownerInDate, select, cancellationToken);

        public static UniTask<BackendReturnObject> InsertAsync(this BGameData self, string tableName, Param param)
            => Asynchronizer.Make(self.Insert, tableName, param);
        public static UniTask<BackendReturnObject> InsertAsync(this BGameData self, string tableName, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Insert, tableName, param, cancellationToken);
        public static UniTask<BackendReturnObject> InsertAsync(this BGameData self, string tableName)
            => Asynchronizer.Make(self.Insert, tableName);
        public static UniTask<BackendReturnObject> InsertAsync(this BGameData self, string tableName, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Insert, tableName, cancellationToken);

        public static UniTask<BackendReturnObject> TransactionReadV2Async(this BGameData self, TransactionValue[] transactionList)
            => Asynchronizer.Make(self.TransactionReadV2, transactionList);
        public static UniTask<BackendReturnObject> TransactionReadV2Async(this BGameData self, TransactionValue[] transactionList, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.TransactionReadV2, transactionList, cancellationToken);
        public static UniTask<BackendReturnObject> TransactionReadV2Async(this BGameData self, List<TransactionValue> transactionList)
            => Asynchronizer.Make(self.TransactionReadV2, transactionList);
        public static UniTask<BackendReturnObject> TransactionReadV2Async(this BGameData self, List<TransactionValue> transactionList, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.TransactionReadV2, transactionList, cancellationToken);

        public static UniTask<BackendReturnObject> TransactionWriteV2Async(this BGameData self, TransactionValue[] transactionList)
            => Asynchronizer.Make(self.TransactionWriteV2, transactionList);
        public static UniTask<BackendReturnObject> TransactionWriteV2Async(this BGameData self, TransactionValue[] transactionList, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.TransactionWriteV2, transactionList, cancellationToken);
        public static UniTask<BackendReturnObject> TransactionWriteV2Async(this BGameData self, List<TransactionValue> transactionList)
            => Asynchronizer.Make(self.TransactionWriteV2, transactionList);
        public static UniTask<BackendReturnObject> TransactionWriteV2Async(this BGameData self, List<TransactionValue> transactionList, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.TransactionWriteV2, transactionList, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateAsync(this BGameData self, string tableName, Where where, Param param)
            => Asynchronizer.Make(self.Update, tableName, where, param);
        public static UniTask<BackendReturnObject> UpdateAsync(this BGameData self, string tableName, Where where, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.Update, tableName, where, param, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateV2Async(this BGameData self, string tableName, string inDate, string owner_inDate, Param param)
            => Asynchronizer.Make(self.UpdateV2, tableName, inDate, owner_inDate, param);
        public static UniTask<BackendReturnObject> UpdateV2Async(this BGameData self, string tableName, string inDate, string owner_inDate, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateV2, tableName, inDate, owner_inDate, param, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateWithCalculationAsync(this BGameData self, string tableName, Where where, Param param)
            => Asynchronizer.Make(self.UpdateWithCalculation, tableName, where, param);
        public static UniTask<BackendReturnObject> UpdateWithCalculationAsync(this BGameData self, string tableName, Where where, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateWithCalculation, tableName, where, param, cancellationToken);

        public static UniTask<BackendReturnObject> UpdateWithCalculationV2Async(this BGameData self, string tableName, string inDate, string owner_inDate, Param param)
            => Asynchronizer.Make(self.UpdateWithCalculationV2, tableName, inDate, owner_inDate, param);
        public static UniTask<BackendReturnObject> UpdateWithCalculationV2Async(this BGameData self, string tableName, string inDate, string owner_inDate, Param param, CancellationToken cancellationToken)
            => Asynchronizer.MakeWithCancellation(self.UpdateWithCalculationV2, tableName, inDate, owner_inDate, param, cancellationToken);
    }
}
