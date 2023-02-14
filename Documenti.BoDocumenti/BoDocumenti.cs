
using Documenti.Interop;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using static Documenti.Interop.WrapperUtils;
using static Documenti.BoTrasformazioneDocumenti.BoTrasformazioneDocumenti;

namespace Documenti.BoDocumenti
{
    public class BoDocumenti : IBoDocumenti
    {

        private object numeroregistrazione;
        internal static CLSMG_REGDOC regdoc { get; set; }
        internal static CLSMG_REGDOCIN RegDocIn { get; set; }
        internal static IVB6ComWrapper wrapper { get; set; }
        internal static long Codditta { get; set; }
        internal static string Server { get; set; }
        internal static string Database { get; set; }
        internal static string Utentesql { get; set; }
        internal static string Password { get; set; }
        internal static int ProgMovLotti { get; set; }
        internal static string TipoMovLotti { get; set; }
        internal static object comObject { get; set; }
        internal static string REGDOC_PROGID = "MGBO_REGDOCUMENTI.CLSMG_REGDOC";
        internal static string REGDOC_INSTANCE_KEY = "MGBO_REGDOCUMENTI.CLSMG_REGDOC_Key";

        private AfterCommitTransactionEventHandler _afterCommitTransaction;

        private object GetFieldValue(RecordsetType rsType, string fieldName)
        {
            IField objField = GetFieldFromRecordset(rsType, fieldName);
            if (objField == null)
                return null;
            return objField.Value;
        }

        private IField GetFieldFromRecordset(RecordsetType rsType, string fieldName)
        {
            if (String.IsNullOrEmpty(fieldName))
                throw new ArgumentException("fieldName");
            //CheckInit();

            IRecordset rst = GetRecordset(rsType);
            if (rst == null)
            {
                Console.WriteLine("DocumentoService.GetFieldFromRecordset: recordset is null, ensure CLSMG_REGDOCIN has correct configurations!");
                // Logger.Warn("DocumentoService.GetFieldFromRecordset: recordset is null, ensure CLSMG_REGDOCIN has correct configurations!", rsType, fieldName);
                return null;
            }

            // Logger.Debug("DocumentoService.GetFieldFromRecordset: rsType={0}, fieldName={1}", rsType, fieldName);
            try
            {
                object obj = rst.Fields[fieldName];
                IField objField = WrapperUtils.WrapField(obj);
                Console.WriteLine(fieldName);
                return objField;
            }
            catch (Exception)
            {
                //Logger.Warn("DocumentoService.GetFieldFromRecordset: rsType={0}, fieldName={1} - errore", rsType, fieldName);
                Console.WriteLine("DocumentoService.GetFieldFromRecordset: rsType={0}, fieldName={1} - errore");
                return null;
            }
        }

        internal IRecordset GetRecordset(RecordsetType rsType)
        {
            IRecordset rst;
            switch (rsType)
            {
                case RecordsetType.RstDocTestata:
                    rst = regdoc.rstDocTestata;
                    break;
                case RecordsetType.RstDocCorpo:
                    rst = regdoc.rstDocCorpo;
                    break;
                case RecordsetType.RstDocCorpoLot:
                    rst = regdoc.rstDocCorpoLot;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("rsType");
            }
            return rst;
        }

        private void SetFieldValue(RecordsetType rsType, string fieldName, object value)
        {
            IField objField = GetFieldFromRecordset(rsType, fieldName);
            if (objField == null)
                return;
            if (value == null)
                value = DBNull.Value;
            objField.Value = value;
        }


        //private void CheckInit()
        //{
        //    if (_isInitialized)
        //        return;

        //    const string err = "You have to call Initialize method before!";
        //    //Logger.Error("DocumentoService error: {0}", err);
        //    throw new InvalidOperationException(err);
        //}
        void REGDOC_AfterCommitTransaction(object sender, AfterCommitTransactionEventArgs e)
        {
            numeroregistrazione = GetFieldValue(RecordsetType.RstDocTestata, "DO11_NUMREG_CO99");
        }

