namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOTO!!");

            // Generisanje
            Generisanje();

            // Izvlacenje
            Izvlacenje();

            Console.ReadKey();
        }

        static void Generisanje()
        {
            // Traziti unos kolko listica zelimo
            Console.WriteLine("Unesite broj listica za generisati: ");
            int zeljeniBrojListica = Convert.ToInt32(Console.ReadLine());

            // Generisati listice
            List<List<int>> listici = BingoUtil.GenerisiListice(zeljeniBrojListica);

            // Spremiti listice u fajl
            BingoUtil.SpremiListice(listici, "listici.txt");

        }


        static void Izvlacenje()
        {
            // Generisati pobjednicku kombinaciju
            List<int> pobjednickaKobinacija = BingoUtil.GenerisiKombinacijuZaListic();

            // Procitati listice iz fajla
            List<List<int>> listici = BingoUtil.ProcitajListice();

            // Generisanje izvjestaja i ispis
            BingoUtil.GenerisanjeIzvjestaja();

        }

    }

}