using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.BoAvanzamento
{
    interface IBoAvanzamento
    {
        void Inizializza(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta);
        long AvanzamentoODLMonolivello(DateTime dataRegistrazione, string depositoAvanzamento, string codiceArticolo, decimal quantitaAvanzamento, bool saldoAvanzamento, string variante = null, string depositoScarto = "", decimal quantitaScarto = 0, decimal quantita2Avanzamento = 0, decimal quantita2Scarto = 0);
        long PreparaAvanzamentoOrdini(object numeroRegistrazioneIniziale, object numeroRegistrazionFinale, DateTime dataRegistrazione);
        long AvanzaSingolaFaseLavorazione(object numeroRegistrazioneOrdine, object progressivoRigaOrdine, object codiceFaseLavorazione, decimal quantitaAvanzamento, string DepositoAvanzamento, bool SaldoAvanzamento = false, string depositoScarto = "", decimal quantitaScarto = 0, decimal quantita2Avanzamento = 0, decimal quantita2Scarto = 0);
        long ConfermaAvanzamentoFasiLavorazione();
        List<OdlDaAvanzare> CercaPrimoODLApertoPerArticolo(string server, string database, string utentesql, string password, string codiceArticolo, string variante = null);
        void Terminate();
        long GetStato();
    }
}



