using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class Server : Rechner
    {
        public int CPU_Anzahl { get; set; }
        public double CPU_Leistung { get; set; }
        public int RAM_Groesse { get; set; }
        public int Festplaten_Anzahl { get; set; }
        public int Festplaten_Groesse { get; set; }
        public string? Serverfunktion { get; set; }
        public double Netzleistung { get; set; }

        public Server(int cPU_Anzahl, double cPU_Leistung, int rAM_Groesse, int festplaten_Anzahl, int festplaten_Groesse, string? serverfunktion, double netzleistung, string name, string ip) : base(name, ip)
        {
            CPU_Anzahl = cPU_Anzahl;
            CPU_Leistung = cPU_Leistung;
            RAM_Groesse = rAM_Groesse;
            Festplaten_Anzahl = festplaten_Anzahl;
            Festplaten_Groesse = festplaten_Groesse;
            Serverfunktion = serverfunktion;
            Netzleistung = netzleistung;
        }
        public override string ToString()
        {
            string server = $"\nServer für {Serverfunktion} hat {CPU_Anzahl} CPU mit {CPU_Leistung} GHz Leistung\n{RAM_Groesse} Gb RAM und {Netzleistung} xx Netzleistung\n{Festplaten_Anzahl} Festplatten mit jeweils {Festplaten_Groesse} Gb Speicher";
            return base.ToString()+server;
        }
    }
}
