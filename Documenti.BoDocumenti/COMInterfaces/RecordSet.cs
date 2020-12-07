using System;
using System.Collections;


namespace Documenti.Interop
{

    [ComProgId("ADODB.Recordset")]
    internal interface IRecordset : IDisposable
        {
            long AbsolutePage { get; set; }
            long AbsolutePosition { get; set; }
            object ActiveCommand { get; }
            IConnection ActiveConnection { get; set; }
            void AddNew();
            bool BOF { get; }
            object Bookmark { get; set; }
            long CacheSize { get; set; }
            void Cancel();
            void CancelBatch();
            void CancelUpdate();
            IRecordset Clone();
            void Close();
            CursorLocationEnum CursorLocation { get; set; }
            CursorTypeEnum CursorType { get; set; }
            string DataMember { get; set; }
            object DataSource { get; set; }
            void Delete();
            EditModeEnum EditMode { get; }
            bool EOF { get; }
            IFields Fields { get; }
            object Filter { get; set; }
            void Find(string criteria);
            object GetRows();
            string Index { get; set; }
            LockTypeEnum LockType { get; set; }
            void MoveFirst();
            void MoveNext();
            void MoveLast();
            void MovePrevious();
            IRecordset NextRecordset();
            void Open(string sql, IConnection activeConnection, int cursorTypeEnum = 0, int lockTypeEnum = 1, int commandTypeEnum = -1);
            long PageCount { get; set; }
            long PageSize { get; set; }
            int RecordCount { get; set; }
            void Requery();
            void Resync();
            void Save();
            string Sort { get; set; }
            object Source { get; set; }
            long State { get; }
            long Status { get; }
            void Update();
            void UpdateBatch();
        }

        internal enum CursorLocationEnum
        {
            adUseNone = 1,
            adUseServer = 2,
            adUseClient = 3,
            adUseClientBatch = 3
        }

    internal enum CursorTypeEnum
        {
            adOpenDynamic = 2,
            adOpenForwardOnly = 0,
            adOpenKeyset = 1,
            adOpenStatic = 3
            //adOpenUnspecified = Int32.MaxValue
        }

    internal enum EditModeEnum
        {
            adEditAdd = 2,
            adEditDelete = 4,
            adEditInProgress = 1,
            adEditNone = 0
        }

    internal enum LockTypeEnum
        {
            adLockBatchOptimistic = 4,
            adLockOptimistic = 3,
            adLockPessimistic = 2,
            adLockReadOnly = 1
            //adLockUnspecified = Int32.MaxValue
        }

    }


internal interface IFields : IEnumerable, IDisposable
    {
        object this[object Index] { get; }

        int Count { get; }
    }

    
