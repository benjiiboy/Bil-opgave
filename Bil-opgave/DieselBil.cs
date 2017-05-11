using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave
{
    public class DieselBil : Bil
    {


        public DieselBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter, bool partikelfilter, int tank) : base(mærke, registringsnr, prisexafgift, købsår)
        {
            this.PartikelFilter = partikelfilter;
            this.Tank = tank;
            this.KmPrLiter = kmprliter;
        }

        public DieselBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter, int tank) : this(mærke, registringsnr, prisexafgift, købsår, kmprliter, true, tank)
        {
            this.Tank = tank;
        }

        public bool PartikelFilter { get; set; }


        public override int HalvÅrligEjerafgift()
        {
            int sum = 0;
            if (PartikelFilter == false)
            {
                 sum += 500;
            }

            if (KmPrLiter <15)
            {
                 sum += 2000;
            }
            else if (KmPrLiter >= 15 && KmPrLiter <= 25)
            {
                sum += 1000;
            }
            else if (KmPrLiter> 25)
            {
                sum += 350;
            }
            return sum;

        }

        public override int Rækkevidde()
        {
            return Tank * KmPrLiter;
        }

        public int Tank { get; set; }

        public int KmPrLiter{ get; set; }




    }
}
