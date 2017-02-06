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

            Console.WriteLine("DieselBiler bliver vist 1-5");
            Console.WriteLine("");
            foreach (var item in dblist)
            {
                Console.WriteLine("Registreingsnummer: "+item.RegistreringsNr+" Halvårlig Ejerafgift: "+item.HalvÅrligEjerafgift());
            }

            List<BenzinBil> bblist = new List<BenzinBil>();
            bblist.Add(new BenzinBil("Toyota", "12KIH56", 45000, 1999, 29));
            bblist.Add(new BenzinBil("MBW", "12FGFH", 450000, 2016, 23));
            bblist.Add(new BenzinBil("VW", "123306Y", 10000, 2005, 15));
            bblist.Add(new BenzinBil("Citroen", "12KFH46", 5000, 1990, 12));
            bblist.Add(new BenzinBil("Fiat", "GHHD234", 90000, 2001, 25));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BenzinBiler bliver vist 1-5");
            Console.WriteLine("");
            foreach (var i in bblist)
            {
                Console.WriteLine(
                     " Mærke: " + i.Mærke + 
                     " Registreringsnummer: " + i.RegistreringsNr + 
                     " Pris Ex afgift: " + i.BilPrisExAfgift + 
                     " Årgang: " + i.KøbsÅr + 
                     " KM/L: " + i.KmPrLiter + 
                     " Halvårlig ejerafgift: " + i.HalvÅrligEjerafgift() + 
                     " Regstreringsafgift: " + i.RegristreringsAfgift() + 
                     " Total Pris: " + i.TotalPris()
                    );
                Console.WriteLine("");
            }


            Console.ReadLine();


        }
    }
}
