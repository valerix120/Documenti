using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.Interop
{
    internal interface CLSMG_REGTRASFDOC : IDisposable
    {
        CLSMG_REGTRASFDOCIN RegTrasfDocIn { get; set; }
        void OpenRecordsets(string FiltroTestata = "", 
                            string FiltroTestaRif = "", 
                            string FiltroTesAgenti = "", 
                            string FiltroPianiDiCarico = "", 
                            string FiltroCorpo = "", 
                            string FiltroArticoli = "",
                            string OrdinamentoTestata = "",
                            string OrdinamentoCorpo = "",
                            string FiltroDataConsegna = "",
                            string FiltroDO17 = "",
                            string FiltroDO20 = "",
                            string FiltroDO35 = "",
                            string FiltroDO36 = "");

        void EvasioneTotaleDocumenti(object IndiceRottura);
        bool GeneraSingoloDocumento(object IndiceRottura);
        void Terminate();
        void Initialize();

    } 
}
