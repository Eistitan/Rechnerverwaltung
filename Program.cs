using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Rechnerverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            //Console.WriteLine(ITVerwaltung.rechner_liste[2]);
            //ITVerwaltung.Test_L();

            //Console.WriteLine("");
            //ITVerwaltung.Total_Ausgabe();
            //Console.WriteLine("\nIndex 0 Gelöscht");
            //ITVerwaltung.Loeschen(0);
            //ITVerwaltung.Total_Ausgabe();
            //ITVerwaltung.Erstellung(6.6, 64, 9001, "Chef_1", "1.1.1.1");
            //Console.WriteLine("\nNeuer Rechner BW erstellt");
            //ITVerwaltung.Total_Ausgabe();

            //bool isTrue;
            //isTrue = (ITVerwaltung.rechner_liste[1] is Terminal);
            //Console.WriteLine(isTrue);

            //Menu.Menu_Erstellung();
            //Menu.Menu_Erstellung();
            //Menu.Menu_Erstellung();
            //Menu.Menu_Ausgabe();
            ITVerwaltung.Fill_List();
            ITVerwaltung.Speichern();

            //while (true)
            //{
            //    Menu.Menu_Ganz();
            //}
        }

    }
}
