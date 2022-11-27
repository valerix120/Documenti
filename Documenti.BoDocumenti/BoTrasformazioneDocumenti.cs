using Documenti.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Documenti.BoDocumenti;
using static Documenti.Interop.WrapperUtils;
using System.Collections;
using System.Linq;

namespace Documenti.BoTrasformazioneDocumenti
{
    public class BoTrasformazioneDocumenti : IBoTrasformazioneDocumenti
    {
        internal static CLSMG_REGTRASFDOCIN RegTrasfDocIn { get; set; }
        internal static CLSMG_REGTRASFDOCPARAM RegTrasfDocParam { get; set; }
        internal static CLSMG_REGTRASFDOC trasfdoc { get; set; }
        internal static IVB6ComWrapper wrapper { get; set; }
        internal static long codditta { get; set; }
        internal static string Server { get; set; }
        internal static string Database { get; set; }
        internal static string Utentesql { get; set; }
        internal static string Password { get; set; }
        internal static object comObject { get; set; }
        internal static string SqlConnectionString { get; set; }
        internal static string TRASFDOC_PROGID = "MGBO_TRASFDOC.CLSMG_REGTRASFDOC";
        internal static string TRASFDOC_INSTANCE_KEY = "MGBO_TRASFDOC.CLSMG_REGTRASFDOC_Key";

        public void Inizializza(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta)
        {
            codditta = ditta;
            wrapper = COMWrapper.CreateInstance<IVB6ComWrapper>();
            wrapper.Initialize(server, database, utentesql, password, "GammaEnterprise", applicationUser, applicationPwd, codditta);

            wrapper.CreateCOMObject(TRASFDOC_PROGID, TRASFDOC_INSTANCE_KEY);
            wrapper.AssignSessionObject(TRASFDOC_INSTANCE_KEY, SessionObjectNames.ActiveInterface, "RegTrasfDocIn.ActiveInterface");
            wrapper.AssignSessionObject(TRASFDOC_INSTANCE_KEY, SessionObjectNames.Connection, "RegTrasfDocIn.Connection");
            wrapper.AssignSessionProperty(TRASFDOC_INSTANCE_KEY, SessionPropertyNames.ConnectionString, "RegTrasfDocIn.ConnectionString");

            comObject = wrapper.GetCOMObject(TRASFDOC_INSTANCE_KEY);
            trasfdoc = COMWrapper.Wrap<CLSMG_REGTRASFDOC>(comObject);
            RegTrasfDocIn = COMWrapper.Wrap<CLSMG_REGTRASFDOCIN>(trasfdoc.RegTrasfDocIn);
            RegTrasfDocParam = COMWrapper.Wrap<CLSMG_REGTRASFDOCPARAM>(trasfdoc.RegTrasfDocParam);
        }

        public void Inizialize()
        {
            trasfdoc.Initialize();
        }

        public void Termina()
        {
            trasfdoc.Terminate();

            trasfdoc.Dispose();
            trasfdoc = null;
            comObject = null;

            wrapper.ReleaseCOMObject(TRASFDOC_INSTANCE_KEY);
            wrapper.Terminate();
        }

        public void OpenRecordsets(string FiltroTestata = "",
                                   string FiltroTestaRif = "",
                                   string FiltroTesAgenti = "",
                                   string FiltroPianiDiCarico = "",
                                   string FiltroCorpo = "",
                                   string FiltroArticoli = "",
                                   string OrdinamentoTestata = "",
                                   string OrdinamentoCorpo = "",
                                   string FiltroDataConsegna = "",
                                   string FiltroDO17 = "",
                                   string FiltroDO20 = "",
                                   string FiltroDO35 = "",
                                   string FiltroDO36 = "")
        {

        }

