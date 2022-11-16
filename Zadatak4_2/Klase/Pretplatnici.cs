using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak4_2.Klase
{
    public class Pretplatnici
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string RadnoMesto { get; set; }

        public Pretplatnici(string ime, string prezime, string radnomesto)
        {
            Ime = ime;
            Prezime = prezime;
            RadnoMesto = radnomesto;
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}, {RadnoMesto}";
        }
    }
}
