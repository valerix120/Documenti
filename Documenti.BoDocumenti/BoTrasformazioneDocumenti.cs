using Documenti.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Documenti.BoTrasformazioneDocumenti
{


    public class BoTrasformazioneDocumenti : IBoTrasformazioneDocumenti
    {
        internal static CLSMG_REGTRASFDOCIN RegTrasfDocIn { get; set; }
        internal static CLSMG_REGTRASFDOCPARAM RegTrasfDocParam{ get; set; }
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
            RegTrasfDocParam = COMWrapper.Wrap<CLSMG_REGTRASFDOCPARAM> (trasfdoc.RegTrasfDocParam);
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

       public void TrasformazioneDocumento(string modellotrasf, string numreg, object IndiceRottura)
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
            trasfdoc.RegTrasfDocParam.INDTIPOELAB = tsTrasfDocIndTipoElab.tsTrasfDocIndTipoElabConfermaManuale;
            trasfdoc.OpenRecordsets(pstrFiltroTestata, "", "", "", "", "", "", "", "");

        }

    }

}
