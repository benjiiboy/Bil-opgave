using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave
{
    public class ElBil : Bil 
    {
        public ElBil(string mærke, string registringsnr, int prisexafgift, int købsår, int batterikapacitet, int kmprkw) : base(mærke, registringsnr, prisexafgift, købsår)
        {
            this.BatteriKapacitet = batterikapacitet;
            this.KmPrKW = kmprkw;
        }

        public int BatteriKapacitet {get; set; }
        public int KmPrKW { get; set; }

        public override int HalvÅrligEjerafgift()
        {
            return 0;
        }
        public override double RegristreringsAfgift()
        {
            return base.BilPrisExAfgift*0.2;
        }


        public override int Rækkevidde()
        {
            return BatteriKapacitet * KmPrKW;
        }
    }
}
