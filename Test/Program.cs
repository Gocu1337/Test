namespace Test;
internal class Zadanie
{
    private static void Hello()
    {
        Console.Clear();
        Console.WriteLine("------Bank------");
    }
    private static float Menu()
    {
        Console.WriteLine("Wprowadź kwotę pożyczki");
        var podanakwota = Console.ReadLine();
        var kwota = float.TryParse(podanakwota, out var kwotaResult);

        if (!kwota)
        {
            Console.WriteLine("Podano niepoprawne dane");
            Console.WriteLine("Spróbuj ponownie");
            Console.WriteLine("-----------------------------------");
            kwotaResult = Menu();
        }
        return kwotaResult;
    }

    private static float Menu2()
    {
        Console.WriteLine("Wypisz na ile miesięcy chcesz pozyczyć");

        var Podanyczas = Console.ReadLine();
        var czas = float.TryParse(Podanyczas, out var czasResult);

        if (czas != true)
        {
            Console.WriteLine("Podano niepoprawną kwotę");
            Console.WriteLine("Spróbuj ponownie");
            Console.WriteLine("-----------------------------------");
            czasResult = Menu2();
        }
        return czasResult;
    }

    private static float MenuOprocentowania()
    {
        Console.WriteLine("Wprowadz oprocentowanie twojego kredytu w %");
        var Podaneoprocentowanie = Console.ReadLine();

        var oprocentowanie = float.TryParse(Podaneoprocentowanie, out var oprocentowanieResult);

        if (oprocentowanie != true)
        {
            Console.WriteLine("Podano niepoprawne oprocentowanie");
            Console.WriteLine("Spróbuj ponownie");
            Console.WriteLine("-----------------------------------");
            oprocentowanieResult = MenuOprocentowania();
        }
        return oprocentowanieResult;
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



    private static void Main()
    {
        var repeat = false;
        do
        {
            Hello();
            var kwotaResult = Menu();
            var czasResult = Menu2();
            var oprocentowanieResult = MenuOprocentowania();

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