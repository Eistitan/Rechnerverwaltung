using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class G_Workplace : B_Workplace
    {
        public double Monitorgroesse { get; set; }
        public string? GPU_Name { get; set; }

        public G_Workplace(double monitorgroesse, string? gPU_Name, double cPU_Leistung, int rAM_Groesse, int festplaten_Groesse, string name, string ip) : base(cPU_Leistung, rAM_Groesse, festplaten_Groesse, name, ip)
        {
            Monitorgroesse = monitorgroesse;
            GPU_Name = gPU_Name;
        }
        public override string ToString()
        {
            string g_workplace = $"\n{Monitorgroesse} Zoll Monitor und {GPU_Name} Grafikkarte";
            return base.ToString() + g_workplace;
        }
    }
}