        public void TrasformazioneDocumento(string modellotrasf, string numreg, List<DatiCorpo> daticorpo, List<DatiCorpoLot> datilotti)
        {
            trasfdoc.RegTrasfDocIn.Avanzamento = false;
            trasfdoc.RegTrasfDocIn.Ditta = codditta;
            trasfdoc.RegTrasfDocIn.Modalita = tsTrasfDocModalita.tsTrasfDocModalitaEvasioneMultiplaTrasformazione;
            trasfdoc.RegTrasfDocIn.ModelloTrasformazione = modellotrasf;
            trasfdoc.RegTrasfDocIn.GestDocCorpoGrid = false;
            trasfdoc.Initialize();


            trasfdoc.RegTrasfDocIn.GestDocTestata = true;
            trasfdoc.RegTrasfDocIn.GestDocTestaRif = true;
            trasfdoc.RegTrasfDocIn.GestDocTestaPers = false;
            trasfdoc.RegTrasfDocIn.GestDocTestaEst = false;
            trasfdoc.RegTrasfDocIn.GestDocTesAgenti = (trasfdoc.RegTrasfDocParam.INDCLIFORORIG != tsTrasfDocIndCliFor.tsTrasfDocIndCliForNessuno || trasfdoc.RegTrasfDocParam.INDCLIFORDEST != tsTrasfDocIndCliFor.tsTrasfDocIndCliForNessuno);
            trasfdoc.RegTrasfDocIn.GestDocCorpo = true;
            trasfdoc.RegTrasfDocIn.GestDocCorpoProv = (trasfdoc.RegTrasfDocParam.INDCLIFORORIG != tsTrasfDocIndCliFor.tsTrasfDocIndCliForNessuno || trasfdoc.RegTrasfDocParam.INDCLIFORDEST != tsTrasfDocIndCliFor.tsTrasfDocIndCliForNessuno);
            trasfdoc.RegTrasfDocIn.GestDocCorpoPers = false;
            trasfdoc.RegTrasfDocIn.GestDocCorpoEst = false;
            trasfdoc.RegTrasfDocIn.GestDocCorpoConf = false;
            trasfdoc.RegTrasfDocIn.GestDocCorOrdDet = false;
            trasfdoc.RegTrasfDocIn.GestDocCorpoLot = true;
            trasfdoc.RegTrasfDocIn.GestDocCorpoConai = false;
            trasfdoc.RegTrasfDocIn.GestDocCorpoPDC = false;

            string pstrFiltroTestata = "DO11_NUMREG_CO99 = '" + numreg.TrimEnd() + "'";

            trasfdoc.DisabilitaAperturaMascheraLotti = true;
            trasfdoc.RegTrasfDocParam.INDTIPOELAB = tsTrasfDocIndTipoElab.tsTrasfDocIndTipoElabTrasformazioneAutomatica;
            trasfdoc.OpenRecordsets(pstrFiltroTestata, "", "", "", "", "", "", "", "");

            IRecordset rstTestata = GetRecordset(RecordsetType.RstDocTestata);
            IRecordset rstCorpo = GetRecordset(RecordsetType.RstDocCorpo);
            IRecordset rstLotti = GetRecordset(RecordsetType.RstDocCorpoLot);

            rstTestata.MoveFirst(); // rstTestata.MoveFirst();
            while (!rstTestata.EOF)
            {
                trasfdoc.DocRegMagazzino.MovimentazioneLotti_Ext.Parametri.ModalitaPresidiata = false;
                trasfdoc.RegTrasfDocIn.DisabilitaMessaggi = true;

                Console.WriteLine("etro nel rst testata" + rstTestata.RecordCount.ToString() );
                if (daticorpo != null && daticorpo.Count > 0)
                {

                    rstCorpo.Filter = "DO30_NUMREG_CO99 = '" + numreg +"'";
                    rstCorpo.MoveFirst();
                    Console.WriteLine("etro nel dati corpo" + rstCorpo.RecordCount.ToString());
                    while (!rstCorpo.EOF)
                    {
                        Console.WriteLine("scorro i dati corpo");
                        int progriga = int.Parse(GetFieldValue(RecordsetType.RstDocCorpo, "DO30_PROGRIGA").ToString());
                        List<DatiCorpo> dtfiltrati = daticorpo.Where(x => x.ProgRiga == progriga).ToList();
                        if (dtfiltrati.Count != 0)
                        {
                            Console.WriteLine("filtro prog riga");
                            foreach (var item in dtfiltrati)
                            {
                                Console.WriteLine("aggiorno le qta");
                                trasfdoc.CambiaDocCorpoQta1(item.Qta1, false,false);
                                trasfdoc.CambiaDocCorpoQta2(item.Qta2, false,false);

                                rstCorpo.UpdateBatch();
                            }
                        }
                        rstCorpo.MoveNext();
                    }
                }
                rstTestata.MoveNext();
            }

            Console.WriteLine("genero i doc");
            trasfdoc.GeneraTuttiDocumenti();

        }


