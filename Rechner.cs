using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class Rechner
    {
        public string Name { get; set; }
        public string IP { get; set; }

        public Rechner(string name, string iP)
        {
            Name = name;
            IP = iP;
        }

        public override string ToString()
        {
            string rechner = $"Rechner {Name} mit der IP: {IP}";
            return rechner ;
        }
    }
}
