namespace Test;
internal class Zadanie
{
    public static bool Wprowadzenie;
    public static float Konwertuj;

    private static void Witaj()
    {
        Console.Clear();
        Console.WriteLine("------Bank------");
    }

    private static void ZlaWartosc()
    {
        Console.WriteLine("Podano niepoprawne dane");
        Console.WriteLine("Spróbuj ponownie");
        Console.WriteLine("-----------------------------------");
    }

    
    public static float MenuObliczenia(string Komunikat)
    {
       Console.WriteLine(Komunikat);
        var podanakwota = Console.ReadLine();
        var kwota = float.TryParse(podanakwota, out var kwotaResult);
        Wprowadzenie = kwota;
        Konwertuj = kwotaResult;
        if (!Wprowadzenie || Konwertuj < 1)
        {
            ZlaWartosc();
            Konwertuj = MenuObliczenia(Komunikat);
        }
        return Konwertuj;
    }
    


      private static void wypisz(float kwotaResult, float czasResult, float oprocentowanieResult, float splata)
      {
          Console.Clear();
          Console.WriteLine("------Bank------");
          Console.WriteLine("Kwota pozyczki wynosi: " + kwotaResult);
          Console.WriteLine("Wybrałeś pożyczkę na " + czasResult + " miesięcy");
          Console.WriteLine("Twoje oprocentowanie wynosi " + oprocentowanieResult + " %");

          Console.WriteLine("Kwota do spłacenia wynosi : {0}", splata);
          var i = 0;
          do
          {
              var miesiac = new Rata().Miesiac(splata, czasResult, i + 1);
              Console.WriteLine("Miesiąc {0} Spłata  {1}", ++i, miesiac);
          } while (i < czasResult);

      }
    

     static void Main(string[]args)
    {
        var repeat = false;
        do
        {
            Witaj();

            var kwotaResult = MenuObliczenia("Wprowadź kwotę pożyczki");
            var czasResult = MenuObliczenia("Podaj na jak długo miesiecy");
            var oprocentowanieResult = MenuObliczenia("Podaj oprocentowanie w %");

            var splata = new Rata().Splata(kwotaResult, oprocentowanieResult);

            wypisz(kwotaResult, czasResult, oprocentowanieResult, splata);

            var repeatExit = true;
            while (repeatExit)
            {
                Console.WriteLine("Jezeli chcesz wrócić do początku programu kliknij (p)");
                Console.WriteLine("Jezeli chcesz wyłączyć program kliknij (w)");
                var wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "p":
                        repeat = true;
                        repeatExit = false;
                        break;
                    case "w":
                        Console.WriteLine("Dziękujemy za skorzystanie z naszego programu");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Podałeś złą wartość!");
                        break;
                }
            }
        } while (repeat);
    }
}