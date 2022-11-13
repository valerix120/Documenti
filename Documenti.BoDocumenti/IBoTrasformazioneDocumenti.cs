using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.BoTrasformazioneDocumenti
{
    interface IBoTrasformazioneDocumenti
    {
        void Inizializza(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta);
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

        void TrasformazioneDocumento(string modellotrasf,string numreg, object IndiceRottura);
        void Termina();
        void Inizialize();

    }
}



