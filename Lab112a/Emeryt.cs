using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab112a
{
    class Emeryt
    {
        public bool ZwolnionyZOplat { get; set; }
        public string NrLegitymacji { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string AdresZdjecia { get; set; }

        public (bool, string nr, DateTime, string adres) ZwrocWszystkieDane()
        {
            return (ZwolnionyZOplat, NrLegitymacji, DataUrodzenia, AdresZdjecia); // musi być po kolei takj ak wpisane jest w metodzie
        }

        public void Deconstruct(out string nrLegitymacji, out bool zwolnienieZOplaty, out DateTime urodziny, out string zdjecie)
        {
            nrLegitymacji = NrLegitymacji;
            zwolnienieZOplaty = ZwolnionyZOplat;
            urodziny = DataUrodzenia;
            zdjecie = AdresZdjecia;
        }
        static int nr = 0;
        public void Deconstruct(out string nrLegitymacji, out string zdjecie)
        {
            nrLegitymacji = NrLegitymacji;
            zdjecie = AdresZdjecia;
        }
    }
}
