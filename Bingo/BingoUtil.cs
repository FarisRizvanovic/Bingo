using System.Net.NetworkInformation;
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
            // generisati metodom od kere sa for petljom

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
            // kreiranje liste naziva kombinacija
            List<int> kombinacija = new List<int>();
            // kreiranje HashSeta naziva brojevi kako bi sačuvali brojeve
            HashSet<int> brojevi = new HashSet<int>();
            // kreiranje varijable rnd
            Random rnd = new Random();
            // while petlja kako bi generisali 6 brojeva
            while (brojevi.Count < 6)
            {
                // generisanje brojeva od 1 do 39
                int broj = rnd.Next(1, 40);
                // if petlja za provjeru da li se broj nalazi u HashSetu brojevi
                if (!brojevi.Contains(broj))
                {
                    // ako se ne nalazi u HashSetu dodaje se
                    brojevi.Add(broj);
                }
            }
            // konvertovanje HashSeta u listu
            kombinacija = brojevi.ToList();
            // Sortiranje liste
            kombinacija.Sort();
            // izlaz metode
            return kombinacija;
        }


        /**
         * Generisane listice spremiti u .txt fajl
         */
        public static void SpremiListice(List<List<int>> listici, string nazivFajlaSaExtenzijom)
        {

        }

        /**
         * Generisane listice koji su spremljeni u .txt fajlu procitati
         */
        public static List<List<int>> ProcitajListice()
        {
            List<List<int>> listici = new List<List<int>>();


            return listici;
        }

        /**
         * Izvuci pobjednike i generisati izvjestaje
         * Izvjestaje spremiti u .txt fajl
         * Spremanje izvjestaja uraditi sa SpremanjeIzvjestaja()
         * Ispis izvrsti sa Ispis()
         */
        public static void GenerisanjeIzvjestaja()
        {

        }

        /**
         * Napraviti jednostavan ispis
         */
        static void Ispis(string stringZaIspisati)
        {

        }

        /**
         * Spremiti izvjestaje
         */
        static void SpremanjeIzvjestaja(string izvjestaj)
        {

        }
    }
}