        private IRecordset GetRecordset(RecordsetType rsType)
        {
            IRecordset rst;
            switch (rsType)
            {
                case RecordsetType.RstDocTestata:
                    rst = trasfdoc.rstDocTestata;
                    break;
                case RecordsetType.RstDocCorpo:
                    rst = trasfdoc.rstDocCorpo;
                    break;
                case RecordsetType.RstDocCorpoLot:
                    rst = trasfdoc.rstDocCorpoLot;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("rsType");
            }
            return rst;
        }

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
                // Logger.Warn("DocumentoService.GetFieldFromRecordset: recordset is null, ensure CLSMG_REGDOCIN has correct configurations!", rsType, fieldName);
                return null;
            }

            // Logger.Debug("DocumentoService.GetFieldFromRecordset: rsType={0}, fieldName={1}", rsType, fieldName);
            try
            {
                object obj = rst.Fields[fieldName];
                IField objField = WrapperUtils.WrapField(obj);
                return objField;
            }
            catch (Exception)
            {
                //Logger.Warn("DocumentoService.GetFieldFromRecordset: rsType={0}, fieldName={1} - errore", rsType, fieldName);
                return null;
            }
        }

        private bool AddAnagLotto(string codart, string variante, string codlotto, string descrlotto, DateTime datacre, DateTime datascad)
        {
            bool res = false;
            string connectionString = "SERVER=" + Server + ";UID=" + Utentesql + "; PWD=" + Password + ";DATABASE=" + Database;
           
            string commandText = @"INSERT INTO MG4G_ANAGRLOTTI
                (
                MG4G_DITTA_CG18
                ,MG4G_CODART_MG66
                ,MG4G_OPZIONE_MG5E 
                ,MG4G_CODLOTTO 
                ,MG4G_DESCLOTTO 
                ,MG4G_DATACRE 
                ,MG4G_DATASCAD
                ,MG4G_GUID 
                ) 
                VALUES ( 
                       @codditta,
                       @codiceArticolo,
                       @variante ,
                       @codlotto,
                       @descrlotto,
                       @datacre ,
                       @datascad,
                       @guid
                       )";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@codditta", SqlDbType.Decimal);
                command.Parameters["@codditta"].Value = codditta;
                command.Parameters.Add("@codiceArticolo", SqlDbType.Char);
                command.Parameters["@codiceArticolo"].Value = codart;
                command.Parameters.Add("@variante", SqlDbType.Char);
                command.Parameters["@variante"].Value = variante;
                command.Parameters.Add("@codlotto", SqlDbType.Char);
                command.Parameters["@codlotto"].Value = codlotto;
                command.Parameters.Add("@descrlotto", SqlDbType.Char);
                command.Parameters["@descrlotto"].Value = descrlotto;
                command.Parameters.Add("@datacre", SqlDbType.DateTime);
                command.Parameters["@datacre"].Value = datacre;
                command.Parameters.Add("@datascad", SqlDbType.DateTime);
                command.Parameters["@datascad"].Value = datascad;
                command.Parameters.Add("@guid", SqlDbType.Char);
                command.Parameters["@guid"].Value = Guid.NewGuid();

                try
                {
                    connection.Open();
                    res = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                }
            }
            return res;
        }

    }

}