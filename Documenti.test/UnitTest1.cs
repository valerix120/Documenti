using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Documenti.test
{
    [TestClass]
    public class UnitTest1
    {
        private const string REGDOC_PROGID = "MGBO_REGDOCUMENTI.CLSMG_REGDOC";
        private const string REGDOC_INSTANCE_KEY = "MGBO_REGDOCUMENTI.CLSMG_REGDOC_Key";

        [TestMethod]
        public void TestCreadocumento()
        {
            BoDocumenti.BoDocumenti boreg = new BoDocumenti.BoDocumenti();
            boreg.Inizializza("VM-COCOZZA", "ARSMEDICA", "sa", "teamsystem", "GammaEnterprise", "admin", "admin", 1);
            boreg.CreaDocumento("CLS-FATIMM2", 1);
            boreg.CambiaClifor(3);
            // boreg.CambiaDocTestaProgeCommessa("1", 0, false);
            boreg.AggiungiRigaArticolo("TENS", "", 110);
            boreg.UpdateDocTestata();
            boreg.Termina();
        }

        [TestMethod]
        public void TestModificadocumento()
        {
            BoDocumenti.BoDocumenti boreg = new BoDocumenti.BoDocumenti();
            boreg.Inizializza("VM-COCOZZA", "ARSMEDICA", "sa", "teamsystem", "GammaEnterprise", "admin", "admin", 1);
            boreg.ModificaDoc("CLS-FATIMM2   ", "202200000017");
            boreg.CambiaDocCorpoPrezzo1(2, 8,false,false);
            boreg.CambiaDocCorpoScPer1(2, 2);
            boreg.CambiaDocCorpoScPer2(2, 3);
            boreg.CambiaDocCorpoScPer3(2, 4);
            boreg.UpdateDocTestata();
            //DataTable dt = new DataTable();
            //dt = boreg.RstDoccorpo();
            //Assert.AreEqual(dt.Rows.Count, 1);
            boreg.Termina();
        }

        [TestMethod]
        public void TestTrasformazione()
        {
            BoDocumenti.BoDocumenti boreg = new BoDocumenti.BoDocumenti();
            boreg.Inizializza("VM-COCOZZA", "ARSMEDICA", "sa", "teamsystem", "GammaEnterprise", "admin", "admin", 1);
            boreg.ModificaDoc("CLS-FATIMM2   ", "202200000017");
            boreg.CambiaDocCorpoPrezzo1(2, 8, false, false);
            boreg.CambiaDocCorpoScPer1(2, 2);
            boreg.CambiaDocCorpoScPer2(2, 3);
            boreg.CambiaDocCorpoScPer3(2, 4);
            boreg.UpdateDocTestata();
            //DataTable dt = new DataTable();
            //dt = boreg.RstDoccorpo();
            //Assert.AreEqual(dt.Rows.Count, 1);
            boreg.Termina();
        }

        //[TestMethod]
        //public void test_demo_bo_doc()
        //{
        //    // VARIABILI LOCALI
        //    const int numeroDocumenti = 1;
        //    const int numeroRighe = 10;
        //    Stopwatch stopWatch = new Stopwatch();
        //    stopWatch.Start();
        //    // INIZIALIZZO L'OGGETTO COM WRAPPER
        //    using (IVB6ComWrapper wrapper = COMWrapper.CreateInstance<IVB6ComWrapper>())
        //    {
        //        Assert.IsNotNull(wrapper);
        //        // ISTANZIO IL MOTORE DOCUMENTALE
        //        wrapper.Initialize("GAMMA", "GAMMANEXT", "sa", "teamsystem", "GammaEnterprise", "TeamSa", "TeamSa", 1);

        //        wrapper.CreateCOMObject(REGDOC_PROGID, REGDOC_INSTANCE_KEY);
        //        wrapper.AssignSessionObject(REGDOC_INSTANCE_KEY, SessionObjectNames.ActiveInterface, "RegDocIn.ActiveInterface");
        //        wrapper.AssignSessionObject(REGDOC_INSTANCE_KEY, SessionObjectNames.Connection, "RegDocIn.Connection");
        //        wrapper.AssignSessionProperty(REGDOC_INSTANCE_KEY, SessionPropertyNames.ConnectionString, "RegDocIn.ConnectionString");

        //        object comObject = wrapper.GetCOMObject(REGDOC_INSTANCE_KEY);
        //        CLSMG_REGDOC regdoc = COMWrapper.Wrap<CLSMG_REGDOC>(comObject);

        //        Console.WriteLine("Wrapper inizializzato in {0}", stopWatch.Elapsed);
        //        stopWatch.Restart();
        //        // INIZIALIZZA
        //        using (CLSMG_REGDOCIN regdocin = COMWrapper.Wrap<CLSMG_REGDOCIN>(regdoc.RegDocIn))
        //        {
        //            regdocin.Ditta = 1;
        //            regdocin.Documento = "CLI-DDT";
        //            regdocin.Avanzamento = true;
        //            regdocin.GestDocTestata = true;
        //            regdocin.GestDocTestaRif = true;
        //            regdocin.GestDocTotali = true;
        //            regdocin.GestDocDatiAcc = true;
        //            regdocin.GestDocCorpo = true;
        //            regdocin.GestDocCorpoOrd = true;
        //            regdocin.Transaction = true;
        //            // parametri per non far uscire le message box
        //            regdocin.VuotiModalitaBatch = true;
        //            regdocin.GestioneAssociazioneNotaCredito = true;
        //            regdocin.BatchMode = false;

        //        }
        //        regdoc.Initialize();
        //        Console.WriteLine("RegDoc inizializzato in {0}", stopWatch.Elapsed);
        //        BeforeBeginTransactionEventHandler beforeBeginTransaction = REGDOC_BeforeBeginTransaction;
        //        AfterBeginTransactionEventHandler afterBeginTransaction = REGDOC_AfterBeginTransaction;
        //        BeforeCommitTransactionEventHandler beforeCommitTransaction = REGDOC_BeforeCommitTransaction;
        //        AfterCommitTransactionEventHandler afterCommitTransaction = REGDOC_AfterCommitTransaction;
        //        AvanzamentoEventHandler avanzamento = REGDOC_Avanzamento;
        //        ErrorsOccurredEventHandler errors = REGDOC_ErrorsOccurred;
        //        WarningOccurredEventHandler warnings = REGDOC_WarningOccurred;

        //        regdoc.BeforeBeginTransaction += beforeBeginTransaction;
        //        regdoc.AfterBeginTransaction += afterBeginTransaction;
        //        regdoc.BeforeCommitTransaction += beforeCommitTransaction;
        //        regdoc.AfterCommitTransaction += afterCommitTransaction;
        //        regdoc.Avanzamento += avanzamento;
        //        regdoc.ErrorsOccurred += errors;
        //        regdoc.WarningOccurred += warnings;

        //        for (int indexTestata = 1; indexTestata <= numeroDocumenti; indexTestata++)
        //        {
        //            Console.WriteLine("{0} - INIZIO SCRITTURA DOCUMENTI NR. {1}", DateTime.Now, indexTestata);

        //            // APRO TUTTI I RECORDSET VUOTI
        //            regdoc.OpenAllEmptyRecordsets();

        //            // AGGIUNGO LA TESTATA CON TUTTI I DATI
        //            regdoc.AddNewDocTestata(false, false, true);
        //            regdoc.AddNewDocTestaRif();
        //            regdoc.AddNewDocTotali();
        //            regdoc.AddNewDocDatiAcc();
        //            regdoc.CambiaDocTestataDataDoc(DateTime.Now.Date);
        //            regdoc.CambiaDocTestataCliFor(1);

        //            // CICLO PER AGGIUNGERE 10 RIGHE DI CORPO
        //            for (int indexRighe = 1; indexRighe <= numeroRighe; indexRighe++)
        //            {
        //                regdoc.AddNewDocCorpo();
        //                regdoc.CambiaDocCorpoCodart("A1", "", true, false, false);
        //                regdoc.CambiaDocCorpoQta1(indexRighe);
        //                regdoc.UpdateDocCorpo(false, true, false, false, true, true, false);
        //            }

        //            // CALCOLO I TOTALI DEL DOCUMENTO
        //            //regdoc.RicalcolaTotaliDaRigheCorpo(true, true, true, true, false, false);
        //            regdoc.UpdateDocTestata();

        //            Console.WriteLine("{0} - FINE SCRITTURA DOCUMENTI NR. {1}", DateTime.Now, indexTestata);
        //        }

        //        regdoc.BeforeBeginTransaction -= beforeBeginTransaction;
        //        regdoc.AfterBeginTransaction -= afterBeginTransaction;
        //        regdoc.BeforeCommitTransaction -= beforeCommitTransaction;
        //        regdoc.AfterCommitTransaction -= afterCommitTransaction;
        //        regdoc.Avanzamento -= avanzamento;
        //        regdoc.ErrorsOccurred -= errors;
        //        regdoc.WarningOccurred -= warnings;

        //        wrapper.SetNothingInCOMObject(REGDOC_INSTANCE_KEY, "RegDocIn.ActiveInterface");
        //        wrapper.SetNothingInCOMObject(REGDOC_INSTANCE_KEY, "RegDocIn.Connection");
        //        wrapper.SetNothingInCOMObject(REGDOC_INSTANCE_KEY, "RegDocIn");

        //        regdoc.Terminate();

        //        regdoc.Dispose();
        //        regdoc = null;
        //        comObject = null;

        //        wrapper.ReleaseCOMObject(REGDOC_INSTANCE_KEY);
        //        wrapper.Terminate();
        //    }
        //}

        //#region EVENTS

        //private static void REGDOC_BeforeBeginTransaction(object sender, BeforeBeginTransactionEventArgs e)
        //{
        //    Console.WriteLine("Event BeforeBeginTransaction");
        //}

        //private static void REGDOC_AfterBeginTransaction(object sender, AfterBeginTransactionEventArgs e)
        //{
        //    Console.WriteLine("Event AfterBeginTransaction");
        //}

        //private static void REGDOC_BeforeCommitTransaction(object sender, BeforeCommitTransactionEventArgs e)
        //{
        //    Console.WriteLine("Event BeforeCommitTransaction");
        //}

        //private static void REGDOC_AfterCommitTransaction(object sender, AfterCommitTransactionEventArgs e)
        //{
        //    Console.WriteLine("Event AfterCommitTransaction");
        //}

        //private static void REGDOC_Avanzamento(object sender, AvanzamentoEventArgs e)
        //{
        //    Console.WriteLine("Event Avanzamento: {0} {1} {2}", e.Step, e.TotalSteps, e.Description);
        //}

        //private static void REGDOC_ErrorsOccurred(object sender, ErrorsOccurredEventArgs e)
        //{
        //    Console.WriteLine("Event Errors Occurred: {0}", e.ErrorDetail);
        //}

        //private static void REGDOC_WarningOccurred(object sender, WarningOccurredEventArgs e)
        //{
        //    Console.WriteLine("Event Warning Occurred: {0}", e.WarningDetail);
        //}


        //#endregion
    }
}
