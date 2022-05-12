namespace Projekt
{
    class Zadanie
    {

        static void Main(string[] args)
        {
            Console.WriteLine("------Bank------");
            Console.WriteLine("Wprowadź kwotę pożyczki");
            string kwota = Console.ReadLine();
            float spr1 = 0;
            bool cyferka1 = float.TryParse(kwota, out spr1);   

            if (cyferka1 != true)
            {
                Console.WriteLine("Podano niepoprawne dane");
                Console.WriteLine("Spróbuj ponownie");
                Environment.Exit(0);
            }         

            Console.WriteLine("Wypisz na jak długo miesięcy chcesz pozyczyć");
      
            string czas = Console.ReadLine();
            int spr2 = 0;
            bool cyferka2 = int.TryParse(czas, out spr2);

            if (cyferka2 != true)
            {
                Console.WriteLine("Podano niepoprawne dane");
                Console.WriteLine("Spróbuj ponownie");
                Environment.Exit(0);
            }
          

            short iloscMiesiecy;
            float oprocentowanie_miesieczne;

            float splata = 0f;
            float miesiac = 0f;
            short i = 0;
            Console.WriteLine("Wprowadz oprocentowanie twojego kredytu w %");
            string oprocentowanie = Console.ReadLine();
            float spr3 = 0;
            bool cyferka3 = float.TryParse(oprocentowanie, out spr3);

            if (cyferka3 != true)
            {
                Console.WriteLine("Podano niepoprawne dane");
                Console.WriteLine("Spróbuj ponownie");
                Environment.Exit(0);
            }
           

            Console.Clear();
            Console.WriteLine("------Bank------");
            Console.WriteLine("Kwota pozyczki wynosi: " + spr1);
            Console.WriteLine("Wybrałeś pożyczkę na " + spr2 + " miesięcy");
            Console.WriteLine("Twoje oprocentowanie wynosi " + spr3 + " %");

            oprocentowanie_miesieczne = (float)(spr3 / 100.0);
            iloscMiesiecy = 1;

  
          
                splata += spr1 + (oprocentowanie_miesieczne * spr1);



                     
                     Console.WriteLine("Kwota do spłacenia wynosi : {0}", splata);
                     do
                     {
                         miesiac = splata / spr2;
                         Console.WriteLine("Miesiąc  {0} Spłata  {1}", ++i, miesiac);
                         spr2--;
                     } while (spr2 > 0);

             

            Console.ReadKey();
        }
    }
}

