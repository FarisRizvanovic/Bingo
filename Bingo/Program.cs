namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOTO!!");

            Bingo();

            Console.ReadKey();
        }

        static void Bingo()
        {
            // Traziti unos kolko listica zelimo
            Console.Write("Unesite broj listica za generisati: ");
            int zeljeniBrojListica = Convert.ToInt32(Console.ReadLine());

            // Generisati listice
            List<List<int>> listici = BingoUtil.GenerisiListice(zeljeniBrojListica);

            // Spremiti listice u fajl
            BingoUtil.SpremiListice(listici, "listici.txt");

            // Generisati pobjednicku kombinaciju
            List<int> pobjednickaKobinacija = BingoUtil.GenerisiKombinacijuZaListic();

            // Generisanje i spremanje izvjestaja te ispis
            BingoUtil.GenerisanjeIzvjestaja(listici, pobjednickaKobinacija);

        }

    }

}