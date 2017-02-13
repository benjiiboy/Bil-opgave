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
            #region Gamel kode
            //List<DieselBil> dblist = new List<DieselBil>();

            //dblist.Add(new DieselBil("Mercedes", "ATROCKS", 30000, 2004, 12,false, 21));
            //dblist.Add(new DieselBil("BMW", "NK46281", 130000, 2015, 2, true, 21));
            //dblist.Add(new DieselBil("Ford", "UU77777", 200000, 2016, 32, true, 21));
            //dblist.Add(new DieselBil("VW", "HALOO", 3000000, 2014, 14, false, 21));
            //dblist.Add(new DieselBil("Skoda","YI82312", 10000, 2000, 16, 21));

            //Console.WriteLine("DieselBiler bliver vist 1-5");
            //Console.WriteLine("");
            //foreach (var item in dblist)
            //{
            //    Console.WriteLine("Registreingsnummer: "+item.RegistreringsNr+" Halvårlig Ejerafgift: "+item.HalvÅrligEjerafgift());
            //}

            //List<BenzinBil> bblist = new List<BenzinBil>();
            //bblist.Add(new BenzinBil("Toyota", "12KIH56", 45000, 1999, 29, 21));
            //bblist.Add(new BenzinBil("MBW", "12FGFH", 450000, 2016, 23, 21));
            //bblist.Add(new BenzinBil("VW", "123306Y", 10000, 2005, 15, 21));
            //bblist.Add(new BenzinBil("Citroen", "12KFH46", 5000, 1990, 12, 21));
            //bblist.Add(new BenzinBil("Fiat", "GHHD234", 90000, 2001, 25, 21));

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("BenzinBiler bliver vist 1-5");
            //foreach (var i in bblist)
            //{
            //    Console.WriteLine(
            //         " Mærke: " + i.Mærke +
            //         " Registreringsnummer: " + i.RegistreringsNr +
            //         " Pris Ex afgift: " + i.BilPrisExAfgift +
            //         " Årgang: " + i.KøbsÅr +
            //         " KM/L: " + i.KmPrLiter +
            //         " Halvårlig ejerafgift: " + i.HalvÅrligEjerafgift() +
            //         "\r\n Regstreringsafgift: " + i.RegristreringsAfgift() +
            //         " Total Pris: " + i.TotalPris() +
            //         " Rækkevidde: " + i.Rækkevidde()
            //        );
            //    Console.WriteLine("");
            //}

            //List<ElBil> ebliste = new List<ElBil>();

            //ebliste.Add(new ElBil("BMW", "GGH445S", 1000000, 2016, 40, 10));
            //ebliste.Add(new ElBil("Mazda", "146GH7", 132000, 2012, 50, 40));
            //ebliste.Add(new ElBil("Ford", "GHRT56", 333000, 2010, 33, 30));
            //ebliste.Add(new ElBil("Toyota", "1GF4G67", 100000, 2017, 70, 9));
            //ebliste.Add(new ElBil("Mercedes", "GGH55G1", 150000, 2006, 20, 20));

            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("ElBiler bliver vist 1-5");

            //foreach (var i in ebliste)
            //{
            //    Console.WriteLine(
            //        " Mærke: " + i.Mærke +
            //        " Registreringsnummer: " + i.RegistreringsNr +
            //        " Pris exafgift: " + i.BilPrisExAfgift +
            //        " Årgang: " + i.KøbsÅr +
            //        " Batteri Kapasitet: " + i.BatteriKapacitet +
            //        " Km pr liter: " + i.KmPrKW +
            //        " \r\n Rækkevidde: " + i.Rækkevidde() +
            //        " Total Pris: " + i.RegristreringsAfgift()
            //        );
            //    Console.WriteLine("");
            //}
            #endregion

            List<IBil> AlleBiler = new List<IBil>();

            /*Dette er alle Dieselbilerne*/
            AlleBiler.Add(new DieselBil("Mercedes", "ATROCKS", 30000, 2004, 12, false, 21));
            AlleBiler.Add(new DieselBil("BMW", "NK46281", 130000, 2015, 2, true, 21));
            AlleBiler.Add(new DieselBil("Ford", "UU77777", 200000, 2016, 32, true, 21));
            AlleBiler.Add(new DieselBil("VW", "HALOO", 3000000, 2014, 14, false, 21));
            AlleBiler.Add(new DieselBil("Skoda", "YI82312", 10000, 2000, 16, 21));

            /*Dette er alle Benzinbilerne*/
            AlleBiler.Add(new BenzinBil("Toyota", "12KIH56", 45000, 1999, 29, 21));
            AlleBiler.Add(new BenzinBil("MBW", "12FGFH", 450000, 2016, 23, 21));
            AlleBiler.Add(new BenzinBil("VW", "123306Y", 10000, 2005, 15, 21));
            AlleBiler.Add(new BenzinBil("Citroen", "12KFH46", 5000, 1990, 12, 21));
            AlleBiler.Add(new BenzinBil("Fiat", "GHHD234", 90000, 2001, 25, 21));

            /*Dette er alle Elbilerne*/
            AlleBiler.Add(new ElBil("BMW", "GGH445S", 1000000, 2016, 40, 10));
            AlleBiler.Add(new ElBil("Mazda", "146GH7", 132000, 2012, 50, 40));
            AlleBiler.Add(new ElBil("Ford", "GHRT56", 333000, 2010, 33, 30));
            AlleBiler.Add(new ElBil("Toyota", "1GF4G67", 100000, 2017, 70, 9));
            AlleBiler.Add(new ElBil("Mercedes", "GGH55G1", 150000xx, 2006, 20, 20));

            foreach (Bil i in AlleBiler)
            {
                if (i is DieselBil)
                {

                    DieselBil dieselbil1 = i as DieselBil;
                    Console.WriteLine(
     " DieselBil" +
     " \r\n Mærke: " + dieselbil1.Mærke +
     " Registreringsnummer: " + dieselbil1.RegistreringsNr +
     " Pris Ex afgift: " + dieselbil1.BilPrisExAfgift +
     " Årgang: " + dieselbil1.KøbsÅr +
     " KM/L: " + dieselbil1.KmPrLiter +
     " Halvårlig ejerafgift: " + dieselbil1.HalvÅrligEjerafgift() +
     "\r\n Regstreringsafgift: " + dieselbil1.RegristreringsAfgift() +
     " Total Pris: " + dieselbil1.TotalPris() +
     " Rækkevidde: " + dieselbil1.Rækkevidde() +
     " Partikel filter: " + dieselbil1.PartikelFilter
    );

                }

                else if (i is BenzinBil)
                {
                    BenzinBil benzinbil1 = i as BenzinBil;

                    Console.WriteLine(
     " Benzinbil" +
     " \r\n Mærke: " + benzinbil1.Mærke +
     " Registreringsnummer: " + benzinbil1.RegistreringsNr +
     " Pris Ex afgift: " + benzinbil1.BilPrisExAfgift +
     " Årgang: " + benzinbil1.KøbsÅr +
     " KM/L: " + benzinbil1.KmPrLiter +
     " Halvårlig ejerafgift: " + benzinbil1.HalvÅrligEjerafgift() +
     "\r\n Regstreringsafgift: " + benzinbil1.RegristreringsAfgift() +
     " Total Pris: " + benzinbil1.TotalPris() +
     " Rækkevidde: " + benzinbil1.Rækkevidde()
    );
                
                }
                else if (i is ElBil)
                {
                    ElBil elbil1 = i as ElBil;

                    Console.WriteLine(
    " Elbil" +
    " \r\n Mærke: " + elbil1.Mærke +
    " Registreringsnummer: " + elbil1.RegistreringsNr +
    " Pris exafgift: " + elbil1.BilPrisExAfgift +
    " Årgang: " + elbil1.KøbsÅr +
    " Batteri Kapasitet: " + elbil1.BatteriKapacitet +
    " Km pr liter: " + elbil1.KmPrKW +
    " \r\n Rækkevidde: " + elbil1.Rækkevidde() +
    " Total Pris: " + elbil1.RegristreringsAfgift()
    );
                }

                if (i is IelMotor)
                {
                    ElBil elbil2 = i as ElBil;
                    Console.WriteLine("Bilen har en el motor og en lade tid på: " +  elbil2.LadeTid());
                }
            }
            Console.ReadLine();


        }
    }
}
