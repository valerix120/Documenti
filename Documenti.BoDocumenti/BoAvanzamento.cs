using Documenti.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Documenti.BoAvanzamento
{
    public class OdlDaAvanzare
    {
        public string Numreg { get; set; }
        public decimal ProgRiga { get; set; }
        public string CodFase { get; set; }
    }

    public class BoAvanzamento : IBoAvanzamento
    {
        internal static CLSPD_AVANZPROD avanzprod { get; set; }
        internal static IVB6ComWrapper wrapper { get; set; }
        internal static long Codditta { get; set; }
        internal static string Server { get; set; }
        internal static string Database { get; set; }
        internal static string Utentesql { get; set; }
        internal static string Password { get; set; }
        internal static object ComObject { get; set; }
        internal static string SqlConnectionString { get; set; }
        internal static string AVANZPROD_PROGID = "PDBO_AVANZPROD.CLSPD_AVANZPROD";
        internal static string AVANZPROD_INSTANCE_KEY = "PDBO_AVANZPROD.CLSPD_AVANZPROD_Key";

        public void Inizializza(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta)
        {
            try
            {
                Codditta = ditta;
                Server = server;
                Database = database;
                Utentesql = utentesql;
                Password = password;
                SqlConnectionString = "SERVER=" + server + ";UID=" + utentesql + "; PWD=" + password + ";DATABASE=" + database;

                wrapper = COMWrapper.CreateInstance<IVB6ComWrapper>();
                wrapper.Initialize(server, database, utentesql, password, "GammaEnterprise", applicationUser, applicationPwd, Codditta);
                wrapper.CreateCOMObject(AVANZPROD_PROGID, AVANZPROD_INSTANCE_KEY);

                ComObject = wrapper.GetCOMObject(AVANZPROD_INSTANCE_KEY);
                avanzprod = COMWrapper.Wrap<CLSPD_AVANZPROD>(ComObject);

                avanzprod.TipoAvanzamentoOrdiniProduzione = tsEnumTipoAvanzamentoProduzione.tsAvanzamentoProduzioneQuantita;
                avanzprod.TipologiaOrdiniProduzione = tsEnumTipologiaOrdiniProduzione.tsOrdiniProduzioneMonoLivello;

                Inizialize(server, database, utentesql, password, applicationName, applicationUser, applicationPwd, ditta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


        private void Inizialize(string server, string database, string utentesql, string password, string applicationName, string applicationUser, string applicationPwd, long ditta)
        {
            avanzprod.ConnectionString = "Provider=SQLOLEDB;SERVER=" + server + ";UID=sa;PWD=" + password + ";DATABASE=" + database;
            avanzprod.CodiceDitta = ditta;
            avanzprod.NomeUtenteSQL = utentesql;
            avanzprod.PwdUtenteSQL = password;
            avanzprod.CodiceUtente = applicationUser;
            avanzprod.Password = applicationPwd;
            avanzprod.ServerName = server;
            avanzprod.DatabaseName = database;
            avanzprod.ModalitaPresidiata = false;
            avanzprod.Initialize();
        }

        public long AvanzamentoODLMonolivello(DateTime dataRegistrazione, string depositoAvanzamento, string codiceArticolo, decimal quantitaAvanzamento, bool saldoAvanzamento, string variante = "", string depositoScarto = "", decimal quantitaScarto = 0, decimal quantita2Avanzamento = 0, decimal quantita2Scarto = 0)
        {
            bool datemag = ControllaDateMagazzino(SqlConnectionString, dataRegistrazione);
            if (!datemag)
            {
                avanzprod.Terminate();
                return 99;
            }
            List<OdlDaAvanzare> odls = CercaPrimoODLApertoPerArticolo(Server, Database, Utentesql, Password, codiceArticolo, variante);

            if (odls.Count > 0)
            {
                foreach (var odl in odls)
                {

                    if (!String.IsNullOrEmpty(odl.Numreg.ToString()))
                    {
                        long stato = PreparaAvanzamentoOrdini(odl.Numreg, odl.Numreg, dataRegistrazione);
                        if (stato > 0)
                        {
                            avanzprod.Terminate();
                            return stato;
                        }
                        stato = AvanzaSingolaFaseLavorazione(odl.Numreg, odl.ProgRiga, odl.CodFase, quantitaAvanzamento, depositoAvanzamento, saldoAvanzamento, depositoScarto, quantitaScarto, quantita2Avanzamento, quantita2Scarto);
                        if (stato > 0)
                        {
                            avanzprod.Terminate();
                            return stato;
                        }
                        stato = ConfermaAvanzamentoFasiLavorazione();
                        if (stato > 0)
                        {
                            avanzprod.Terminate();
                            return stato;
                        }
                    }
                }
                return GetStato();
            } else
            {
                return 98;
            }

        }

        public long GetStato()
        {
            if (avanzprod == null)
                return -1;

            return Convert.ToInt64(avanzprod.Stato);
        }

        public long PreparaAvanzamentoOrdini(object NumeroRegistrazioneIniziale, object NumeroRegistrazionFinale, DateTime datareg)
        {

            avanzprod.DataRegistrazione = datareg;
            avanzprod.PreparaAvanzamentoOrdini(NumeroRegistrazioneIniziale, NumeroRegistrazionFinale);
            return GetStato();
        }

        public long AvanzaSingolaFaseLavorazione(object NumeroRegistrazioneOrdine,
                                            object ProgressivoRigaOrdine,
                                            object CodiceFaseLavorazione,
                                            decimal QuantitaAvanzamento,
                                            string DepositoAvanzamento,
                                            bool SaldoAvanzamento = false,
                                            string DepositoScarto = "",
                                            decimal QuantitaScarto = 0,
                                            decimal Quantita2Avanzamento = 0,
                                            decimal Quantita2Scarto = 0)
        {
            avanzprod.AvanzaSingolaFaseLavorazione(NumeroRegistrazioneOrdine,
                ProgressivoRigaOrdine,
                CodiceFaseLavorazione,
                QuantitaAvanzamento,
                DepositoAvanzamento,
                SaldoAvanzamento,
                null,
                null,
                tsEnumTipoTempo.tsMinuti,
                null,
                tsEnumTipoOrario.tsOrdinario,
                tsEnumTipoOra.tsLavorazione,
                tsEnumTipoLavorazione.tsInterna,
                DepositoScarto,
                QuantitaScarto,
                Quantita2Avanzamento,
                Quantita2Scarto
                );

            return GetStato();
        }

        public long ConfermaAvanzamentoFasiLavorazione()
        {
            avanzprod.ConfermaAvanzamentoFasiLavorazione();
            return GetStato();
        }


        public void Terminate()
        {
            avanzprod.Terminate();
        }

        public List<OdlDaAvanzare> CercaPrimoODLApertoPerArticolo(string server, string database, string utenteSql, string password, string codiceArticolo, string variante)
        {
            string connectionString = "SERVER=" + server + ";UID=" + utenteSql + "; PWD=" + password + ";DATABASE=" + database;
            OdlDaAvanzare res = new OdlDaAvanzare();
            List<OdlDaAvanzare> result = new List<OdlDaAvanzare>();
            string commandText = @"SELECT TOP 1 
                        DO11_NUMREG_CO99, 
                        DO30_PROGRIGA,
	                    DO46_CODFASE,
                        DO46_PROGDET,
                        DO11_DATADOC,
                        DO30_CODART_MG66,
                        DO30_QTA1,
                        DO31_QTA1CONS
                    FROM VDO11_AVANZORDLAV WITH(NOLOCK)
                    WHERE 
                        DO11_DITTA_CG18 = @codditta
                        AND DO11_TIPODOC = 24
                        AND DO11_STIPODOC = 20
                        AND DO30_CODART_MG66 = @codiceArticolo
                        AND DO30_OPZIONE_MG5E = @variante
                        AND DO46_PROGDET > 0
                        AND DO46_PROGSFASE = 0
                        AND DO31_FLGNONPIUEV = 0
                    ORDER BY
                        DO11_DATADOC ASC,
                        DO11_NUMREG_CO99 ASC,
                        DO30_PROGRIGA ASC,
                        DO46_PROGDET ASC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@codditta", SqlDbType.Decimal);
                command.Parameters["@codditta"].Value = Codditta;
                command.Parameters.Add("@codiceArticolo", SqlDbType.Char);
                command.Parameters["@codiceArticolo"].Value = codiceArticolo;
                command.Parameters.Add("@variante", SqlDbType.Char);
                command.Parameters["@variante"].Value = variante;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        res.Numreg = reader["DO11_NUMREG_CO99"].ToString();
                        res.ProgRiga = Convert.ToDecimal(reader["DO30_PROGRIGA"]);
                        res.CodFase = reader["DO46_CODFASE"].ToString();
                        result.Add(res);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return result;
        }

        private bool ControllaDateMagazzino(string connectionString, DateTime datareg)
        {
            bool res = true;

            string commandText = @"SELECT 
                                    CG30_DATAULTAGGMAG, 
                                    CG30_DATAULTCHIUSMAG
                                FROM
                                    CG30_ANADITTADATE WITH (NOLOCK)
                                WHERE
                                    CG30_DITTA_CG18 = @codditta";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.Add("@codditta", SqlDbType.Decimal);
                command.Parameters["@codditta"].Value = Codditta;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DateTime dataultagg;
                    DateTime datachiusura;
                    while (reader.Read())
                    {
                        if (!String.IsNullOrEmpty(reader["CG30_DATAULTAGGMAG"].ToString()))
                        {
                            dataultagg = Convert.ToDateTime(reader["CG30_DATAULTAGGMAG"]);
                            if (dataultagg.Date >= datareg)
                            {
                                res = false;
                            }
                        }
                        if (!String.IsNullOrEmpty(reader["CG30_DATAULTCHIUSMAG"].ToString()))
                        {
                            datachiusura = Convert.ToDateTime(reader["CG30_DATAULTCHIUSMAG"]);
                            if (datachiusura.Date >= datareg)
                            {
                                res = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return res;
        }
    }

}
