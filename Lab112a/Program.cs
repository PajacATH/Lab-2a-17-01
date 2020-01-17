using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab112a
{
    class Program
    {
        static double ObliczCeneBiletu(object pasazer)
        {
            /*
            if(pasazer is Dziecko dziecko)
            {
                //var dziecko = (Dziecko)pasazer;
                Console.WriteLine($"To jest dziecko, ma zniżke {dziecko.Znizka}");
            }
            else if(pasazer is Emeryt oStarsza)
            {
                Console.WriteLine("To jest osoba starsza");
                if(oStarsza.ZwolnionyZOplat)
                {
                    Console.WriteLine("ma darmowe przejazdy");
                }
            }
            */

            /*
            switch (pasazer)
            {
                case Dziecko d:
                    Console.WriteLine($"To jest dziecko, ma zniżke {d.Znizka}");
                    break;
                case Emeryt os when os.ZwolnionyZOplat: // jeśli os.ZwolnionyZOplat = true tworzy sie case (coś jak if)
                    Console.WriteLine("Osoba starsza, posiada darmowe przejazdy");
                    break;
                case Emeryt _:
                    Console.WriteLine("To jest osoba starsza");
                    break;
                case Rencista r when (r.WaznoscRenty > DateTime.Now || r.RentaBezterminowa): // DateTime.Now <- data teraźniejsza
                    Console.WriteLine($"To jest rencista, ma darmowy przejazd i rente ważną do {r.WaznoscRenty.ToShortDateString()}"); // "ToShortDateString" daje nam całą date bez godzin, tylko rok miesiąc i dzień
                    break;
                case null:
                    Console.WriteLine("Nie wiem co to jest");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }
            */

            return 0;
        }

        static void Main(string[] args)
        {
            #region Ćw.1
            /*
            var pasazer = new ZwyklyPasazer();
            var dziecko = new Dziecko() { Znizka = 0.5 };
            var emeryt = new Emeryt() { ZwolnionyZOplat = true };
            var rencista = new Rencista() { RentaBezterminowa = false, WaznoscRenty = new DateTime(2023, 10, 15) }; // rok, miesiąc, dzień <- data
            var rBezWaznosci = new Rencista() { RentaBezterminowa = false, WaznoscRenty = new DateTime(2018, 3, 31) };

            ObliczCeneBiletu(pasazer);
            ObliczCeneBiletu(dziecko);
            ObliczCeneBiletu(emeryt);
            ObliczCeneBiletu(rencista);
            ObliczCeneBiletu(rBezWaznosci);

            Console.WriteLine("\nObiekty Testowe:");
            ObliczCeneBiletu("pasażer");
            ObliczCeneBiletu(null);
            */
            #endregion
            #region Ćw.2
            /*
            var osoba = new Emeryt() { AdresZdjecia = "/images/photo/123jad.jpeg",
                                       DataUrodzenia = DateTime.Now.AddYears(-70), // czyli ktoś kto ma 70 lat w tym momencie ( aktualna data - 70 lat
                                       NrLegitymacji = "CHB728184",
                                       ZwolnionyZOplat = true };

            (bool znizka, string legitka, DateTime DataUr, string fotka ) = osoba.ZwrocWszystkieDane(); // kiedy damy "_" zamiast zmiennej i jej typu to nie zwróci nam tej zmiennej
            var (obnizka, legitymacja, DataUro, zdjecie) = osoba.ZwrocWszystkieDane(); // tutaj nie wpisujemy typu zmiennych bo var sam sie domysli jakie są (trzeba dobrze wpisać sobie zmienne)
            var temp = osoba.ZwrocWszystkieDane();
            Console.WriteLine($"{temp.nr} {temp.adres}");

            var (nrLegitymacji, obniszszszka, urodziny, fotografia) = osoba; // dekonstruktor (nie trzeba wpisywać dokładnie że to dekonstruktor
            var (samNumer, samoZdjecie) = osoba;                            // program sam sie domyśli że chodzi o dekonstruktor
            */
            #endregion

            var mlodzik = new Dziecko() { DataUrodzenia = new DateTime(2004, 10, 23), Imie = "Bartek" };

            var studenciak = new Dziecko() { DataUrodzenia = new DateTime(1998, 4, 21), Imie = "Błażej" };

            Dziecko mlodzierzWieksza = new Dziecko(new DateTime(2001, 7, 14), "Bonawentura");


            var (data, imie) = mlodzik;
            var (dataUrodzenia, immie) = studenciak;
            (DateTime dataUr, string imiee) = mlodzierzWieksza; // inna metoda wypisania Deconstructora


            Console.ReadKey();
        }
    }

    // tą funkcje napisać jako dekonstruktor
}
