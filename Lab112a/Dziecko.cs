using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab112a
{
    class Dziecko
    {
        public double Znizka { get; set; }
        public string Imie { get; set; }
        public DateTime DataUrodzenia; // data nie mogła być właściwością, bo nie mógłbym przypisać parametru w dekonstruktorze w mainie
        public string TypSzkoly { get; set; }
        //public void Deconstructor(out double zn, out DateTime du, out string ts)
        //{
        //    zn = Znizka;
        //    du = DataUrodzenia;
        //    ts = TypSzkoly;
        public void Deconstruct(out DateTime dataUr, out string imie)
        {
            dataUr = DataUrodzenia;
            imie = Imie;

            int wiek = (DateTime.Now.Year - DataUrodzenia.Year);

            switch (wiek)
            {
                case 7: 
                case 8: 
                case 9: 
                case 10:
                case 11:
                    TypSzkoly = "Podstawówka";
                    Znizka = 0.5;
                    break;
                case 16: 
                case 17: 
                case 18: 
                case 19:
                    TypSzkoly = "Szkoła średnia";
                    Znizka = 0.3;
                    break;
                case 20: 
                case 21: 
                case 22:
                    TypSzkoly = "Studia Inżynierskie";
                    Znizka = 0.4;
                    break;
                case 23: 
                case 24: 
                case 25:
                    TypSzkoly = "Studia magisterskie";
                    Znizka = 0.35;
                    break;
                default:
                    Console.WriteLine("DEFAULT");
                    break;
            }
            Console.WriteLine($"Imię: {Imie} \nData urodzenia: {DataUrodzenia.ToShortDateString()} \nWiek: {wiek} \nWykształcenie: {TypSzkoly} \nZniżka: {Znizka}\n");

        }
        public Dziecko (DateTime dataUr, string imie) 
        {
            DataUrodzenia = dataUr;
            Imie = imie;
        }
        public Dziecko() { }
    }
}