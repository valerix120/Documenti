
namespace Documenti.Interop
{
    internal enum tsEnumTipoTempo
    {
        tsOre = 0,
        tsMinuti = 1,
        tsSecondi = 2
    }

    internal enum tsEnumTipoOrario
    {
        tsOrdinario = 0,
        tsStraordinario = 1,
        tsOrdinarioFestivo = 2,
        tsStraordinarioFestivo = 3,
    }

    internal enum tsEnumTipoOra
    {
        tsLavorazione = 0,
        tsSetup = 1,
        tsManutenzione = 2
    }

    internal enum tsEnumTipoLavorazione
    {
        tsInterna = 0,
        tsEsterna = 1
    }

    internal enum tsEnumAvanzamentoProduzioneStatoErrore
    {
        tsAvanzamentoProduzioneOK = 0,
        tsAvanzamentoProduzioneDitta = 1,
        tsAvanzamentoProduzioneConnection = 2,
        tsAvanzamentoProduzioneUtente = 3,
        tsAvanzamentoProduzioneInitialize = 4,
        tsAvanzamentoProduzioneAssenzaDati = 5,
        tsAvanzamentoProduzioneTempi = 6,
        tsAvanzamentoProduzioneTempiAssenzaDati = 7,
        tsAvanzamentoDistintaBaseStandardAssente = 8,
        tsAvanzamentoProduzioneDepositoPianificazione = 9,
        tsAvanzamentoProduzioneCommessaErrata = 10,
        tsAvanzamentoProduzioneDescrizioneArticolo = 11,
        tsAvanzamentoProduzioneLocalizzazioneDistinta = 12,
        tsAvanzamentoProduzioneGeneraProposta = 13,
        tsAvanzamentoProduzioneConfermaProposta = 14,
        tsAvanzamentoProduzioneGeneraPropostaAcq = 15,
        tsAvanzamentoProduzioneFornitorePref = 16,
        tsAvanzamentoProduzioneNessunDocumentoTrovato = 98,
        tsAvanzamentoProduzioneGenerale = 99,
    }

    internal enum tsEnumTipoAvanzamentoProduzione
    {
        tsAvanzamentoProduzioneQuantita = 0,
        tsAvanzamentoProduzioneTempi = 1,
    }

    internal enum tsEnumTipologiaOrdiniProduzione
    {
        tsOrdiniProduzioneMultiLivello = 0,
        tsOrdiniProduzioneMonoLivello = 1
    }
}


