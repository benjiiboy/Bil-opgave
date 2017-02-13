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
            double regAfgift;

            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift >= 80500)
                {
                    regAfgift = BilPrisExAfgift * 105 / 100;
                }
                else
                {
                    regAfgift = BilPrisExAfgift * 180 / 100;
                }
                return regAfgift;
            }
            else
            {
                if (BilPrisExAfgift >= 81700)
                {
                    regAfgift = BilPrisExAfgift * 105 / 100;
                }
                else
                {
                    regAfgift = BilPrisExAfgift * 180 / 100;
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
