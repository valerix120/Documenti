using Documenti.BoDocumenti;
using System;

namespace Documenti.Interop
{
    internal interface CLSMG_REGDOCBATCH : IDisposable
    {
        CLSMG_REGDOCIN RegDocIn { get; set; }
        tsEnumProgrammaChiamante ProgrammaChiamante { get; set; }
        tsGiacNegBatch GiacenzaNegativa { get; set; }
        tsBloccoStatiArtBatch BloccoStatiArticoli { get; set; }
        bool DatiDocumentoClienteFornitore { get; set; }
        bool CopiaDatiPersDaRifTestata { get; set; }
        bool CopiaDatiPersDaRifCorpo { get; set; }
        string CodiceOperatore { get; set; }
        bool DatiConfezioneArticoli { get; set; }
        bool bLoopRiga { get; set; }
        bool bIsArtPFObbligatorio { get; set; }
		bool UsaNumeroDocumentoSuggerito { get; set; }
        long stato { get; set; }
        string StatoDesc { get; set; }
        IRecordset RstArticoliConGiacenzaNegativa { get; set; }
        IRecordset RstArticoliConBloccoStatiArt { get; set; }
        void Initialize();
        void Terminate();
        void CreateTemporaryTables();
        void AddNewDocTestata(object CodiceDocumento, object TipoNumerazione, object NumeroDocumento, object SezionaleDocumento, object FlagDocumentoBis, object DataDocumento, object DataRegistrazione, object CodiceDeposito, object CodiceDepositoCollegato, object NumeroDocumentoOrigine, object TipoClienteFornitore, object CodiceClienteFornitore, object CondizionePagamento, object CodiceBanca, object CodiceAgenzia, object FlagSpeseBolli, object FlagSpeseIncasso, object CodiceValuta, object Cambio, object DataCambio, object NumeroListino, object CodiceReparto, object Destinatario, object IndGenerDoc);
        void AddNewDocTestataExt(object fclsCampi);
        void AddNewDocTestaProgeExt(object fclsCampi);
        void AddNewDocTotaliExt(object fclsCampi);
        void AddNewDocTestaRif(object TipoDocumento, object SottotipoDocumento, object NumeroVsDocumento, object DataVsDocumento, object RiferimentoVsDocumento, object NoteVsDocumento, object DataVsConferma, object NumeroNsDocumento, object SezionaleNsDocumento, object FlagNsDocumentoBis, object DataNsDocumento, object DataNsConferma, object RiferimentoNsDocumento, object NoteNsDocumento);
        void AddNewDocTesOrd(object DataConsegna, object Priorita, object FlagNonPiuEvadibile);
        void AddNewDocTestaPers(object fclsCampi);
        void AddNewDocTestaEst(object fclsCampi);
        void AddNewDocCorpoPers(object fclsCampi);
        void AddNewDocCorpoEst(object fclsCampi);
        void AddNewDocTestaRatei(object DaDataCompetenza, object ADataCompetenza);
        void AddNewDocCorpo(object IndicatoreTipoRiga, object CodiceArticolo, object VarianteArticolo, object DescrizioneRiga, object EstensioneDescrizioneRiga, object CodiceDeposito, object CodiceDepositoCollegato, object CausaleMagazzino, object Quantita1, object Quantita2, object QuantitaCF, object Colli, object Prezzo1, object Prezzo2, object PrezzoCF, object ScontoPercentuale1, object ScontoPercentuale2, object ScontoPercentuale3, object ScontoPercentuale4, object ScontoPercentuale5, object ScontoPercentuale6, object ScontoImporto, object MaggiorazionePercentuale1, object MaggiorazionePercentuale2, object MaggiorazioneImporto, object CostoDelVenduto, object AliquotaIva, object CodiceSpesa, object CodiceFase, object CodiceScheda, object CodiceTestoFisso, object CodiceArticoloCliente, object CodiceArticoloFornitore, object IDDistintaBase, object IndicatoreOrigineFabbisogni, object IndicatoreDistintaBaseCong, object ContropartitaMerce, object IndicatoreProvenienzaRiga);
        void AddNewDocCorpoExt(object fclsCampi);
        void AddNewDocCorpoOrd(object DataConsegna, object Quantita1Consegnata, object Quantita2Consegnata, object ColliConsegnati, object FlagNonPiuEvadibile, object DataInizioLavorazione, object IndicatoreStatoConsegnato, object NumeroProposta, object Quantita1TrasfPiano, object Quantita2TrasfPiano, object Qta1TrasfDdtCl, object Qta2TrasfDdtCl);
        void AddNewDocCorpoOrdExt(object fclsCampi);
        void AddNewDocCorpoRif(object TipoDocumento, object SottotipoDocumento, object NumeroRegistrazioneRiferimento, object ProgressivoRigaRiferimento, object NumeroVsDocumento, object DataVsDocumento, object RiferimentoVsDocumento, object NumeroNsDocumento, object SezionaleNsDocumento, object FlagNsDocumentoBis, object DataNsDocumento, object RiferimentoNsDocumento, object SequenzaFase, object CodiceFase, object NumeroRegistrazionePadre, object ProgressivoRigaPadre, object Quantita1Mov);
        void AddNewDocCorpoRifExt(object fclsCampi);
        void AddNewDocCorClRifExt(object fclsCampi);
        void AddNewDocCorpoConf(object CodiceConfezione, object Quantita1Confezione, object Quantita2Confezione, object ColliConfezione, object PezziPerConfezione, object UMPeso, object PesoLordo, object PesoNetto, object UMCapacita, object Capacita, object UMVolume, object Volume);
        void AddNewDocCorpoLotti(object ProgressivoMovimentazione, object Articolo, object Opzione, object Deposito, object Lotto, object Scadenza, object SerialNumber, object Pallets, object Progetto, object SottoProgetto, object Ubicazione, object Confezione, object BagnoMateriale, object Qta1, object Qta2, object Qta1Cons, object Qta2Cons, object IDMedia, object TipoCF, object Note, object ArticoloPF, object OpzionePF, object LottoPF, object NumeroRegistrazioneRiferimento, object ProgressivoRigaRiferimento, object ProgressivoRiferimento, object CausaleMagazzino, object FlagRigaNonPiuEvadibile);
        void AddNewDocCorpoProge(object CodiceProgetto, object CodiceSottoprogetto, object CodiceCommessa, object CodiceSottocommessa, object CodiceProgettoCollegato, object CodiceSottoprogettoCollegato, object CodiceNodo, object CodiceAttivita, object CodiceSpesa, object CodiceNodoRiferimento, object CodiceDipendente);
        void AddNewDocCorpoProgeExt(object fclsCampi);
		void AddNewDocCorpoRatei(object DaDataCompetenza, object ADataCompetenza);
        void AddNewDocCorOrdDet(object SequenzaFase, object CodiceFase, object Reparto, object Fornitore, object TipoCF, object Qta1Ord, object Qta2Ord, object ColliOrd, object Qta1Consolid, object Qta2Consolid, object ColliCons, object TempoFaseOre, object TempoFaseMin, object TempoFaseSec, object QtaPrevSpe, object NoteGenerali, object NoteMontaggio, object NoteCostruzione, object PercRicarica, object MacchinaAlt, object DataInizio, object DataFine, object Attrezzo, object VarianteAttrezzo, object KitAttrezzi, object IndicatoreStatoOrdine, object DescrizioneFase, object Prezzo1, object Prezzo2, object PrezzoCF);
        void AddNewDocCorOrdDetExt(object fclsCampi);
        void AddNewDocCorpoScMag(object id_sconto, object imp_sconto, object imp_sconto_val, object perc_sconto, object pdc_cg10, object cpsconto_cg24);
        //CLSMG_PERSDOC ClsPersDoc { get; }
        bool ScriviTabellaCO99 { get; set; }
        object NumeroRegistrazione { get; set; }
        bool UsaNumRegImpostato { get; set; }
        object SezionaleDocumento { get; }
        object NumeroDocumento { get; }
        object ProgressivoTestaRif { get; set; }
        object ProgressivoRigaCorpo { get; set; }
        object ProgressivoRigaCorpoRif { get; set; }
        object ProgressivoRigaTestaEst { get; set; }
        object ProgressivoRigaTestaPers { get; set; }
        object ProgressivoRigaCorpoEst { get; set; }
        object ProgressivoRigaCorpoPers { get; set; }
        object ProgressivoRigaCorpoOrdDet { get; set; }
        object ProgressivoRigaCorpoScMag { get; set; }
        object ProgressivoRigaCorpoLotti { get; set; }
        bool FlagAggiornamentoMagazzino { get; set; }
        void UpdateAll();
        tsDeleteAllDocBatch DeleteDocTestata(object NumeroRegistrazione, bool VerificaEsistenzaMovimentiContabili = true, bool EliminaTabellaCO99 = true, bool VerificaDocumentoEliminabile = true);
        tsDeleteDocCorpoBatch DeleteDocCorpo(object NumeroRegistrazione, object DaProgressivoRiga, object AProgressivoRiga, object TabProgRiga);
        tsModQtaConsBatch ModifyQtaConsegnata(object NumeroRegistrazione, object ProgressivoRiga, object Quantita1Consegnata, object Quantita2Consegnata, object ColliConsegnati, object RigaNonPiuEvadibile);
        tsNonEvadTestataBatch ModifyTestataNonEvadibile(object NumeroRegistrazione);
        tsNonEvadCorpoBatch ModifyCorpoNonEvadibile(object NumeroRegistrazione, object DaProgressivoRiga, object AProgressivoRiga);
        tsInitModifyAllDocumenti InitModifyAllDocumenti(string ElencoNumeriRegistrazione);
        tsUpdateModifyAllDocumenti UpdateModifyAllDocumenti(string ElencoNumeriRegistrazione, bool AggiornaSoloConsegnato = false);
        void MovimentazioneLottiPerRiga(bool SenzaQuantita, string CodDocumento, bool bIndietro = false, bool bSemilavorati = false);
        void MovimentazioneLottiPerDocumento(string CodDocumento, string CodDocumentoCarico, bool bSemilavorati = false);
        void SuggerisciPrezzoBatch(object ParametriInDeroga, object PrezzoLordo, object Sconto1Perc, object Sconto2Perc, object Sconto3Perc, object Sconto4Perc, object Sconto5Perc, object Sconto6Perc, object ScontoImp, object Magg1Perc, object Magg2Perc, object MaggImp, object PrezzoNetto, object PrezzoIvaInclusa, object Log, object IndUMPre, object IndDimeRif, object CodPag);
		void DeleteDocCorpoTemp(object NumeroRegistrazione, object DaProgressivoRiga, object AProgressivoRiga, object TabProgRiga);
    }
}