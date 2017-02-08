namespace Bil_opgave
{
    public interface IBil
    {
        int BilPrisExAfgift { get; }
        int KøbsÅr { get; }
        string Mærke { get; set; }
        string RegistreringsNr { get; set; }

        int HalvÅrligEjerafgift();
        double RegristreringsAfgift();
        int Rækkevidde();
        double TotalPris();
    }
}