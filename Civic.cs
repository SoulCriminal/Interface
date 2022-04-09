namespace Interface
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public int KacTekerlekVar()
        {
            return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }
}