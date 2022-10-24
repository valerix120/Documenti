using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.Interop
{
    internal interface CLSMG_REGTRASFDOCIN : IDisposable
    {
        object ActiveInterface { get; set; }
        IConnection Connection { get; set; }
        string ConnectionString { get; set; }
        long Ditta { get; set; }
        string Utente { get; set; }
        string Gruppo { get; set; }
        long IdUtente { get; set; }
        string ModelloTrasformazione { get; set; }
        bool GestDocCorpoGrid { get; set; }
        bool GestDocTestata { get; set; }
        bool GestDocTestaRif { get; set; }
        bool GestDocTestaPers { get; set; }
        bool GestDocTestaEst { get; set; }
        bool GestDocTesAgenti { get; set; }
        bool GestDocCorpo { get; set; }
        bool GestDocCorpoProv { get; set; }
        bool GestDocCorpoPers { get; set; }
        bool GestDocCorpoEst { get; set; }
        bool GestDocCorpoConf { get; set; }
        bool GestDocCorOrdDet { get; set; }
        bool GestDocCorpoLot { get; set; }
        bool GestDocCorpoConai { get; set; }
        bool GestDocCorpoPDC { get; set; }
        tsTrasfDocModalita Modalita { get; set; }
        bool VuotiModalitaBatch { get; set; }
    }
}