        public void Inizializza(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta)
        {
            Codditta = ditta;
            Database = database;
            Utentesql = utentesql;
            Password = password;
            wrapper = COMWrapper.CreateInstance<IVB6ComWrapper>();
            wrapper.Initialize(server, database, utentesql, password, "GammaEnterprise", applicationUser, applicationPwd, Codditta);

            wrapper.CreateCOMObject(REGDOC_PROGID, REGDOC_INSTANCE_KEY);
            wrapper.AssignSessionObject(REGDOC_INSTANCE_KEY, SessionObjectNames.ActiveInterface, "RegDocIn.ActiveInterface");
            wrapper.AssignSessionObject(REGDOC_INSTANCE_KEY, SessionObjectNames.Connection, "RegDocIn.Connection");
            wrapper.AssignSessionProperty(REGDOC_INSTANCE_KEY, SessionPropertyNames.ConnectionString, "RegDocIn.ConnectionString");

            comObject = wrapper.GetCOMObject(REGDOC_INSTANCE_KEY);
            regdoc = COMWrapper.Wrap<CLSMG_REGDOC>(comObject);
            RegDocIn = COMWrapper.Wrap<CLSMG_REGDOCIN>(regdoc.RegDocIn);
            _afterCommitTransaction = REGDOC_AfterCommitTransaction;
            regdoc.AfterCommitTransaction += _afterCommitTransaction;
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

        public void ModificaDoc(string codicedoc, short pers, string numreg)
        {
            regdoc.RegDocIn.Ditta = Codditta;
            regdoc.RegDocIn.GestDocTestata = true;
            regdoc.RegDocIn.GestDocTestaProge = true;
            regdoc.RegDocIn.GestDocCorpo = true;
            regdoc.RegDocIn.GestDocDatiAcc = true;
            regdoc.RegDocIn.GestDocTotali = true;
            regdoc.RegDocIn.Documento = codicedoc.TrimEnd();


            regdoc.Initialize();
            regdoc.ConfiguraRstGestiti(codicedoc.TrimEnd(), pers);
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

        public string UpdateDocTestataNumreg()
        {
            regdoc.RicalcolaTotaliDaRigheCorpo();
            regdoc.UpdateDocTestata();
            return numeroregistrazione.ToString();

        }

        public void CreaDocumento(string coddocum, short pers)
        {
            regdoc.RegDocIn.Ditta = Codditta;
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

        public void AggiungiRigaLotto(string codart, string variante, decimal qta1, decimal qta2, string lotto, string coddep,int proglotto)
        {
            SetProgMovLotti();
            AddAnagLotto(codart, variante,lotto, "");

            regdoc.AddNewDocCorpoLot();

            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_PROG_MG4F", ProgMovLotti);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_PROG", proglotto);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_CODART_MG66", codart);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_OPZIONE_MG5E", variante);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_CODDEP_MG58", coddep);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_CODLOTTO_MG4G", lotto);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA1", qta1);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA2", qta2);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA1CONS", 0);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA2CONS", 0);

