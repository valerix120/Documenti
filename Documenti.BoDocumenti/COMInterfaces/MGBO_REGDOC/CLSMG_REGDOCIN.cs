using Documenti.BoDocumenti;
using System;
using System.Collections;

namespace Documenti.Interop
{
    internal interface CLSMG_REGDOCIN : IDisposable
    {
        int SorgentePropostaDefault { get; set; }
        object NumeroRigheDaScrivere { get; set; }
        object NumeroRigheUpdateXML { get; set; }
        bool GestioneManualeAutofatture { get; set; }
        bool CodiceIvaTestataImpostatoManualmente { get; set; }
        int TipoSegnalazioneIVA21 { get; set; }
        int TipoSegnalazioneIVA22 { get; set; }
        string TabTempProFormaFattDef { get; set; }
		bool RilevazioneQuartaDisabilitata { get; set; }
        object ElenchiMov3000(IConnection ADOConnection);
        object GestioneAttributi { get; }
        bool ForzaBloccoPerTrasformazione { get; set; }
        bool ForzaBloccoPerStoricizzazione { get; set; }
        bool DisabilitaLogOpManListiniP { get; set; }
        bool GestionePromozioni { get; set; }
        bool GestioneAttributiFashion { get; set; }
        bool NotificaMessaggi { get; set; }
        bool IsDocumentoCollegato { get; set; }
		bool GestioneIntegrazioneNavision { get; set; }
        bool ForzaCaricamentoAgentiMultipli { get; set; }
        bool Transaction { get; set; }
        bool Avanzamento { get; set; }
        bool GestDocTestata { get; set; }
        bool GestDocDatiAcc { get; set; }
        bool GestDocTestaRifFN { get; set; }
        bool GestDocTestaPers { get; set; }
        bool GestDocTesOrd { get; set; }
        bool GestDocTesOrdAP { get; set; }
        bool GestDocTestaEst { get; set; }
        bool GestDocTestaRatei { get; set; }
        bool GestDocTestaProge { get; set; }
        bool GestDocTestaRif { get; set; }
        bool GestDocTotali { get; set; }
        bool GestDocTestaProv { get; set; }
        bool GestDocTesAgenti { get; set; }
        bool GestDocCorpo { get; set; }
        bool GestDocCorpoOrd { get; set; }
        bool GestDocCorpoPers { get; set; }
        bool GestDocCorpoEst { get; set; }
        bool GestDocCorpoBVM { get; set; }
        bool GestDocCorpoProge { get; set; }
        bool GestDocCorpoINTRA { get; set; }
        bool GestDocCorpoRatei { get; set; }
        bool GestDocCorpoSolp { get; set; }
        bool GestDocCorpoProv { get; set; }
        bool GestDocCorpoRif { get; set; }
        bool GestDocCorOrdDet { get; set; }
        bool GestDocCorpoScMag { get; set; }
        bool GestDocCorpoLP { get; set; }
        bool GestDocCorpoUbic { get; set; }
        bool GestDocCorpoConf { get; set; }
        bool GestDocCorClRif { get; set; }
        bool GestDocCorPrel { get; set; }
        bool GestDocCorpoLot { get; set; }
        bool GestDocCorpoCoin { get; set; }
        bool GestDocAcconti { get; set; }
        bool GestDocCorpoGrid { get; set; }
        bool GestDocCorpoConai { get; set; }
        bool GestDocTestaCoin { get; set; }
        bool GestDocTestaIntra { get; set; }
        bool GestDocTesSWH { get; set; }
        bool GestDocCorSWH { get; set; }
        bool GestDocCorpoPDC { get; set; }
        bool GestDocCorpoRaggr { get; set; }
		bool GestDocTestaVert { get; set; }
		bool GestDocCorpoVert { get; set; }
		bool GestDocTotaliVert { get; set; }
		bool GestioneDocumentoCollegato { get; set; }
        void AddCustomActions(string fstrKey, ICustomAction fclsAction);
        void RemoveCustomAction(string fstrKey);
        object ActiveInterface { get; set; }
        IConnection Connection { get; set; }
        string ConnectionString { get; set; }
        long Ditta { get; set; }
        string Documento { get; set; }
        bool UtilizzaConnessioneLocaleProgressivi { get; set; }
        bool UtilizzaConnessioneLocaleCalcoloCosti { get; set; }
        bool BatchMode { get; set; }
        bool UpdateWithTempTables { get; set; }
        bool UpdateWithXML { get; set; }
        bool TotaliSenzaContabilita { get; set; }
        string Utente { get; set; }
        string Gruppo { get; set; }
        long IdUtente { get; set; }
        bool UtilizzaSubVarianteFissaInCongelamento { get; set; }
        object SubVarianteFissaInCongelamento { get; set; }
        bool GeneraCoIndInBatch { get; set; }
        bool GeneraMovProgettiInBatch { get; set; }
        bool ControllaGiacenzeNegative { get; set; }
        bool ControllaBloccoStatiArticolo { get; set; }
        string SezionaleAutofattura { get; set; }
        object DataRiferimentoLetteraIntento { get; set; }
        object GestioneAssociazioneNotaCredito { get; set; }
        bool RecuperaCostoLotti { get; set; }
        bool VuotiModalitaBatch { get; set; }
		bool BloccoMerce_ModalitaBatch { get; set; }
        bool VuotiDisabled { get; set; }
        bool RicalcolaPrezziRigheParametrico { get; set; }
		//CLSCO_DITTABASE ClsDittaCorrente { get; }
        bool GestioneBloccoMerce { get; }
        bool BloccoMerce_Disattiva { get; set; }
		int BloccoMerce_ClBatch_GenerazioneDarif { get; set; }
        int BloccoMerce_BloccoAssegnatoAuto { get; set; }
		bool BloccoMerce_NoTrasfMerce { get; set; }
        bool Simulazione { get; set; }
        bool CambioVarianteCarOdf_OrdCli { get; set; }
        //CLSMG_DOCREGSERVIZI DocRegServizi { get; }
        //CLSMG_DOCREGMAGAZ DocRegMagazzino { get; }
        //CLSMG_DOCREGVERT DocRegVerticali { get; }
    }
}
