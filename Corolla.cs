namespace Interface
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Toyota;
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