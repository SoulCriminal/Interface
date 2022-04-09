using System;


namespace Interface
{  
    class Program
    {
        static void Main(string[] args)
        {
            Foucs focus = new Foucs();
            Console.WriteLine(focus.HangiMarka().ToString());
            Console.WriteLine(focus.KacTekerlekVar().ToString());
            Console.WriteLine(focus.StandartRenk().ToString());


            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarka().ToString());
            Console.WriteLine(civic.KacTekerlekVar().ToString());
            Console.WriteLine(civic.StandartRenk().ToString());
        }

    }
    
}