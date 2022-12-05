using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Rechnerverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITVerwaltung.Fill_List();
            while (true)
            {
                Menu.Menu_Ganz();
            }
        }
    }
}
