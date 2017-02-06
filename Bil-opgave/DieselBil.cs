using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave
{
    public class DieselBil : Bil
    {
        public DieselBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter, bool partikelfilter) : base(mærke, registringsnr, prisexafgift, købsår, kmprliter)
        {
            this.PartikelFilter = partikelfilter;
        }

        public DieselBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter) : this(mærke, registringsnr, prisexafgift, købsår, kmprliter, true)
        {

        }

        public bool PartikelFilter { get; set; }


        public override int HalvÅrligEjerafgift()
        {
            int sum = 0;
            if (PartikelFilter == false)
            {
                return sum += 500;
            }
            else if (KmPrLiter <15)
            {
                 sum += 2000;
            }
            else if (KmPrLiter <= 15 && KmPrLiter >= 25)
            {
                sum += 1000;
            }
            else if (KmPrLiter> 25)
            {
                sum += 350;
            }
            return sum;

        }
    }
}
