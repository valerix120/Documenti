using Documenti.Interop;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace Documenti.BoDocumenti
{
    public class BoDocumenti : IBoDocumenti
    {
        internal static CLSMG_REGDOC regdoc { get; set; }
        internal static CLSMG_REGDOCIN RegDocIn { get; set; }
        internal static IVB6ComWrapper wrapper { get; set; }
        internal static long codditta { get; set; }
        internal static object comObject { get; set; }
        internal static string REGDOC_PROGID = "MGBO_REGDOCUMENTI.CLSMG_REGDOC";
        internal static string REGDOC_INSTANCE_KEY = "MGBO_REGDOCUMENTI.CLSMG_REGDOC_Key";

        public void Inizializza(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta)
        {
            codditta = ditta;
            wrapper = COMWrapper.CreateInstance<IVB6ComWrapper>();
            wrapper.Initialize(server, database, utentesql, password, "GammaEnterprise", applicationUser, applicationPwd, codditta);

            wrapper.CreateCOMObject(REGDOC_PROGID, REGDOC_INSTANCE_KEY);
            wrapper.AssignSessionObject(REGDOC_INSTANCE_KEY, SessionObjectNames.ActiveInterface, "RegDocIn.ActiveInterface");
            wrapper.AssignSessionObject(REGDOC_INSTANCE_KEY, SessionObjectNames.Connection, "RegDocIn.Connection");
            wrapper.AssignSessionProperty(REGDOC_INSTANCE_KEY, SessionPropertyNames.ConnectionString, "RegDocIn.ConnectionString");

            comObject = wrapper.GetCOMObject(REGDOC_INSTANCE_KEY);
            regdoc = COMWrapper.Wrap<CLSMG_REGDOC>(comObject);
            RegDocIn = COMWrapper.Wrap<CLSMG_REGDOCIN>(regdoc.RegDocIn);
        }

        public void Inizialize()
        {
            regdoc.Initialize();
        }

        public void Termina()
        {
            regdoc.Termina();

            regdoc.Dispose();
            regdoc = null;
            comObject = null;

            wrapper.ReleaseCOMObject(REGDOC_INSTANCE_KEY);
            wrapper.Terminate();
        }

        public void ModificaDoc(string codicedoc, string numreg)
        {
            regdoc.RegDocIn.Ditta = codditta;
            regdoc.RegDocIn.GestDocTestata = true;
            regdoc.RegDocIn.GestDocTestaProge = true;
            regdoc.RegDocIn.GestDocCorpo = true;
            regdoc.RegDocIn.GestDocDatiAcc = true;
            regdoc.RegDocIn.GestDocTotali = true;
            regdoc.RegDocIn.Documento = codicedoc.TrimEnd();


            regdoc.Initialize();

            regdoc.OpenDocTestata("1=0");
            regdoc.OpenDocTestaProge("1=0");
            regdoc.OpenDocCorpo("1=0");
            regdoc.OpenDocDatiAcc("1=0");
            regdoc.OpenDocTotali("1=0");

            regdoc.OpenDocTestata("DO11_NUMREG_CO99 = '" + numreg + "'");
            regdoc.ModifyDocTestata(numreg);

        }

        public void UpdateDocTestata()
        {
            regdoc.RicalcolaTotaliDaRigheCorpo();
            regdoc.UpdateDocTestata();

        }

        public void CreaDocumento(string coddocum, short pers)
        {
            regdoc.RegDocIn.Ditta = codditta;
            regdoc.RegDocIn.Documento = coddocum.TrimEnd();
            regdoc.RegDocIn.GestDocTestata = true;
            regdoc.RegDocIn.GestDocTestaRif = true;
            regdoc.RegDocIn.GestDocTotali = true;
            regdoc.RegDocIn.GestDocDatiAcc = true;
            regdoc.RegDocIn.GestDocCorpo = true;
            regdoc.RegDocIn.GestDocCorpoOrd = true;
            regdoc.Initialize();
            regdoc.ConfiguraRstGestiti(coddocum.TrimEnd(), pers);
            
            regdoc.OpenAllEmptyRecordsets();
            regdoc.AddNewDocTestata(false,false,true);
            regdoc.AddNewDocTestaRif();
            regdoc.AddNewDocTotali();
            regdoc.AddNewDocDatiAcc();
        }

        public void CambiaDocTestataCodDep(string coddep)
        {
            regdoc.CambiaDocTestataCodDep(coddep);
        }

        public void CambiaDocTestaProgeCommessa(object codcommessa, object codsottocomessa, bool modificasurighecorpo)
        {
           if (regdoc.RegDocIn.GestDocTestaProge)
            {
                regdoc.CambiaDocTestaProgeCommessa(codcommessa, codsottocomessa, modificasurighecorpo);
            }       
        }

        public void CambiaDocTestataSezDoc(string sezionaleDocumento, bool suggerisciNuovoNumero = true, string sezionaleDocumentoPrecedente = "", bool ripristinaVecchioNumero = true, bool rideterminaContropartita = true)
        {
            regdoc.CambiaDocTestataSezDoc(sezionaleDocumento, suggerisciNuovoNumero, sezionaleDocumentoPrecedente, ripristinaVecchioNumero, rideterminaContropartita);
        }

        public void CambiaDocTestataCodPag(object codicePagamento, bool rideterminaContropartita = true)
        {
            regdoc.CambiaDocTestataCodPag(codicePagamento, rideterminaContropartita);
        }
        public bool GestDocCorpoProge()
        {
            return regdoc.RegDocIn.GestDocCorpoProge;
        }

        public void CambiaDocTestataCodDep(string coddep, string coddepcoll)
        {
            regdoc.CambiaDocTestataCodDep(coddep);
            regdoc.CambiaDocTestataCodDepCol(coddepcoll);
        }

        public void CambiaClifor(Int32 clifor)
        {
            regdoc.CambiaDocTestataCliFor(clifor);
        }

        public void CambiaClifor(Int32 clifor, Int32 coddest)
        {
            regdoc.CambiaDocTestataCliFor(clifor);
            regdoc.CambiaDocTestataCliForDest(coddest);
        }

        public void CambiaDocTestataDataReg(DateTime datareg)
        {
            regdoc.CambiaDocTestataDataReg(datareg);
        }

        public void CambiaDocTestataDataDoc(DateTime datadoc)
        {
            regdoc.CambiaDocTestataDataDoc(datadoc);
        }
        public void AggiungiRigaArticolo(string codart, string variante, decimal qta1)
        {
            regdoc.AddNewDocCorpo();
            regdoc.CambiaDocCorpoCodart(codart, variante);
            regdoc.CambiaDocCorpoQta1(qta1, true, true);
            regdoc.UpdateDocCorpo();
        }

        public void AggiungiRigaDescrittiva(string descrizione, string descrizioneest)
        {
            regdoc.AddNewDocCorpo(false, 0, 0, false);
            regdoc.CambiaDocCorpoIndTipoRiga(2);
            regdoc.CambiaDocCorpoDescrizioniArticolo(descrizione, descrizioneest);
        }

        public void CambiaQta1(Int32 progriga, decimal qta1)
        {
            regdoc.ModifyDocCorpo(progriga);
            regdoc.CambiaDocCorpoQta1(qta1, true, true);
            regdoc.UpdateDocCorpo();
        }

        public void CambiaCodart(Int32 progriga, string codart, string variante)
        {
            regdoc.ModifyDocCorpo(progriga);
            regdoc.CambiaDocCorpoCodart(codart, variante, true);
            regdoc.RicalcolaImportoRiga();
            regdoc.UpdateDocCorpo();
        }

        public void CambiaDescrizioneRiga(Int32 progriga, string descrizione, string descrizioneest)
        {
            regdoc.ModifyDocCorpo(progriga);
            regdoc.CambiaDocCorpoDescrizioniArticolo(descrizione, descrizioneest);
            regdoc.UpdateDocCorpo();
        }

        public void CambiaDocCorpoPrezzo1(Int32 progriga, object num, bool flagRicalcolaPrezzo2, bool flagRicalcolaPrezzoCF)
        {
            regdoc.ModifyDocCorpo(progriga);
            regdoc.CambiaDocCorpoPrezzo1(num, flagRicalcolaPrezzo2, flagRicalcolaPrezzoCF);
            regdoc.UpdateDocCorpo();
        }

        public void CambiaDocCorpoScPer1(Int32 progriga, object num)
        {
            regdoc.ModifyDocCorpo(progriga);
            regdoc.CambiaDocCorpoScPer1(num);
            regdoc.UpdateDocCorpo();
        }

        public void CambiaDocCorpoScPer2(Int32 progriga, object num)
        {
            regdoc.ModifyDocCorpo(progriga);
            regdoc.CambiaDocCorpoScPer2(num);
            regdoc.UpdateDocCorpo();
        }

        public void CambiaDocCorpoScPer3(Int32 progriga, object num)
        {
            regdoc.ModifyDocCorpo(progriga);
            regdoc.CambiaDocCorpoScPer3(num);
            regdoc.UpdateDocCorpo();
        }

        public void UpdateDocCorpo()
        {
            regdoc.UpdateDocCorpo();
        }

        public void DeleteDocCorpo()
        {
            regdoc.DeleteDocCorpo();
        }

        public DataTable RstDoccorpo()
        {

            DataTable corpo = new DataTable("corpo");

            regdoc.rstDocCorpo.MoveFirst();
            if (regdoc.rstDocCorpo.EOF != true)
            {
                for (int i = 0; i < regdoc.rstDocCorpo.Fields.Count; i++)
                {
                    object obj = regdoc.rstDocCorpo.Fields[i];
                    IField objField = WrapperUtils.WrapField(obj);
                    corpo.Columns.Add(objField.Name);
                }
            }


            regdoc.rstDocCorpo.MoveFirst();
            while (regdoc.rstDocCorpo.EOF != true)
            {
                object[] array1 = new object[regdoc.rstDocCorpo.Fields.Count];
                for (int i = 0; i < regdoc.rstDocCorpo.Fields.Count; i++)
                {
                    object obj = regdoc.rstDocCorpo.Fields[i];
                    IField objField = WrapperUtils.WrapField(obj);
                    array1[i] = objField.Value;
                }

                corpo.Rows.Add(array1);
                regdoc.rstDocCorpo.MoveNext();
            }

            return corpo;
        }
    }
}

