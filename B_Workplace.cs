using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class B_Workplace : Rechner
    {
        public double CPU_Leistung { get; set; }
        public int RAM_Groesse { get; set; }
        public int Festplaten_Groesse { get; set; }

        public B_Workplace(double cPU_Leistung, int rAM_Groesse, int festplaten_Groesse, string name, string ip) : base(name, ip)
        {
            CPU_Leistung = cPU_Leistung;
            RAM_Groesse = rAM_Groesse;
            Festplaten_Groesse = festplaten_Groesse;
        }
        public override string ToString()
        {
            string b_workplace = $"\nWorkplace hat {CPU_Leistung} GHz Rechenleistung und {RAM_Groesse} Gb Arbeitsspeicher\nMit {Festplaten_Groesse} Gb Festplattenspeicher";
            return base.ToString() + b_workplace;
        }
    }
}
