using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak4_2.Klase
{
    public class Pogodnosti
    {
        public string Pogodnost { get; set; }
        public Pogodnosti(string pogodnost)
        {
            Pogodnost = pogodnost;
        }

        public override string ToString()
        {
            return $"{Pogodnost}";
        }
    }
}
