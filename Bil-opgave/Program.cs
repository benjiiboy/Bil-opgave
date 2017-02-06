using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> dblist = new List<DieselBil>();

            dblist.Add(new DieselBil("Mercedes", "ATROCKS", 30000, 2004, 12,false));
            dblist.Add(new DieselBil("BMW", "NK46281", 130000, 2015, 2, true));
            dblist.Add(new DieselBil("Ford", "UU77777", 200000, 2016, 32, true));
            dblist.Add(new DieselBil("VW", "HALOO", 3000000, 2014, 14, false));
            dblist.Add(new DieselBil("Skoda","YI82312", 10000, 2000, 16));

            foreach (var item in dblist)
            {
                Console.WriteLine("Registreingsnummer: "+item.RegistreringsNr+" Halvårlig Ejerafgift: "+item.HalvÅrligEjerafgift());
            }

            Console.ReadLine();


        }
    }
}
