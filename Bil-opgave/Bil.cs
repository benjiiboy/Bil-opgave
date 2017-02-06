using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bil_opgave
{
    public class Bil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }
        private int beløbsgrænse;

        public virtual int RegristreringsAfgift()
        {
            int sum = 0;
            if (KøbsÅr <= 2014)
            {
                beløbsgrænse = 80500;
            }
            else
                beløbsgrænse = 81700;

            if (BilPrisExAfgift <= beløbsgrænse)
            {
                sum = BilPrisExAfgift * (105 / 100);
            }
            else
            {
                sum = beløbsgrænse * (105 / 100);
                sum += (BilPrisExAfgift - beløbsgrænse) * (180 / 100);
            }
            return sum;
        }

        public int TotalPris()
        {
            return BilPrisExAfgift + RegristreringsAfgift();
        }

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }

        public Bil(string mærke, int prisexafgift, int købsår, int kmprliter )
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = prisexafgift;
            this.KøbsÅr = købsår;
            this.KmPrLiter = kmprliter;
        }

    }
}
