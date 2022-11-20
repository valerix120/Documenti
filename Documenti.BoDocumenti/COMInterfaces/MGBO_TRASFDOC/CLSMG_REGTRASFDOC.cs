﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti.Interop
{
    internal interface CLSMG_REGTRASFDOC : IDisposable
    {
        CLSMG_REGTRASFDOCIN RegTrasfDocIn { get; set; }
        CLSMG_REGTRASFDOCPARAM RegTrasfDocParam { get; set; }
        IRecordset rstDocTestata { get; set; }
        IRecordset rstDocCorpo { get; set; }
        IRecordset rstDocCorpoLot { get; set; }
        bool DisabilitaAperturaMascheraLotti { get; set; }
        void OpenRecordsets(string FiltroTestata = "", 
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
                            string FiltroDO36 = "");

        void EvasioneTotaleDocumenti(object IndiceRottura);
        bool GeneraSingoloDocumento(object IndiceRottura);

        void GeneraTuttiDocumenti();

        void CambiaDocCorpoQta1(object Num, bool FlagRicalcolaColli, bool FlagRicalcolaQuantita2);
        void CambiaDocCorpoQta2(object Num, bool FlagRicalcolaColli, bool FlagRicalcolaQuantita1);
        void Terminate();
        void Initialize();

    } 
}
