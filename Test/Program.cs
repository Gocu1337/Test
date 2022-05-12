namespace Test
{
    class Zadanie
    {

        private static void Main()
        {
            Console.WriteLine("------Bank------");
            Console.WriteLine("Wprowadź kwotę pożyczki");
            var Podanakwota = Console.ReadLine();
            var kwota = float.TryParse(Podanakwota, out var kwotaResult);

            if (kwota != true)
            {
                Console.WriteLine("Podano niepoprawne dane");
                Console.WriteLine("Spróbuj ponownie");
                Environment.Exit(0);
            }         

            Console.WriteLine("Wypisz na jak długo miesięcy chcesz pozyczyć");

            var Podanyczas = Console.ReadLine();
            var czas = int.TryParse(Podanyczas, out var czasResult);

            if (czas != true)
            {
                Console.WriteLine("Podano niepoprawne dane");
                Console.WriteLine("Spróbuj ponownie");
                Environment.Exit(0);
            }

            float oprocentowanieMIesieczne;

            var splata = 0f;
            short i = 0;
            Console.WriteLine("Wprowadz oprocentowanie twojego kredytu w %");
            var Podaneoprocentowanie = Console.ReadLine();
            var oprocentowanie = float.TryParse(Podaneoprocentowanie, out var oprocentowanieResult);

            if (oprocentowanie != true)
            {
                Console.WriteLine("Podano niepoprawne dane");
                Console.WriteLine("Spróbuj ponownie");
                Environment.Exit(0);
            }
           
            Console.Clear();
            Console.WriteLine("------Bank------");
            Console.WriteLine("Kwota pozyczki wynosi: " + kwotaResult);
            Console.WriteLine("Wybrałeś pożyczkę na " + czasResult + " miesięcy");
            Console.WriteLine("Twoje oprocentowanie wynosi " + oprocentowanieResult + " %");

            oprocentowanieMIesieczne = (float)(oprocentowanieResult / 100.0);

                splata += kwotaResult + (oprocentowanieMIesieczne * kwotaResult);
                  
                     Console.WriteLine("Kwota do spłacenia wynosi : {0}", splata);
                     do
                     {
                var miesiac = splata / czasResult;
                Console.WriteLine("Miesiąc  {0} Spłata  {1}", ++i, miesiac);
                         czasResult--;
                     } while (czasResult> 0);

            Console.ReadKey();
        }
    }
}

