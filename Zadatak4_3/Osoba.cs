using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Zadatak4_3
{
    [Serializable]
    public class Osoba : ISerializable
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string RadnoMesto { get; set; }
        public double GodisnjiPrihodi { get; set; }

        public double MesecniPrihodi()
        {
            return Math.Round(GodisnjiPrihodi / 12, 2);
        }
        public Osoba(string ime, string prezime, string radnomesto, double godisnjiprihodi)
        {
            Ime = ime;
            Prezime = prezime;
            RadnoMesto = radnomesto;
            GodisnjiPrihodi = godisnjiprihodi;
        }
        public Osoba() : this("", "", "", 0) { }
        public override string ToString()
        {
            return $"{Ime} {Prezime}, {RadnoMesto}: \n\t Mesecni Prihodi: {MesecniPrihodi()}";
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Ime", Ime);
            info.AddValue("Prezime", Prezime);
            info.AddValue("RadnoMesto", RadnoMesto);
            info.AddValue("GodisnjiPrihodi", GodisnjiPrihodi);
        }

        public Osoba(SerializationInfo info, StreamingContext context)
        {
            Ime = (string)info.GetValue("Ime", typeof(string));
            Prezime = (string)info.GetValue("Prezime", typeof(string));
            RadnoMesto = (string)info.GetValue("RadnoMesto", typeof(string));
            GodisnjiPrihodi = (double)info.GetValue("GodisnjiPrihodi", typeof(double));
        }
    }
}
