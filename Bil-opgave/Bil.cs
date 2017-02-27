using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave
{
    public abstract class Bil : IBil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }

        public virtual double RegristreringsAfgift()
        {
            //Unittest opg. 3: Kast exceptions
            if (BilPrisExAfgift <= 0)
                throw new ArgumentException("Prisen må ikke være <= 0");
            if (KøbsÅr < 2014)
                throw new ArgumentException("Købsår må ikke være før 2014");



            double regAfgift;

            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    regAfgift = BilPrisExAfgift * 1.05;
                }
                else
                {
                    regAfgift = (80500*1.05) + ((BilPrisExAfgift-80500) * 1.80);
                }
                return regAfgift;
            }
            else
            {
                if (BilPrisExAfgift <= 81700)
                {
                    regAfgift = BilPrisExAfgift * 1.05;
                }
                else
                {
                    regAfgift = (81700 * 1.05) + ((BilPrisExAfgift - 81700) * 1.80);
                }

                return regAfgift;
            }
        }

        public double TotalPris()
        {
            return BilPrisExAfgift + RegristreringsAfgift();
        }

        public abstract int HalvÅrligEjerafgift();
        

        public Bil(string mærke, string registringsnr, int prisexafgift, int købsår)
        {
            this.Mærke = mærke;
            this.RegistreringsNr = registringsnr;
            this.BilPrisExAfgift = prisexafgift;
            this.KøbsÅr = købsår;
        }

        public abstract int Rækkevidde();

        /*Test commit*/

    }
}
