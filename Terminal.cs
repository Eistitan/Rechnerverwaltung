using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class Terminal : Rechner
    {
        public string? Standort { get; set; }
        public Server? Referenz { get; set; }

        public Terminal(string? standort, Server? referenz, string name, string ip) : base(name, ip)
        {
            Standort = standort;
            Referenz = referenz;
        }
        public override string ToString()
        {
            string terminal = $"\nStandort des Terminals: {Standort}\nTerminal ist mit dem {Referenz.Name} Server verbunden";
            return base.ToString()+terminal;
        }
    }
}
