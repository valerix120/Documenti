
namespace Documenti.Interop
{
    internal enum EnumCauseBloccoModifica
    {
	    Modificabile = 0,
	    BloccatoDaTrasf = 1,
	    Storicizzato = 2,
	    Aggiornato = 3,
        NonModificabile = 4
    }
    internal enum EnumCustomActionsContext
    {
	    CAUpdateNewDocument = 1,
	    CAUpdateModifiedDocument = 2,
	    CADeleteDocument = 4
    }
    internal enum tsRegDocIntra
    {
	    tsRegDocIntraNo = 0,
	    tsRegDocIntraSi = 1,
	    tsRegDocIntraRSM = 2
    }
    internal enum tsGiacNeg
    {
	    tsGiacNegOk = 0,
	    tsGiacNegRichiedereForzatura = 1,
	    tsGiacNegBloccareDocumento = 2
    }
    internal enum tsBloccoStatiArt
    {
	    tsBloccoStatiArtOk = 0,
	    tsBloccoStatiArtRichiedereSblocco = 1,
	    tsBloccoStatiArtBlocco = 2
    }
    internal enum tsGiacNegBatch
    {
	    tsGiacNegBatchOk = 0,
	    tsGiacNegBatchRichiedereForzatura = 1,
	    tsGiacNegBatchBloccareDocumento = 2
    }
    internal enum tsBloccoStatiArtBatch
    {
	    tsBloccoStatiArtBatchOk = 0,
	    tsBloccoStatiArtBatchRichiedereSblocco = 1,
	    tsBloccoStatiArtBatchBlocco = 2
    }
    internal enum tsDeleteAllDocBatch
    {
	    tsDeleteAllDocBatchOk = 0,
	    tsDeleteAllDocBatchNonEsiste = 1,
	    tsDeleteAllDocBatchNonEliminabile = 2,
	    tsDeleteAllDocBatchDocStoricizzato = 3,
	    tsDeleteAllDocBatchEsisteInCoGe = 4,
	    tsDeleteAllDocBatchEsisteInCoIn = 5,
	    tsDeleteAllDocBatchDiBaCong = 6,
	    tsDeleteAllDocBatchLiqProvv = 7,
	    tsDeleteAllDocBatchErrore = 99
    }
    internal enum tsDeleteDocCorpoBatch
    {
	    tsDeleteDocCorpoBatchOk = 0,
	    tsDeleteDocCorpoBatchNonEsiste = 1,
	    tsDeleteDocCorpoBatchNonModificabile = 2,
	    tsDeleteDocCorpoBatchDocStoricizzato = 3,
	    tsDeleteDocCorpoBatchEsisteInCoGe = 4,
	    tsDeleteDocCorpoBatchEsisteInCoIn = 5,
	    tsDeleteDocCorpoBatchDiBaCong = 6,
	    tsDeleteDocCorpoBatchLiqProvv = 7,
	    tsDeleteDocCorpoBatchErrore = 99
    }
    internal enum tsModQtaConsBatch
    {
	    tsModQtaConsBatchOk = 0,
	    tsModQtaConsBatchNonEsiste = 1,
	    tsModQtaConsBatchErrore = 99
    }
    internal enum tsNonEvadTestataBatch
    {
	    tsNonEvadTestataBatchOk = 0,
	    tsNonEvadTestataBatchNonEsiste = 1,
	    tsNonEvadTestataBatchErrore = 99
    }
    internal enum tsNonEvadCorpoBatch
    {
	    tsNonEvadCorpoBatchOk = 0,
	    tsNonEvadCorpoBatchNonEsiste = 1,
	    tsNonEvadCorpoBatchErrore = 99
    }
    internal enum tsInitModifyAllDocumenti
    {
	    tsInitModifyAllDocumentiOk = 0,
	    tsInitModifyAllDocumentiErrore = 99
    }
    internal enum tsUpdateModifyAllDocumenti
    {
	    tsUpdateModifyAllDocumentiOk = 0,
	    tsUpdateModifyAllDocumentiNonEsiste = 1,
	    tsUpdateModifyAllDocumentiNonModificabile = 2,
	    tsUpdateModifyAllDocumentiDocStoricizzato = 3,
	    tsUpdateModifyAllDocumentiEsisteInCoGe = 4,
	    tsUpdateModifyAllDocumentiEsisteInCoIn = 5,
	    tsUpdateModifyAllDocumentiDiBaCong = 6,
	    tsUpdateModifyAllDocumentiLiqProvv = 7,
	    tsUpdateModifyAllDocumentiErrore = 99
    }
    internal enum tsEnumProgrammaChiamante
    {
	    tsScaricoMaterialeDa_Diba = 0,
	    tsAvanzamentoOridineLav = 1,
	    tsContoLavoroAttivo = 2,
	    tsVersamentoContoLavoro = 3,
	    tsDDTContoLavoro = 4,
	    tsDDTContoLavoroDaLista = 5,
	    tsDDTResoContoLavoroAttivo = 6,
	    tsListaTrasferimento = 7,
	    tsListaPrelievo = 8,
	    tsDDTResoContoLavoro = 9,
	    tsScaricoComponentiKIT = 51,
	    tsScaricoManualeMateriali = 10,
        tsOrdineProduzInterna = 11,
        tsOrdineProduzContoLavoro = 12,
        tsRettificaConsumoMaterialiFasiInterne = 13,
        tsRettificaConsumoMaterialiFasiEsterne = 14
    }

    internal enum tsEnumPlugInStandard
    {
        tsPlugInCostruzioni = 1
    }
}
