using System;

namespace Documenti.Interop
{
    internal interface ICustomAction : IDisposable
    {
        long CodiceDitta { get; set; }
        string Numreg { get; set; }
        object ActiveInterface { get; set; }
        object Connessione { get; set; }
        bool IsOneShotAction { get; }
        EnumCustomActionsContext ExecutionContext { get; }
        void DoAction();
        void TerminateShot();
        void Terminate();
    }
}