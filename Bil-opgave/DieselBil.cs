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

        public DieselBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter) : this(mærke,registringsnr, prisexafgift, købsår,kmprliter,true)
        {
            
        }

        public bool PartikelFilter { get; set; }


        public override int HalvÅrligEjerafgift()
        {
            if (PartikelFilter == false)
            {
                return base.HalvÅrligEjerafgift()+500;
            }
            else
                 return base.HalvÅrligEjerafgift();
        }
    }
}
