using ADODB;
using Documenti.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.BoDocumenti
{
    interface IBoDocumenti
    {
        void Inizializza(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta);
        void CreaDocumento(string coddocum, short pers);
        void CambiaDocTestataDataReg(DateTime datareg);
        void CambiaClifor(Int32 clifor);
        void CambiaClifor(Int32 clifor, Int32 coddest);
        void CambiaDocTestataCodDep(string coddep);
        void CambiaDocTestataCodDep(string coddep, string coddepcoll);
        bool GestDocCorpoProge();
        void CambiaDocTestaProgeCommessa(object codcommessa, object codsottocomessa, bool modificasurighecorpo);
        void ModificaDoc(string codicedoc, string numreg);
        void UpdateDocTestata();
        void AggiungiRigaArticolo(string codart, string variante, decimal qta1);
        void AggiungiRigaDescrittiva(string descrizione, string descrizioneest);
        void CambiaCodart(Int32 progriga, string codart, string variante);
        void CambiaQta1(Int32 progriga, decimal qta1);
        void CambiaDescrizioneRiga(Int32 progriga, string descrizione, string descrizioneest);
        DataTable RstDoccorpo();
        void UpdateDocCorpo();
        void DeleteDocCorpo();
        void Termina();
    }

}
