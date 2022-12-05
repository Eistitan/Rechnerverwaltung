using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal static class Menu
    {
        public static void Menu_Ganz()
        {

            Console.WriteLine("Was möchten Sie machen?\nRechner (f)inden. Rechner (e)rstellen. Rechner (l)öschen, Liste (s)peichern?");
            string wahl = UserEingabe().ToLower();
            switch (wahl)
            {
                case "f":
                case "finden":
                    Menu_Ausgabe();
                    break;
                case "e":
                case "erstellen":
                    Menu_Erstellung();
                    break;
                case "l":
                case "löschen":
                    Menu_Loeschung();
                    break;
                case "s":
                case "speichern":
                    ITVerwaltung.Speichern();
                    break;
                default:
                    Console.WriteLine("Wie bitte?");
                    break;
            }
        }
        private static string UserEingabe()
        {
            return Console.ReadLine();
        }
        private static void Menu_Ausgabe()
        {
            Console.WriteLine("Welchen Typ des Rechners möchten Sie durchsuchen?\nServer, Terminal, Buero, Graphic, Alle");
            Spez_Ausgabe(UserEingabe());
            Console.WriteLine("");

        }
        private static void Ganze_Ausgabe()
        {
            ITVerwaltung.Total_Ausgabe();
        }

        private static void Spez_Ausgabe(string wert)
        {
            int counter = ITVerwaltung.rechner_liste.Count();
            int intern = 0;
            switch (wert.ToLower())
            {
                case "server":
                case "s":
                    for (int i = 0; i < counter; i++)
                    {
                        if (ITVerwaltung.rechner_liste[i] is Server)
                        {
                            intern++;
                            Console.WriteLine($"Nr. {intern}");
                            Console.WriteLine(ITVerwaltung.rechner_liste[i]);
                        }
                    }
                    break;
                case "terminal":
                case "t":
                    for (int i = 0; i < counter; i++)
                    {
                        if (ITVerwaltung.rechner_liste[i] is Terminal)
                        {
                            intern++;
                            Console.WriteLine($"Nr. {intern}");
                            Console.WriteLine(ITVerwaltung.rechner_liste[i]);
                        }
                    }
                    break;
                case "buero":  //Spuckt auch G_Workplace aus
                case "büro":
                case "workspace":
                case "b":
                    for (int i = 0; i < counter; i++)
                    {
                        if (ITVerwaltung.rechner_liste[i] is B_Workplace && ITVerwaltung.rechner_liste[i] is not G_Workplace)
                        {
                            intern++;
                            Console.WriteLine($"Nr. {intern}");
                            Console.WriteLine(ITVerwaltung.rechner_liste[i]);
                        }
                    }
                    break;
                case "graphisch":
                case "graphic":
                case "g":
                    for (int i = 0; i < counter; i++)
                    {
                        if (ITVerwaltung.rechner_liste[i] is G_Workplace)
                        {
                            intern++;
                            Console.WriteLine($"Nr. {intern}");
                            Console.WriteLine(ITVerwaltung.rechner_liste[i]);
                        }
                    }
                    break;

                default:
                    ITVerwaltung.Total_Ausgabe();
                    break;
            }
        }
        private static void Menu_Erstellung()
        {
            Console.WriteLine("Welcher Typ des Rechners soll erstellt werden?\nServer, Terminal, Buero, Graphic");

            Switch_Erstellung(UserEingabe());
        }
        private static void Switch_Erstellung(string wert)
        {
            int counter = ITVerwaltung.rechner_liste.Count();
            int intern = 0;
            switch (wert.ToLower())
            {
                case "server":
                case "s":
                    Console.Write("Name: ");
                    string name = UserEingabe();
                    Console.Write("IP: ");
                    string ip = UserEingabe();
                    Console.Write("Anzahl der CPU: ");
                    int cpu_anzahl = Int32.Parse(UserEingabe());
                    Console.Write("CPU Leistung: ");
                    double cpu_leistung = double.Parse(UserEingabe());
                    Console.Write("RAM: ");
                    int ram = Int32.Parse(UserEingabe());
                    Console.Write("Anzahl der Festplatten: ");
                    int festpl_anzahl = Int32.Parse(UserEingabe());
                    Console.Write("Größe der einzelnen Festplatte: ");
                    int festpl_groesse = Int32.Parse(UserEingabe());
                    Console.Write("Serverfunktion: ");
                    string serverfunktion = UserEingabe();
                    Console.Write("Netzleistung: ");
                    int netzleistung = Int32.Parse(UserEingabe());

                    ITVerwaltung.rechner_liste.Add(new Server(cpu_anzahl, cpu_leistung, ram, festpl_anzahl, festpl_groesse, serverfunktion, netzleistung, name, ip));
                    break;
                case "terminal":
                case "t":
                    //ITVerwaltung.Erstellung( UserEingabe(), Int32.Parse(UserEingabe()), UserEingabe(), UserEingabe());
                    Console.Write("Standort: ");
                    string standort = UserEingabe();
                    Console.Write("Reference: ");
                    int referenz = Int32.Parse(UserEingabe());
                    Console.Write("Name: ");
                    name = UserEingabe();
                    Console.Write("IP: ");
                    ip = UserEingabe();

                    ITVerwaltung.rechner_liste.Add(new Terminal(standort, (ITVerwaltung.rechner_liste[referenz] as Server), name, ip));
                    break;
                case "buero":  //Spuckt auch G_Workplace aus
                case "büro":
                case "workspace":
                case "b":
                    Console.Write("Name: ");
                    name = UserEingabe();
                    Console.Write("IP: ");
                    ip = UserEingabe();
                    Console.Write("CPU Leistung: ");
                    cpu_leistung = double.Parse(UserEingabe());
                    Console.Write("RAM: ");
                    ram = Int32.Parse(UserEingabe());
                    Console.Write("Größe der einzelnen Festplatte: ");
                    festpl_groesse = Int32.Parse(UserEingabe());

                    ITVerwaltung.rechner_liste.Add(new B_Workplace(cpu_leistung, ram, festpl_groesse, name, ip));
                    break;
                case "graphisch":
                case "graphic":
                case "g":
                    Console.Write("Name: ");
                    name = UserEingabe();
                    Console.Write("IP: ");
                    ip = UserEingabe();
                    Console.Write("CPU Leistung: ");
                    cpu_leistung = double.Parse(UserEingabe());
                    Console.Write("RAM: ");
                    ram = Int32.Parse(UserEingabe());
                    Console.Write("Größe der einzelnen Festplatte: ");
                    festpl_groesse = Int32.Parse(UserEingabe());
                    Console.Write("Größe des Monitors: ");
                    double monitor_groesse = double.Parse(UserEingabe());
                    Console.Write("Name der Grafikkarte: ");
                    string gpu = UserEingabe();

                    ITVerwaltung.rechner_liste.Add(new G_Workplace(monitor_groesse, gpu, cpu_leistung, ram, festpl_groesse, name, ip));
                    break;

                default:
                    Console.WriteLine("Falsche Eingabe");
                    break;
            }
        }

        private static void Menu_Loeschung()
        {
            Console.WriteLine("Bitte den Globalen Index des Rechners eingeben.\n" +
                "Der Rechner wird endgültig gelöscht und zerstört sich selbst nach 10 Sekunden.");
            int index = Int32.Parse(UserEingabe());
            Console.WriteLine("Sind Sie sich sicher? j/j");
            if (UserEingabe() == "j")
            {
                //for (int i = 10; i < 0; i--)
                //{
                //    Console.WriteLine(i);
                //}
                ITVerwaltung.Loeschen(index);
            }
            else
            {
                Console.WriteLine("Schade.");
            }
        }
    }
}
