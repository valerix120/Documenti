using System;
using System.Collections;
using Documenti.BoDocumenti;

namespace Documenti.Interop
{
    internal interface CLSMG_REGDOC : IDisposable, CLSMG_REGDOC_Events
    {
        CLSMG_REGDOCIN RegDocIn { get; set; }
        object LogRecuperoQuotazioneDaListinoP { get; set; }
        tsGiacNeg GiacenzaNegativa { get; set; }
        tsBloccoStatiArt BloccoStatiArticoli { get; set; }
        IRecordset RecordsetAcconti { get; set; }
        IEnumerable CollectionRsetAcconti { get; set; }
        bool Gbol_EseguitaImportazione { get; set; }
		object Scagl_Pag_Applicati { get; set; }
        //CLSLP_LISTINIP BOListiniP { get; set; }
		void ImpostaValoriTrasformazioneValore();
        long stato { get; set; }
        string TabDocCorpoLP { get; }
        bool EventChangedEnabled { get; set; }
        string StatoDesc { get; set; }
        string BloccoMerce_UpdateDocTestaInfo { get; }
		int NumeroDecimali { get; set; }
		//tsFlgSiNo GetFlgStScontr { get; }
        DateTime DataInizioIva22 { get; }
        object TotaliSimulazione { get; set; }
        object TotaliSimulazioneParziali { get; set; }
		object Verticali { get; }
        IRecordset rstDocTestata { get; set; }
        IRecordset rstDocTestaRif { get; set; }
        IRecordset rstDocTotali { get; set; }
        IRecordset rstDocDatiAcc { get; set; }
        IRecordset rstDocTestaRifFN { get; set; }
        IRecordset rstDocTestaPers { get; set; }
        IRecordset rstDocTesOrd { get; set; }
        IRecordset rstDocTesOrdAp { get; set; }
        IRecordset rstDocTestaEst { get; set; }
        IRecordset rstDocTestaProv { get; set; }
        IRecordset rstDocTestaRatei { get; set; }
        IRecordset rstDocTestaProge { get; set; }
        IRecordset rstDocTesAgenti { get; set; }
        IRecordset rstDocCorpo { get; set; }
        IRecordset rstDocCorpoOrd { get; set; }
        IRecordset rstDocCorpoProv { get; set; }
        IRecordset rstDocCorpoRif { get; set; }
        IRecordset rstDocCorpoRifSave { get; }
        IRecordset rstDocCorpoPers { get; set; }
        IRecordset rstDocCorpoEst { get; set; }
        IRecordset rstDocCorpoUbic { get; set; }
        IRecordset rstDocCorpoConf { get; set; }
        IRecordset rstDocCorpoBVM { get; set; }
        IRecordset rstDocCorpoProge { get; set; }
        IRecordset rstDocCorpoRatei { get; set; }
        IRecordset rstDocCorClRif { get; set; }
        IRecordset rstDocCorOrdDet { get; set; }
        IRecordset rstDocCorpoScMag { get; set; }
        IRecordset rstDocCorPrel { get; set; }
        IRecordset rstDocCorpoLot { get; set; }
        IRecordset rstDocCorpoLotSave { get; }
        IRecordset rstDocCorpoCoin { get; set; }
        IRecordset rstDocAcconti { get; set; }
        IRecordset rstDocCorpoGrid { get; set; }
        IRecordset rstDocCorpoConai { get; set; }
        IRecordset rstDocTestaCoin { get; set; }
        IRecordset rstDocTestaIntra { get; set; }
        IRecordset rstDocCorpoINTRA { get; set; }
        IRecordset rstDocCorpoPDC { get; set; }
        IRecordset rstDocTesSWH { get; set; }
        IRecordset rstDocCorSWH { get; set; }
        IRecordset rstDocCorpoRaggr { get; set; }
        IRecordset rstScadenze { get; set; }
        IRecordset rstControPartite { get; set; }
		IRecordset rstControPartiteLoc { get; set; }
        IRecordset rstControPartiteCorpo { get; set; }
        IRecordset rstCastIva { get; set; }
		IRecordset rstCastIvaLoc { get; set; }
        IRecordset rstDettCogeProge { get; set; }
        IRecordset rstDatiIntraPrimaNota { get; set; }
        IRecordset rstDatiIntraTestata { get; set; }
        IRecordset rstDatiIntraCorpo { get; set; }
        bool IsMovIntra { get; }
        bool CliForIntra { get; }
        tsRegDocIntra RegistraIntra { get; set; }
		IRecordset rstDocTestaVert { get; set; }
		IRecordset rstDocCorpoVert { get; set; }
		IRecordset rstDocTotaliVert { get; set; }
		bool rstDocTestaVertChanged { get; set; }
		bool rstDocCorpoVertChanged { get; set; }
		bool rstDocTotaliVertChanged { get; set; }
        bool rstDocTestataChanged { get; set; }
        bool rstDocTestaRifChanged { get; set; }
        bool rstDocTotaliChanged { get; set; }
        bool rstDocDatiAccChanged { get; set; }
        bool rstDocTestaRifFNChanged { get; set; }
        bool rstDocTestaPersChanged { get; set; }
        bool rstDocTesOrdChanged { get; set; }
        bool rstDocTesOrdApChanged { get; set; }
        bool rstDocTestaEstChanged { get; set; }
        bool rstDocTestaProvChanged { get; set; }
        bool rstDocTestaRateiChanged { get; set; }
        bool rstDocTestaProgeChanged { get; set; }
        bool rstDocTesAgentiChanged { get; set; }
        bool rstDocCorpoChanged { get; set; }
        bool rstDocCorpoOrdChanged { get; set; }
        bool rstDocCorpoProvChanged { get; set; }
        bool rstDocCorpoRifChanged { get; set; }
        bool rstDocCorpoPersChanged { get; set; }
        bool rstDocCorpoEstChanged { get; set; }
        bool rstDocCorpoUbicChanged { get; set; }
        bool rstDocCorpoConfChanged { get; set; }
        bool rstDocCorpoBVMChanged { get; set; }
        bool rstDocCorpoProgeChanged { get; set; }
        bool rstDocCorpoRateiChanged { get; set; }
        bool rstDocCorClRifChanged { get; set; }
		bool DisabilitaRicalcoloTotaliDaRigheCorpo { get; set; }
        bool rstDocCorOrdDetChanged { get; set; }
        bool rstDocCorpoScMagChanged { get; set; }
        bool rstDocCorPrelChanged { get; set; }
        bool RstDocCorpoLotChanged { get; set; }
        bool rstDocCorpoCoinChanged { get; set; }
        bool rstDocAccontiChanged { get; set; }
        bool rstDocCorpoGridChanged { get; set; }
        bool rstDocCorpoConaiChanged { get; set; }
        bool rstDocTestaCoinChanged { get; set; }
        bool rstDocTestaIntraChanged { get; set; }
        bool rstDocCorpoINTRAChanged { get; set; }
        bool rstDocCorpoPDCChanged { get; set; }
        bool rstDocTesSWHChanged { get; set; }
        bool rstDocCorSWHChanged { get; set; }
        bool rstDocCorpoRaggrChanged { get; set; }
        string strDocTestata { get; }
        string strDocTestaRif { get; }
        string strDocTotali { get; }
        string strDocDatiAcc { get; }
        string strDocTestaRifFN { get; }
        string strDocTestaPers { get; }
        string strDocTesOrd { get; }
        string strDocTesOrdAp { get; }
        string strDocTestaEst { get; }
        string strDocTestaProv { get; }
        string strDocTestaRatei { get; }
        string strDocTestaProge { get; }
        string strDocTesAgenti { get; }
        string strDocCorpo { get; }
        string strDocCorpoOrd { get; }
        string strDocCorpoProv { get; }
        string strDocCorpoRif { get; }
        string strDocCorpoPers { get; }
        string strDocCorpoEst { get; }
        string strDocCorpoUbic { get; }
        string strDocCorpoConf { get; }
        string strDocCorpoBVM { get; }
        string strDocCorpoProge { get; }
        string strDocCorpoRatei { get; }
        string strDocCorClRif { get; }
        string strDocCorOrdDet { get; }
        string strDocCorpoScMag { get; }
        string strDocCorPrel { get; }
        string strDocCorpoLot { get; }
        string strDocCorpoCoin { get; }
        string strDocAcconti { get; }
        string strDocCorpoGrid { get; }
        string strDocCorpoConai { get; }
        string strDocTestaCoin { get; }
        string strDocTestaIntra { get; }
        string strDocCorpoIntra { get; }
        string strDocCorpoPDC { get; }
        string strDocTesSWH { get; }
        string strDocCorSWH { get; }
        IRecordset RstArticoliConGiacenzaNegativa { get; set; }
        IRecordset RstArticoliConBloccoStatiArt { get; set; }
        bool TotaliAccVariati { get; set; }
        bool PrezziScontiMaggiorazioniVariati { get; set; }
        bool TotaliAccColliVar { get; set; }
        bool TotaliAccPesoVar { get; set; }
        bool TotaliAccVolVar { get; set; }
        bool SbilancioScadenzeAzzerato { get; set; }
		object PersDoc2 { get; }
		IRecordset rstImpDocOrigine { get; set; }
        void Initialize();
        void Terminate();
        object ClsMovimentazioneLotti { get; set; }
        bool EscludiGenerazioneAutomaticaRiferimentiArt62 { get; set; }
        void DisconnectRecordsets(bool ExecCancelUpdate = true, bool DisconnectTestata = false, bool DisconnectTestataChilds = true, bool DisconnectCorpo = true, bool DisconnectCorpoChilds = true);
        void ReconnectRecordsets(bool ExecReOpen = true, bool ReconnectTestata = false, bool ReconnectTestataChilds = true, bool ReconnectCorpo = true, bool ReconnectCorpoChilds = true);
        void OpenAllEmptyRecordsets();
        void OpenDocTestata(string str_appendToWhere);
        void OpenDocTestaRif(string str_appendToWhere);
        void OpenDocTotali(string str_appendToWhere);
        void OpenDocDatiAcc(string str_appendToWhere);
        void OpenDocTestaRifFN(string str_appendToWhere);
        void OpenDocTestaPers(string str_appendToWhere);
        void OpenDocTesOrd(string str_appendToWhere);
        void OpenDocTesOrdAp(string str_appendToWhere);
        void OpenDocTestaEst(string str_appendToWhere);
        void OpenDocTestaProv(string str_appendToWhere);
        void OpenDocTestaRatei(string str_appendToWhere);
        void OpenDocTestaProge(string str_appendToWhere);
        void OpenDocTesAgenti(string str_appendToWhere);
        void OpenDocCorpo(string str_appendToWhere);
        void OpenDocCorpoOrd(string str_appendToWhere);
        void OpenDocCorpoProv(string str_appendToWhere);
        void OpenDocCorpoRif(string str_appendToWhere);
        void OpenDocCorpoPers(string str_appendToWhere);
        void OpenDocCorpoEst(string str_appendToWhere);
        void OpenDocCorpoUbic(string str_appendToWhere);
        void OpenDocCorpoConf(string str_appendToWhere);
        void OpenDocCorpoBVM(string str_appendToWhere);
        void OpenDocCorpoProge(string str_appendToWhere);
        void OpenDocCorpoRatei(string str_appendToWhere);
        void OpenDocCorClRif(string str_appendToWhere);
        void OpenDocCorOrdDet(string str_appendToWhere);
        void OpenDocCorpoLP(string str_appendToWhere);
        void OpenDocCorpoScMag(string str_appendToWhere);
        void OpenDocCorPrel(string str_appendToWhere);
        void OpenDocCorpoLot(string str_appendToWhere);
        void OpenDocCorpoCoin(string str_appendToWhere);
        void OpenDocAcconti(string str_appendToWhere);
        void OpenDocCorpoGrid(string str_appendToWhere);
        void OpenDocCorpoConai(string str_appendToWhere);
        void OpenDocTestaCoin(string str_appendToWhere);
        void OpenDocTestaIntra(string str_appendToWhere);
        void OpenDocCorpoINTRA(string str_appendToWhere);
        void OpenDocCorpoPDC(string str_appendToWhere);
        void OpenDocTesSWH(string str_appendToWhere);
        void OpenDocCorSWH(string str_appendToWhere);
		void OpenDocTestaVert(string str_appendToWhere);
		void OpenDocCorpoVert(string str_appendToWhere);
		void OpenDocTotaliVert(string str_appendToWhere);
        void OpenDocCorpoRaggr(string str_appendToWhere);
		void SyncDocCorpoRaggr(bool EseguiSoloSincronizzazioneCampi = false, long ProgressivoRigaCorrente = 0);
        void OpenScadenze(string str_appendToWhere);
        void OpenControPartite(string str_appendToWhere);
        void OpenCastIva(string str_appendToWhere);
        void AddNewDocTestata(bool AlreadyAddNew = false, bool AddNewChilds = true, bool SuggerisciNumeroDocumento = true);
        void AddNewDocTestaRif(bool AlreadyAddNew = false);
        void AddNewDocTotali(bool AlreadyAddNew = false);
        void AddNewDocDatiAcc(bool AlreadyAddNew = false);
        void AddNewDocTestaRifFN(bool AlreadyAddNew = false);
        void AddNewDocTestaPers(bool AlreadyAddNew = false);
        void AddNewDocTesOrd(bool AlreadyAddNew = false);
        void AddNewDocTesOrdAp(bool AlreadyAddNew = false);
        void AddNewDocTestaEst(bool AlreadyAddNew = false);
        void AddNewDocTestaProv(bool AlreadyAddNew = false);
        void AddNewDocTestaRatei(bool AlreadyAddNew = false);
        void AddNewDocTestaProge(bool AlreadyAddNew = false);
        void AddNewDocTesAgenti(bool AlreadyAddNew = false);
        void AddNewDocCorpo(bool AlreadyAddNew = false, long ProgRiga = 0, long ProgVisuaSta = 0, bool AddNewChilds = true);
        void AddNewDocCorpoOrd(bool AlreadyAddNew = false);
        void AddNewDocCorpoProv(bool AlreadyAddNew = false);
        void AddNewDocCorpoRif(bool AlreadyAddNew = false);
        void AddNewDocCorpoPers(bool AlreadyAddNew = false);
        void AddNewDocCorpoEst(bool AlreadyAddNew = false);
        void AddNewDocCorpoUbic(bool AlreadyAddNew = false);
        void AddNewDocCorpoConf(bool AlreadyAddNew = false);
        void AddNewDocCorpoBVM(bool AlreadyAddNew = false);
        void AddNewDocCorpoProge(bool AlreadyAddNew = false);
        void AddNewDocCorpoRatei(bool AlreadyAddNew = false);
        void AddNewDocCorClRif(bool AlreadyAddNew = false);
        void AddNewDocCorOrdDet(bool AlreadyAddNew = false);
        void AddNewDocCorpoScMag(bool AlreadyAddNew = false, object fclsRstDocCorpo = null);
        void AddNewDocCorPrel(bool AlreadyAddNew = false);
        void AddNewDocCorpoLot(bool AlreadyAddNew = false);
        void AddNewDocCorpoCoin(bool AlreadyAddNew = false, bool ProponiConti = false);
        void AddNewDocAcconti(bool AlreadyAddNew = false);
        void AddNewDocCorpoGrid(bool AlreadyAddNew = false);
        void AddNewDocCorpoConai(bool AlreadyAddNew = false);
        void AddNewDocTestaCoin(bool AlreadyAddNew = false);
        void AddNewDocTestaIntra(bool AlreadyAddNew = false);
        void AddNewDocCorpoINTRA(bool AlreadyAddNew = false);
        void AddNewDocCorpoPDC(bool AlreadyAddNew = false);
        void AddNewDocTesSWH(bool AlreadyAddNew = false);
        void AddNewDocCorSWH(bool AlreadyAddNew = false);
		void AddNewDocTestaVert(bool AlreadyAddNew = false);
		void AddNewDocCorpoVert(bool AlreadyAddNew = false);
		void AddNewDocTotaliVert(bool AlreadyAddNew = false);
        void AddNewDocCorpoRaggr(bool AlreadyAddNew = false, long ProgVisuaSta = 0, bool AddNewChilds = true);
        void ModifyDocTestata(string NumeroRegistrazione = "", bool OpenChilds = true);
        void ModifyDocCorpo(long ProgRiga = 0, bool FilterChilds = true, bool AddNewChildsIfNoRows = true);
        void DeleteDocTestata(string NumeroRegistrazione = "", bool SegnalazioneMancatoRipristinoNumDoc = false);
        void DeleteDocTestaRif();
        void DeleteDocTotali();
        void DeleteDocDatiAcc();
        void DeleteDocTestaRifFN();
        void DeleteDocTestaPers();
        void DeleteDocTesOrd();
        void DeleteDocTesOrdAp();
        void DeleteDocTestaEst();
        void DeleteDocTestaProv();
        void DeleteDocTestaRatei();
        void DeleteDocTestaProge();
        void DeleteDocTesAgenti();
        void DeleteDocCorpo(bool AlreadyDelete = false, bool DeleteChilds = true, bool RinumeraProgVisuaSta = true);
        void DeleteDocCorpoOrd();
        void DeleteDocCorpoProv();
        void DeleteDocCorpoRif();
        void DeleteDocCorpoPers();
        void DeleteDocCorpoEst();
        void DeleteDocCorpoUbic();
        void DeleteDocCorpoConf();
        void DeleteDocCorpoBVM();
        void DeleteDocCorpoProge();
        void DeleteDocCorpoINTRA();
        void DeleteDocCorpoRatei();
        void DeleteDocCorClRif();
        void DeleteDocCorOrdDet();
        void DeleteDocCorpoScMag();
        void DeleteDocCorPrel();
        void DeleteDocCorpoLot();
        void DeleteDocCorpoCoin();
        void DeleteDocAcconti();
        void DeleteDocCorpoGrid();
        void DeleteDocCorpoConai();
        void DeleteDocTestaCoin();
        void DeleteDocTestaIntra();
        void DeleteDocCorpoPDC();
        void DeleteDocTesSWH();
        void DeleteDocCorSWH();
        void DeleteDocCorpoRaggr(bool AlreadyDelete = false, bool DeleteChilds = true);
        bool ControllaMemorizzazioneDocumento();
        void UpdateDocTestata(bool AlreadyUpdate = false, bool UpdateChilds = true);
        void UpdateDocTestaRif();
        void UpdateDocTotali();
        void UpdateDocDatiAcc();
        void UpdateDocTestaRifFN();
        void UpdateDocTestaPers();
        void UpdateDocTesOrd();
        void UpdateDocTesOrdAp();
        void UpdateDocTestaEst();
        void UpdateDocTestaProv();
        void UpdateDocTestaRatei();
        void UpdateDocTestaProge();
        void UpdateDocTesAgenti();
        void UpdateDocCorpo(bool AlreadyUpdate = false, bool UpdateChilds = true, bool ElaboraDistintaBaseCongelata = true, bool RicalcolaTotaliDocumento = true, bool CalcolaImportiRiga = true, bool CalcolaCostiRiga = true, bool CalcolaProvvigioniRiga = true);
        void UpdateDocCorpoOrd();
        void UpdateDocCorpoProv();
        void UpdateDocCorpoRif();
        void UpdateDocCorpoPers();
        void UpdateDocCorpoEst();
        void UpdateDocCorpoUbic();
        void UpdateDocCorpoConf();
        void UpdateDocCorpoBVM();
        void UpdateDocCorpoProge();
        void UpdateDocCorpoINTRA();
        void UpdateDocCorpoRatei();
        void UpdateDocCorClRif();
        void UpdateDocCorOrdDet();
        void UpdateDocCorpoScMag();
        void UpdateDocCorPrel();
        void UpdateDocCorpoLot();
        void UpdateDocCorpoCoin();
        void UpdateDocAcconti();
        void UpdateDocCorpoGrid();
        void UpdateDocCorpoConai();
        void UpdateDocTestaCoin();
        void UpdateDocTestaIntra();
        void UpdateDocCorpoPDC();
        void UpdateDocTesSWH();
        void UpdateDocCorSWH();
		void UpdateDocTestaVert();
		void UpdateDocCorpoVert();
		void UpdateDocTotaliVert();
        void UpdateDocCorpoRaggr(bool AlreadyUpdate = false, bool UpdateChilds = true);
        void EseguiAssociazioneAccontiManuale();
        void EseguiAssociazioneAccontiAutomatica();
        void CambiaDocTestataCliFor(object CodiceClienteFornitore, bool ImpostaDatiTestata = true, bool RicalcolaPrezziRiga = false, bool ImpostaDatiContabilitaIndustriale = true, bool RideterminaContropartita = true);
        void CambiaDocTestataCliForDest(object Destinatario, bool ImpostaDatiTestata = true);
        void CambiaDocTestataCliForFatt(object CliForPerFatturazione, bool RicalcolaPrezziRiga = false);
        void CambiaDocTestataCodPag(object CodicePagamento, bool RideterminaContropartita = true);
        void CambiaDocTestataDataCambio(object DataCambio);
        void CambiaDocTestataDataDoc(object DataDocumento);
        void CambiaDocTestataDataReg(object DataRegistrazione);
        void CambiaDocTestataFlgSpBolli(object FlagSpeseBolli);
        void CambiaDocTestataFlgSpincas(object FlagSpeseIncasso);
        bool CambiaDocTestataFlgEvasVal(object FlagEvasVal, bool CambiaRigheCorpo);
		void CambiaDocTestataFlgTaxLiable(object FlagTaxLiable, bool CambiaRigheCorpo);
		void CambiaDocCorpoFlgContribPrev(object FlagContribPrev);
        bool CambiaDocCorpoFlgEvasVal(object FlagEvasVal);
        void CambiaDocTestataSezAutofattura(object Sezionale, bool SuggerisciNuovoNumero = true);
        void CambiaDocTestataNumAutofattura(object Numero);
        void CambiaDocTestataSezDoc(string SezionaleDocumento, bool SuggerisciNuovoNumero = true, string SezionaleDocumentoPrecedente = "", bool RipristinaVecchioNumero = true, bool RideterminaContropartita = true);
        void CambiaDocTestataCCPassivo(object IDContoCorrente);
        void CambiaDocTestataCausalePrest(object CausalePrest, bool RideterminaContropartita = true);
        void CambiaDocTestataCIG(object CodiceCIG);
        void CambiaDocTestataCUP(object CodiceCUP);
		void CambiaDocCorpoCIG(object CodiceCIG);
		void CambiaDocCorpoCUP(object CodiceCUP);
        void CambiaDocScadenzeCIG(object CodiceCIG);
        void CambiaDocScadenzeProgrBanca(object ProgressivoBanca);
        void CambiaDocScadenzeDataScadenza(object DataScadenza);
        void CambiaDocScadenzeCodiceCartaCredito(object CodiceCartaCredito);
        void CambiaDocTestataLettInt(object IDLettera);
        void CambiaDocTestataUfficioPA(string CodUfficioPA, object CodiceAnagraficaGenerale);
        void CambiaDocTestataRiferAmmPA(string CodRiferAmmPA, string CodUfficioPA);
        void CambiaDocTestataNumDoc(object NumeroDocumento);
        void CambiaDocTestataNumDocOrig(object NumeroDocumentoOrigine);
        void CambiaDocTestataFlgDocBis(object FlagDocumentoBis);
        void CambiaDocTestataSezPart(object SezionalePartita);
        void CambiaDocTestataNumPart(object NumeroPartita);
        void CambiaDocTestataFlgPartBis(object FlagPartitaBis);
        void CambiaDocTestataCodDep(object CodiceDeposito, bool ImpostaDatiContabilitaIndustriale = true, bool RideterminaContropartita = true);
        void CambiaDocTestataCodDepCol(object CodiceDeposito);
        void CambiaDocTestataCausMag(object CausaleMagazzino);
        void CambiaDocTestataValuta(object CodiceValuta, bool RicalcoloImportiRiga = false);
        void CambiaDocTestataCambio(object Cambio);
        void CambiaDocTestataAliva(object Codice);
        void CambiaDocTestataBanca(object CodiceBanca);
        void CambiaDocTestataCodCab(object CodiceAgenzia);
        void CambiaDocTestataProgrBanca(object ProgressivoBanca);
        void CambiaDocTestataIndIncl3k(object Num);
        void CambiaDocTotaliAbbuono(object Abbuono, bool RicalcolaScadenze = true);
        void CambiaDocTotaliAbbuonoVal(object Abbuono, bool RicalcolaScadenze = true);
        void CambiaDocTotaliAcconto(object Acconto, bool RicalcolaScadenze = true);
        void CambiaDocTotaliAccontoVal(object Acconto, bool RicalcolaScadenze = true);
        void CambiaDocTotaliScImpCassa(object ScontoImportoCassa);
        void CambiaDocTotaliScImpCassaVal(object ScontoImportoCassa);
        void CambiaDocTotaliScImpMerce(object ScontoImportoMerce);
        void CambiaDocTotaliScImpArt26(object ScontoImportoMerce2);
        void CambiaDocTotaliscPercArt26(object ScontoPercArt26, bool RicalcolaImportiProvvigioni = false);
        void CambiaDocTotaliScImpMerceVal(object ScontoImportoMerce);
        void CambiaDocTotaliScImpArt26Val(object ScontoImportoMerce2Val);
        void CambiaDocTotaliScPerCassa1(object ScontoPercentualeCassa1);
        void CambiaDocTotaliScPerCassa2(object ScontoPercentualeCassa2);
        void CambiaDocTotaliScPerMerce1(object ScontoPercentualeMerce1, bool RicalcolaImportiProvvigioni = false);
        void CambiaDocTotaliScPerMerce2(object ScontoPercentualeMerce2, bool RicalcolaImportiProvvigioni = false);
        void CambiaDocTotaliScPerMerce3(object ScontoPercentualeMerce3, bool RicalcolaImportiProvvigioni = false);
        void CambiaDocTotaliImpEnasAge(object ImportoEnasarcoAgente);
        void CambiaDocTotaliImpEnasAgeVal(object ImportoEnasarcoAgenteVal);
        void CambiaDocTotaliImpEnasAzie(object ImportoEnasarcoAzienda);
        void CambiaDocTotaliImpEnasAzieVal(object ImportoEnasarcoAziendaVal);
        void CambiaDocTotaliImpAltreRit(object ImportoAltreRitenute);
        void CambiaDocTotaliImpAltreRitVal(object ImportoAltreRitenuteVal);
        void CambiaDocDatiAccAspetto(object Aspetto, bool RicalcolaPrezziRiga = false);
        void CambiaDocDatiAccCausaleTrasporto(object CausaleTrasporto, bool RicalcolaPrezziRiga = false);
        void CambiaDocDatiAccImballo(object Imballo, bool RicalcolaPrezziRiga = false);
        void CambiaDocDatiAccPorto(object Porto, bool RicalcolaPrezziRiga = false);
        void CambiaDocDatiAccTipoSpedizione(object TipoSpedizione, bool RicalcolaPrezziRiga = false);
        void CambiaDocDatiAccTotalePesoNetto(object TotalePesoNetto);
        void CambiaDocDatiAccTotalePesoLordo(object TotalePesoLordo);
        void CambiaDocDatiAccTotaleColli(object TotaleColli);
        void CambiaDocDatiAccTotaleVolume(object TotaleVolume);
        void CambiaDocDatiAccVettore1(object Vettore1);
        void CambiaDocDatiAccVettore2(object Vettore2, bool RicalcolaPrezziRiga = false);
        void CambiaDocTesOrdDataCons(object DataConsegna, bool ModificaSuRigheCorpo = false);
        void CambiaDocTesOrdDataConsInt(object DataConsegna, bool ModificaSuRigheCorpo = false);
        void CambiaDocTesOrdDataConsOrig(object DataConsegna, bool ModificaSuRigheCorpo = false);
        void CambiaDocTestaRateiDataInizioCompetenza(object DataInizioCompetenza);
        void CambiaDocTestaRateiDataFineCompetenza(object DataFineCompetenza);
        void CambiaDocCorpoRateiDataInizioCompetenza(object DataInizioCompetenza);
        void CambiaDocCorpoRateiDataFineCompetenza(object DataFineCompetenza);
        void CambiaDocTestaProgeProgetto(object Progetto, object SottoProgetto, bool ModificaSuRigheCorpo = false, bool ImpostaDatiContabilitaIndustriale = true, bool RideterminaContropartita = true);
        void CambiaDocTestataStagione(object Stagione, bool ModificaSuRigheCorpo = false, bool RideterminaContropartita = true);
        void CambiaDocTestataDivisione(object IDDivisione, bool ModificaSuRigheCorpo = false, bool RideterminaContropartita = true);
        void CambiaDocTestataSede(object CodiceSede, bool ModificaSuRigheCorpo = false);
        void CambiaDocTestaProgeProgettoColl(object Progetto, object SottoProgetto, bool ModificaSuRigheCorpo = false);
        void CambiaDocTestaProgeCommessa(object Commessa, object SottoCommessa, bool ModificaSuRigheCorpo = false, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocTestaProgeDipendente(object Dipendente, bool ModificaSuRigheCorpo = false, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocTestaProgeNodoRif(object NodoDiRiferimento, bool ModificaSuRigheCorpo = false, bool ImpostaDatiContabilitaIndustriale = true, bool RideterminaContropartita = true);
        void CambiaDocTestaProgeNodoRifCol(object NodoDiRiferimentoCollegato, bool ModificaSuRigheCorpo = false);
        void CambiaDocTestataPercentualeProvvigioni(object PercentualeProvvigioni, bool FlagRicalcoloProvvigioni = true);
        void CambiaDocTesAgentiAgente(object CodiceAgente, bool FlagRicalcoloProvvigioni = false, bool RicalcolaContropartite = true);
		void CambiaDocTestataIdAgente(object IdAgente, bool FlagRicalcoloProvvigioni = false, bool RicalcolaContropartite = true);
        void CambiaDocCorpoIndTipoRiga(object Num);
        void CambiaDocCorpoCodDep(object CodiceDeposito, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoDivisione(object IDDivisione);
        void CambiaDocCorpoStagione(object IDStagione);
        void CambiaDocCorpoCodart(object CodiceArticolo, object CodiceVariante, bool ImpostaAltriDatiArticolo = true, bool ImpostaDatiContabilitaIndustriale = true, bool ImpostaDatiDettaglioConai = true);
        void CambiaDocCorpoDescrizioniArticolo(object fvarDescrizione, object fvarDescrizioneEstesa);
        void CambiaDocCorpoCodiceArticoloCliente(object fvarCodiceArticoloCliente);
        void CambiaDocCorpoCodiceArticoloFornitore(object fvarCodiceArticoloFornitore);
        void CambiaDocCorpoCodSpesa(object CodiceSpesa, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoFase(object Codice);
        void CambiaDocCorpoConfConfezione(object fvarCodice);
        void CambiaDocCorpoTestoFix(object Codice);
        void CambiaDocCorpoNodo(object Codice, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoAttivita(object Codice, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoSpesaProgetto(object Codice, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoAliva(object Codice);
        void CambiaDocCorpoAlivaEffettiva(object Codice);
        void CambiaDocCorpoIvaRidotta(object Codice);
        void CambiaDocCorpoCodPag(object CodicePagamento);
		void CambiaDocCorpoCostoTot(object CostoTot);
		void CambiaDocCorpoCostoTotVal(object CostoTot);
        void CambiaDocCorpoOrdDataCons(object DataConsegna);
        void CambiaDocCorpoOrdDataConsInt(object DataConsegna);
        void CambiaDocCorpoOrdDataConsOrig(object DataConsegna);
        void CambiaDocCorpoColli(object Num, bool FlagRicalcolaQuantita1 = false, bool FlagRicalcolaQuantita2 = false, bool FlagRicalcolaQuantitaCF = false);
        void CambiaDocCorpoPzConf(object Num, bool FlagRicalcolaQuantita1 = false, bool FlagRicalcolaQuantita2 = false, bool FlagRicalcolaQuantitaCF = false);
        void CambiaDocCorpoQta1(object Num, bool FlagRicalcolaPrezzo = true, bool FlagRicalcolaQuantita2 = false, bool FlagRicalcolaQuantitaCF = false);
        void CambiaDocCorpoQta2(object Num, bool FlagRicalcolaQuantita1 = false, bool FlagRicalcolaQuantitaCF = false);
        void CambiaDocCorpoQtaCF(object Num, bool FlagRicalcolaQuantita1 = false, bool FlagRicalcolaQuantita2 = false);
        void CambiaDocCorpoPrezzo1(object Num, bool FlagRicalcolaPrezzo2 = false, bool FlagRicalcolaPrezzoCF = false);
        void CambiaDocCorpoPrezzo1Iva(object Num, bool FlagRicalcolaPrezzo2 = false, bool FlagRicalcolaPrezzoCF = false);
        void CambiaDocCorpoPrezzo2(object Num, bool FlagRicalcolaPrezzo1 = false, bool FlagRicalcolaPrezzoCF = false);
        void CambiaDocCorpoPrezzo2Iva(object Num, bool FlagRicalcolaPrezzo1 = false, bool FlagRicalcolaPrezzoCF = false);
        void CambiaDocCorpoPrezzoCF(object Num, bool FlagRicalcolaPrezzo1 = false, bool FlagRicalcolaPrezzo2 = false);
        void CambiaDocCorpoPrezzoCFIva(object Num, bool FlagRicalcolaPrezzo1 = false, bool FlagRicalcolaPrezzo2 = false);
        void CambiaDocCorpoScPer1(object Num);
        void CambiaDocCorpoScPer2(object Num);
        void CambiaDocCorpoScPer3(object Num);
        void CambiaDocCorpoScPer4(object Num);
        void CambiaDocCorpoScPer5(object Num);
        void CambiaDocCorpoScPer6(object Num);
        void CambiaDocCorpoScImp(object Num);
        void CambiaDocCorpoMagPer1(object Num);
        void CambiaDocCorpoMagPer2(object Num);
        void CambiaDocCorpoMagImp(object Num);
        void CambiaDocCorpoIndTipoOmag(object Num);
        void CambiaDocCorpoIndAliqTipo(object Num);
        void CambiaDocCorpoSede(object CodiceSede);
        void CambiaDocCorpoCpMerce(object ContoContropartita, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoProgeCommessa(object Commessa, object SottoCommessa, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoProgeProgetto(object Progetto, object SottoProgetto, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoProgeNodoRif(object NodoDiRiferimento, bool ImpostaDatiContabilitaIndustriale = true);
        void CambiaDocCorpoProgeDipendente(object Dipendente, bool ImpostaDatiContabilitaIndustriale = true);
        void CalcolaPrezzoDaBaseVariantiMoltiplicatori(bool CalcolaImportiRiga = true);
        void RicalcolaPrezzo();
        void RicalcolaCostoRiga();
        void RicalcolaImportoRiga();
        void RicalcolaImportoRigaRel(IRecordset fclsRstCorpo);
        void RicalcolaImportoRigaConPrezziIvati();
        void RicalcolaImportiProvvigioni();
        void SincronizzaDistinteBasiCongelate();
        void FiltraRecordsetsCorpo(long ProgressivoRiga = 0);
        void RicalcolaTotaliDaRigheCorpo(bool ImportoNettoScontiPiede = true, bool ContropartiteCastellettoIva = true, bool TotaliDocumento = true, bool Scadenze = true, bool UltimoProgressivoRiga = true, bool TotaliProvvigioni = true);
		void RicTot_OpenContropartite(bool TotaliSenzaContabilita, bool ContropartiteCastellettoIva, bool Scadenze);        
		bool VisualizzaFasiLavorazioni(int TipoDistinta, string CodiceDistinta);
        void SetRecordsetFieldValue(string RecordsetName, string ColumnName, object ColumnValue);
        object GetRecordsetFieldValue(string RecordsetName, string ColumnName);
        object BeforePrintReport();
        object AfterPrintReport();
        bool IsDocumentoDAS();
        void StampaDAS();
        bool ControllaDatiDAS();
        bool MemorizzaDatiDAS(bool InValidazione = false);
        bool EliminaDatiDAS();
        void VisualizzaDatiDAS();
        bool IsDocumentoVuotiCauzioni();
        bool ControllaMovimentiVuotiCauzioni();
        bool EliminaMovimentiVuotiCauzioni();
        bool MemorizzaMovimentiVuotiCauzioni();
        void VisualizzaMovimentiVuotiCauzioni();
        bool ControllaEsistenzaPianiDiConsegna();
        void ImpostaNumeriRegistrazioneDocumentiOrigine(object ArrayNumeriRegistrazioni);
        void MovimentazioneLottiPerRiga(bool SenzaQuantita);
        void MovimentazioneLottiPerDocumento(object ArticoloProdottoFinito, object VarianteProdottoFinito, object LottoProdottoFinito, bool SoloInizializzazioneProgressiviPD = false);
        void GeneraRigheContributoConai();
        bool ImpostaDatiIntra();
        bool QuadraturaLottiPerDocumento(bool VisualizzaSquadrature, bool RegistraDocumentoSquadrato, bool ContinuaRegistrazione, bool CreaRstSquadrature);
        //CLSCO_DATIDIV_DOCUMENTO DatiDivDocumento { get; set; }
        //CLSCO_DATIDIV_CLIFOR DatiDivClifor { get; set; }
        //CLSCO_DATIDIV_ARTICOLO DatiDivArticolo { get; set; }
		object CalcProvv2 { get; set; }
        //CLSCO_GESTSTATI BoStatoTestata { get; set; }
        //CLSCO_GESTSTATI BoStatoCorpo { get; set; }
        object GestioneArchiviazioneTestata { get; set; }
        object BoArchiviazioneTestata { get; set; }
		bool GrigliaVariantiAttiva { get; set; }
		double TotIvaScadenzeBeniUsati { get; }
		double TotIvaScadenzeBeniUsati_Val { get; }
        bool PrezzoDaListiniParametrici();
        bool CostoDaListiniParametrici();
        bool ElementoListiniPAttivo(string fstrElemento);
        void SuggerisciPrezzo(object ParametriInDeroga, object PrezzoLordo, object Sconto1Perc, object Sconto2Perc, object Sconto3Perc, object Sconto4Perc, object Sconto5Perc, object Sconto6Perc, object ScontoImp, object Magg1Perc, object Magg2Perc, object MaggImp, object PrezzoNetto, object PrezzoIvaInclusa, object Log);
        void DocCorpoImpostaDatiIntra(int fintTipo, object fvarCodice);
        void AggiornaDataConsegnaInterna(IRecordset rsDocCodrpoOrd, IRecordset rsRigaCorpo, object vDataCons);
        void RecuperaDatiCorpo();
        void SimulaRicalcoloTotaliDaRigheCorpo(string FiltroCorpo = "", string FiltroAvanzato = "");
        bool EsplodiProdottoKit(object fvarBookmarkRigaDaEsplodere, long ProgressivoVisualizzazioneStampa = 0, bool EsplodiDistintaBase = false);
        string SezDocDefault();
        string DepositoDefault();
        object GetTabellaPrioritaListiniP();
        object GetTabellaPrioritaListiniPArticolo(string fstrArticolo);
        EnumCauseBloccoModifica DocumentoModificabile();
        bool CanApplyFlagBis();
        bool ControllaProforma();
		bool IsKitEsploso(object ProgRiga);
        void ValorizzaFasiLavorazione(bool pTutte = true);
        bool PrezzoFasiDaListiniParametrici();
        bool IsDocumentoConFasi();
        void GetCausaleContabile(string strCausaleContabile, string strCausaleIva, string strDescrCausaleContabile, bool bolNoIva, bool bolIvaDifferita);
        void SuggerisciNumeroAutofattura(object AnnoDocumento, object DataDocumento, object SezionaleAutofattura, bool SuggerisciEAggiorna, object fvarNumeroAutofattura, int fintTipoNumerazioneAutofattura);
        string GetSezionaleAutofattura(string fstrCausaleIva);
        bool IsGestioneIvaEditoria(string strCausaleContabile);
        bool IsCorpoIvaEditoria();
        bool IsQuantitaMinimaMultipla(short TipoVenditaAcquisto, object Articolo, object QuantitaDaControllare, object QuantitaMinima, object QuantitaMultipla, string MsgError);
        void SplitScadenzeCIG();
        void AttributiEstesi_Undo();
        void StampaDocumento(bool ForzaRichiestaOpzioniDiStampa = false);
        void ArchiviaDocumento();
        void VisualizzaDocumentoArchiviato();
        void ConfiguraRstGestiti(string fstrDocumento, int fintStdPers);
        void BloccoMerce_AzioniFlagNonEvadibile(long Ditta, string ElencoNumReg, object TipoDoc, object STipodoc);
        bool BloccoMerce_RilevaBlocchiAssegnazioni(string ElencoNumReg, object TipoDoc, object STipodoc, long ProgRiga = 0);
        int DeleteCollegate(bool fbolFLGDACONSOLID);
        void CambiaDocCorpoPesoLordo(object Valore);
        void CambiaDocCorpoPesoNetto(object Valore);
        void CambiaDocCorpoVolume(object Valore);
        void AggiornaStatoEvasioneDocumento(string ElencoNumReg);
        bool CambiaDocTesAttributi(string Codice, object Valore);
        bool CambiaDocTesAttributiSottoEnt(int STipo);
        void CambiaDocCorpoIDConfBase(object fvarIDConfBase);
        int GetIndTipoIvaDefault(object varCodiceConto, object varCodiceIva, object varCodiceIvaComp);
        bool IsIndTipoIvaValid(object varTipoIva, object varCodiceIva, object varCodiceIvaComp, object varErrore);
        double GetTotaleIvaAutofattura(double TotaleIvaAutofatturaValuta);
        //bool IsElementoDaConsiderare(EnumContropartiteElemento Elemento);
        void GeneraRiferimentiArt62();
        bool VerificheArt62(string fstrEsitoVerifica, bool fbolEsitoMixArticoli = false, bool fbolEsitoScadenzeEffetti = false);
        bool DocumentoSoggettoArt62();
        bool ControllaValiditaAnagrafica(object CodiceClienteFornitore, object CodiceValido, string ErrorDescription);
        bool ControllaValiditaAnagraficaExt(object TipoCF, object CodiceClienteFornitore, object DataValidita, bool CheckDismissione, object CodiceValido, string ErrorDescription);
        string DeterminaContropartita();
		string DeterminaContoMagazzino();
		string DeterminaContoDiffPrezzoMateriali();
		string DeterminaContoCostoVenduto();
        void ImpostaPrezziPerRigaDaLordo(object fvarPrezzoLordo, int fintUM, bool fbolIvaCompresa);
        object CostoUltimoDelDeposito(DateTime DataElaborazione, string CodiceArticolo, string CodiceOpzione, string CodiceDeposito, object QuantitaMovimento, object ValoreMovimento);
        object GetCodiceIvaEffettivo(int IndTipoRiga, int IndTipoOmag, object CodiceIva, object FlgIvaRidotta, object FlgIvaCompensazione, object CodiceIvaCompensazione, string MsgError);
        bool RicalcolaProvvigioniDocumento(bool ValutaPresenzaAgentiNeiDestinatari = false);
        void RideterminaCodiceIvaEffettivoRigheCorpo();
        bool IsPrevistaAutoFattura();
        object GetCodiceCartaCreditoPreferenziale(object ProgrBancaAziendale, object TipoEffetto, object SottoTipoEffetto);
        //bool IsChiusuraAutomaticaEffetti(TipoEffettoEnum TipoEffetto);
        bool EsisteCartaCredito(object BancaAziendale, object TipoEff, object SottoTipoEff, object CodiceCarta);
		void CalcolaImportiMarginePercentuali();
		void CalcolaValoriRigaAccorpata(IRecordset rst);
		void UIBeforeUpdateDocument(bool fbolCancel);
		void UIAfterUpdateDocument();
		void UIBeforeDeleteDocument(bool fbolCancel);
		void UIAfterDeleteDocument();
		void UIBeforeNewDocument(bool fbolCancel);
		void UIAfterNewDocument();
		void UIBeforeAddNewDocBody(bool fbolCancel);
		void UIAfterAddNewDocBody();
		void UIBeforeUpdateDocBody(bool fbolCancel);
		void UIAfterUpdateDocBody();
		void UIBeforeDeleteDocBody(bool fbolCancel);
		void UIAfterDeleteDocBody();
		void UIBeforeSchedaArticoli(bool fbolCancel);
		void UIAfterSchedaArticoli(object varMoltiplicatore, object rstRecordsetSchedaAnagrafica, object rstRecordsetSchedaDettaglio);
		void CheckDocumentoConRegistrazioneIntra();
		void CambiaDocCorpoArticoloEPU(object IDArticoloEPU);
		long DeterminaPosizioneRiga(long currPos = 0);
		void CambiaDocTestataTipoConversione(object Num);
		void CambiaDocTestataFlgCliFat(object FlagCliFat);
		void CambiaDocTestataFlgDatiClFat(object FlagDatiClFat);
		short GetTipoBancaCliFor(int TipoDocumento, int SottotipoDocumento, object TipoCF);
		object GetIDBancaCliFor(object TipoCF, object CodiceClienteFornitore, short TipoBanca, object Banca, object Agenzia, object ContoCorrente);
		void GetInfoBancaCliForPreferenziale(object TipoCF, object CodiceClienteFornitore, object IDBanca, object Banca, object Agenzia, object ContoCorrente);
		void Termina();
		void RicalcolaProvvigioniInteroDocumento();
    }
}