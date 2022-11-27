using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documenti
{
    public class DatiCorpo
    {
        public string Numreg { get; set; }
        public int ProgRiga { get; set; }
        public decimal Qta1 { get; set; }
        public decimal Qta2 { get; set; }
    }

    public class DatiCorpoLot
    {
        public int ProgMG4F { get; set; }
        public int Progriga { get; set; }
        public int Proglotto { get; set; }
        public string CodLotto { get; set; }
        public string Serialnumber { get; set; }
        public decimal Qta1Lot { get; set; }
        public decimal Qta2Lot { get; set; }
    }
}