            regdoc.UpdateDocCorpoLot();
            regdoc.UpdateDocCorpo();
        }

        public void ModificaRigaLotto(string codart, string variante, decimal qta1, decimal qta2, string lotto, string coddep, int progriga, int proglotto)
        {
            SetProgMovLotti();

            AddAnagLotto(codart, variante, lotto, "");

            IRecordset rstDocCorpoLotti = GetRecordset(RecordsetType.RstDocCorpoLot);
            IRecordset rstDocCorpoLottiClone = rstDocCorpoLotti.Clone();
            rstDocCorpoLottiClone.Filter = String.Format("DO52_PROGRIGA = {0} AND DO52_PROG_MG4F = {1} AND DO52_PROG = {2}", progriga, ProgMovLotti, proglotto);
            rstDocCorpoLotti.Bookmark = rstDocCorpoLottiClone.Bookmark;

            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_CODART_MG66", codart);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_OPZIONE_MG5E", variante);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_CODDEP_MG58", coddep);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_CODLOTTO_MG4G", lotto);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA1", qta1);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA2", qta2);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA1CONS", 0);
            SetFieldValue(RecordsetType.RstDocCorpoLot, "DO52_QTA2CONS", 0);

            regdoc.UpdateDocCorpoLot();
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

        internal bool AddAnagLotto(string codart, string variante, string codlotto, string descrlotto)
        {
            bool res = false;
            DateTime datacre = DateTime.Now;
            string connectionString = "SERVER=" + Server + ";UID=" + Utentesql + "; PWD=" + Password + ";DATABASE=" + Database;

            string commandText = @"SELECT TOP 1 1
                                        FROM  
                                    MG4G_ANAGRLOTTI 
                                    WHERE  
                                    MG4G_DITTA_CG18 = @codditta
                                    AND MG4G_CODART_MG66 = @codiceArticolo
                                    AND MG4G_OPZIONE_MG5E = @variante
                                    AND MG4G_CODLOTTO = @codlotto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@codditta", SqlDbType.Decimal);
                command.Parameters["@codditta"].Value = Codditta;
                command.Parameters.Add("@codiceArticolo", SqlDbType.Char);
                command.Parameters["@codiceArticolo"].Value = codart;
                command.Parameters.Add("@variante", SqlDbType.Char);
                command.Parameters["@variante"].Value = variante;
                command.Parameters.Add("@codlotto", SqlDbType.Char);
                command.Parameters["@codlotto"].Value = codlotto;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return false;
                    }

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                }
                connection.Close();

                string commandText2 = @"INSERT INTO MG4G_ANAGRLOTTI
                (
                MG4G_DITTA_CG18
                ,MG4G_CODART_MG66
                ,MG4G_OPZIONE_MG5E 
                ,MG4G_CODLOTTO 
                ,MG4G_DESCLOTTO 
                ,MG4G_DATACRE 
  
                ,MG4G_GUID 
                ) 
                VALUES ( 
                       @codditta,
                       @codiceArticolo,
                       @variante ,
                       @codlotto,
                       @descrlotto,
                       @datacre ,

                       @guid
                       )";
                using (SqlConnection connection2 = new SqlConnection(connectionString))
                {
                    SqlCommand command2 = new SqlCommand(commandText2, connection2);
                    command2.Parameters.Add("@codditta", SqlDbType.Decimal);
                    command2.Parameters["@codditta"].Value = Codditta;
                    command2.Parameters.Add("@codiceArticolo", SqlDbType.Char);
                    command2.Parameters["@codiceArticolo"].Value = codart;
                    command2.Parameters.Add("@variante", SqlDbType.Char);
                    command2.Parameters["@variante"].Value = variante;
                    command2.Parameters.Add("@codlotto", SqlDbType.Char);
                    command2.Parameters["@codlotto"].Value = codlotto;
                    command2.Parameters.Add("@descrlotto", SqlDbType.Char);
                    command2.Parameters["@descrlotto"].Value = descrlotto;
                    command2.Parameters.Add("@datacre", SqlDbType.DateTime);
                    command2.Parameters["@datacre"].Value = datacre;
                    //command2.Parameters.Add("@datascad", SqlDbType.DateTime);
                    //command2.Parameters["@datascad"].Value = null;
                    command2.Parameters.Add("@guid", SqlDbType.UniqueIdentifier);
                    command2.Parameters["@guid"].Value = Guid.NewGuid();

                    try
                    {
                        connection2.Open();
                        command2.ExecuteNonQuery();
                        res = true;

                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                        res = false;
                    }
                    connection2.Close();
                }
                
                return res;
            }
        }
        internal void SetProgMovLotti()
        {
            string connectionString = "SERVER=" + Server + ";UID=" + Utentesql + "; PWD=" + Password + ";DATABASE=" + Database;

            string commandText = @"SELECT MG4F_PROG , MG4F_TIPOMOV 
                                        FROM  
                                    MG4F_PARAMMOVLOTTI WITH (NOLOCK) 
                                    WHERE  
                                    MG4F_DITTA_CG18 = @codditta
                                    AND MG4F_TIPOMOV LIKE '%LOT%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@codditta", SqlDbType.Decimal);
                command.Parameters["@codditta"].Value = Codditta;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProgMovLotti = int.Parse(reader["MG4F_PROG"].ToString());
                        TipoMovLotti = reader["MG4F_TIPOMOV"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }
    }
}

