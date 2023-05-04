using System;
using System.Runtime.CompilerServices;

namespace Bingo
{
    // Ako smatrate da nesto fali napisite u komentar issue-a
    public static class BingoUtil
    {
        /**
         * Generisati listice koristeci GenerisiKombinacijuZaListic()
         */
        public static List<List<int>> GenerisiListice(int zeljeniBrojListica)
        {
            List<List<int>> listici = new List<List<int>>();

            for (int i = 0; i < zeljeniBrojListica; i++)
            {
                listici.Add(GenerisiKombinacijuZaListic());
            }

            return listici;
        }

        /**
         * Generisati kombinaciju od 6 brojeva (1-39) 
         */
        public static List<int> GenerisiKombinacijuZaListic()
        {
            List<int> kombinacija = new List<int>();
            Random random = new Random();
            while (kombinacija.Count < 6)
            {
                int randomNumber = random.Next(40);

                if (!kombinacija.Contains(randomNumber))
                {
                    kombinacija.Add(randomNumber);
                }
            }

            return kombinacija;
        }

        /**
         * Generisane listice spremiti u .txt fajl
         */
        public static void SpremiListice(List<List<int>> listici, string nazivFajlaSaExtenzijom)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nazivFajlaSaExtenzijom))
                {
                    for (int i = 0; i < listici.Count; i++)
                    {
                        writer.Write($"Listic ({i + 1}): ");

                        for (int j = 0; j < listici[i].Count; j++)
                        {
                            writer.Write(listici[i][j]);
                            if (j != listici[i].Count - 1)
                            {
                                writer.Write(", ");
                            }
                        }
                        writer.WriteLine();
                        writer.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Desila se greska!");
            }
        }

        /**
         * Izvuci pobjednike i generisati izvjestaje
         * Izvjestaje spremiti u .txt fajl
         * Spremanje izvjestaja uraditi sa SpremanjeIzvjestaja()
         * Ispis izvrsti sa Ispis()
         */
        public static void GenerisanjeIzvjestaja(List<List<int>> listici, List<int> pobjednickaKobinacija)
        {
            Dictionary<string, int> brojPogodenihKombinacija = new Dictionary<string, int> {
            {"6", 0}, {"5", 0}, {"4", 0}, {"3", 0}};

            foreach (List<int> listic in listici)
            {
                int brojPogodataka = 0;
                foreach (int broj in listic)
                {
                    if (pobjednickaKobinacija.Contains(broj))
                    {
                        brojPogodataka++;
                    }
                }
                if (brojPogodataka > 2)
                {
                    brojPogodenihKombinacija[brojPogodataka.ToString()] =
                        brojPogodenihKombinacija[brojPogodataka.ToString()] + 1;
                }
            }

            SpremanjeIzvjestaja(brojPogodenihKombinacija, "izvjestaj.txt");
        }

        /**
         * Napraviti jednostavan ispis
         */
        static void Ispis(string stringZaIspisati)
        {
            Console.WriteLine(stringZaIspisati);
        }

        /**
         * Spremiti izvjestaje
         */
        static void SpremanjeIzvjestaja(Dictionary<string, int> brojPogdenihKombinacija, string nazivFajlaSaExtenzijom)
        {
            string izvjestaj = $"Sestice: {brojPogdenihKombinacija["6"]}\n" +
                $"Petice: {brojPogdenihKombinacija["5"]}\n" +
                $"Cetvroke: {brojPogdenihKombinacija["4"]}\n" +
                $"Trice: {brojPogdenihKombinacija["3"]}\n";

            using (StreamWriter writer = new StreamWriter(nazivFajlaSaExtenzijom))
            {
                writer.Write(izvjestaj);
            }

            Ispis(izvjestaj);
        }
    }
}

