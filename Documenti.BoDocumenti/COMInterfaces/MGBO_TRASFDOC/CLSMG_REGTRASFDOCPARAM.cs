using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.Interop
{
    internal interface CLSMG_REGTRASFDOCPARAM: IDisposable
    {
        tsTrasfDocIndCliFor INDCLIFORORIG { get; set; }
        tsTrasfDocIndCliFor INDCLIFORDEST { get; set; }
        tsTrasfDocIndTipoElab INDTIPOELAB { get; set; }



    }
}
