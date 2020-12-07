using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.Interop
{
    internal interface CLSPD_AVANZPROD : IDisposable
    {
        string ServerName { get; set; }
        string NomeUtenteSQL { get; set; }
        string PwdUtenteSQL { get; set; }
        string DatabaseName { get; set; }
        tsEnumAvanzamentoProduzioneStatoErrore Stato { get; set; }
        tsEnumTipoAvanzamentoProduzione TipoAvanzamentoOrdiniProduzione { get; set; }
        tsEnumTipologiaOrdiniProduzione TipologiaOrdiniProduzione { get; set; }
        object CodiceDitta { get; set; }
        object CodiceGruppo { get; set; }
        object CodiceUtente { get; set; }
        object DataRegistrazione { get; set; }
        object Password { get; set; }
        string ErrorDescription { get; set; }
        IConnection ConnectionADO { get; set; }
        string ConnectionString { get; set; }
        string SezionaleManuale { get; set; }
        Boolean ModalitaPresidiata { get; set; }
        void ImpostaInterfacciaInterna(object ObjActiveInterface, object ObjADOConnection = null);
        void Initialize();
        void Terminate();
        void PreparaAvanzamentoOrdini(object NumeroRegistrazioneIniziale = null,
                                        object NumeroRegistrazioneFinale = null,
                                        object NumeroDocumentoIniziale = null,
                                        object NumeroDocumentoFinale = null,
                                        object DataRegistrazioneIniziale = null,
                                        object DataRegistrazioneFinale = null,
                                        object DataDocumentoIniziale = null,
                                        object DataDocumentoFinale = null,
                                        object SezionaleDocumentoIniziale = null,
                                        object SezionaleDocumentoFinale = null,
                                        object ProgressivaRigaOrdineIniziale = null,
                                        object ProgressivaRigaOrdineFinale = null,
                                        object CodiceArticoloIniziale = null,
                                        object CodiceArticoloFinale = null,
                                        object CodiceVarianteIniziale = null,
                                        object CodiceVarianteFinale = null,
                                        object CodiceFaseIniziale = null,
                                        object CodiceFaseFinale = null);
        void AvanzaSingolaFaseLavorazione(object NumeroRegistrazioneOrdine,
                                            object ProgressivoRigaOrdinet,
                                            object CodiceFaseLavorazione,
                                            object QuantitaAvanzamento,
                                            object DepositoAvanzamento,
                                            bool SaldoAvanzamento = false,
                                            object ProgressivoFaseLavorazione = null,
                                            string CodiceMacchina = "",
                                            tsEnumTipoTempo IndicatoreTempo = tsEnumTipoTempo.tsMinuti,
                                            object TempoAvanzamento = null,
                                            tsEnumTipoOrario TipoOrario = tsEnumTipoOrario.tsOrdinario,
                                            tsEnumTipoOra TipoOra = tsEnumTipoOra.tsLavorazione,
                                            tsEnumTipoLavorazione TipoLavorazione = tsEnumTipoLavorazione.tsInterna,
                                            string DepositoScarto = "",
                                            decimal QuantitaScarto = 0,
                                            decimal Quantita2Avanzamento = 0,
                                            decimal Quantita2Scarto = 0,
                                            string CodiceConfezione = "",
                                            decimal NumeroPalletColli = 0,
                                            decimal NumeroConfezioni = 0,
                                            decimal ColliXBancale = 1,
                                            decimal ConfezioniXCollo = 1,
                                            decimal PezziConfezione = 1);
        void AvanzamentoTempiPerRisorsa(object CodiceAttrezzo = null,
                                      object VarianteAttrezzo = null,
                                      object CodiceKitAttrezzi = null,
                                      object VarianteKitAttrezzi = null,
                                      string CodiceMacchina = "",
                                      string CodiceReparto = "",
                                      string CodiceDipendente = "",
                                      tsEnumTipoTempo IndicatoreTempo = 0,
                                      object TempoAvanzamento = null,
                                      tsEnumTipoOrario TipoOrario = 0,
                                      tsEnumTipoOra TipoOra = 0,
                                      tsEnumTipoLavorazione TipoLavorazione = 0);
        void ConfermaAvanzamentoFasiLavorazione(IConnection RSTFasiLavorazione = null);

    }
}
