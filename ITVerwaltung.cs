using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal static class ITVerwaltung
    {
        public static List<Rechner> rechner_liste = new();
        private static int laenge;

        public static void Fill_List()
        {
            rechner_liste.Add(new G_Workplace(14, "Asus Sowieso", 3.7, 16, 1000, "GW1", "127.0.0.1"));
            rechner_liste.Add(new Server(24, 3.5, 128, 20, 5000, "Raid6-Speicher", 9001, "SV_Raid_2", "125.45.22.1"));
            rechner_liste.Add(new Terminal("Raum 245, Position 22", (rechner_liste[1] as Server), "Terminal_342", "123.132.12.4"));
            rechner_liste.Add(new B_Workplace(2.8, 16, 500, "Büro_WP_32", "85.21.132.11"));
            rechner_liste.Add(new G_Workplace(32, "RTX 5090 Plus Ultra", 2.3, 16, 1000, "Gr_WP_43", "132.12.125.1"));
            
        }
        public static void Speichern()
        {
            StreamWriter sw1 = new("Liste.txt");
            for (int i = 0; i < rechner_liste.Count; i++)
            {
                sw1.WriteLine(rechner_liste[i].ToString());
                sw1.WriteLine("");
            }
            sw1.Dispose();
        }

        //Ausgabe der Daten aller Rechner in der Liste 
        public static void Total_Ausgabe()
        {
            laenge = rechner_liste.Count();

            for (int i = 0; i < laenge; i++)
            {
                Console.WriteLine($"Index: {i}");
                Console.WriteLine(rechner_liste[i]);
                Console.WriteLine("");
            }
        }

        //Test
        public static void Test_L()
        {
            Console.WriteLine(laenge);
        }

        //Überladene Methode zum Befüllen der Liste
        public static void Erstellung(string standort,int referenz, string name, string ip)
        {
            rechner_liste.Add(new Terminal(standort, (rechner_liste[referenz] as Server), name, ip));
        }
        public static void Erstellung(string serverfunktion, double cpu_leistung, int cpu_anzahl, int ram, int festpl_anzahl, int festpl_groesse,  int netzleistung, string name, string ip)
        {
            rechner_liste.Add(new Server(cpu_anzahl, cpu_leistung, ram, festpl_anzahl, festpl_groesse, serverfunktion, netzleistung, name,ip));
        }
        public static void Erstellung(double cpu_leistung, int ram, int festpl_groesse, string name, string ip)
        {
            rechner_liste.Add(new B_Workplace(cpu_leistung,ram,festpl_groesse,name,ip));
        }
        public static void Erstellung(double monitor_groesse, string gpu, double cpu_leistung, int ram, int festpl_groesse, string name, string ip)
        {
            rechner_liste.Add(new G_Workplace(monitor_groesse,gpu,cpu_leistung,ram,festpl_groesse,name,ip));
        }

        //Methode zum Löschen eines Objekts aus der Liste mittels des Indexes
        public static void Loeschen(int index)
        {
            rechner_liste.RemoveAt(index);
        }

    }
}
