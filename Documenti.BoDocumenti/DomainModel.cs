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
        public string CodLotto { get; set; }
        public decimal Qta1Lot { get; set; }
        public decimal Qta2Lot { get; set; }
    }
}
