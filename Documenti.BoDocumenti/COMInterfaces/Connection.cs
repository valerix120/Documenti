using System;

namespace Documenti.Interop
{

    [ComProgId("ADODB.Connection")]
    internal interface IConnection : IDisposable
    {
        string ConnectionString { get; set; }
    }
}
