using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.Interop
{
    internal enum tsTrasfDocModalita
    {
        tsTrasfDocModalitaImportazione = 0,
        tsTrasfDocModalitaEsportazione = 1,
        tsTrasfDocModalitaEvasioneMultiplaTrasformazione = 2
    }

    internal enum tsTrasfDocIndTipoElab
    {
        tsTrasfDocIndTipoElabConfermaManuale = 0,
        tsTrasfDocIndTipoElabTrasformazioneAutomatica = 1
    }

    internal enum tsTrasfDocIndCliFor
    {
        tsTrasfDocIndCliForNessuno = 0,
        tsTrasfDocIndCliForCliente = 1,
        tsTrasfDocIndCliForFornitore = 2
    }
   
}
