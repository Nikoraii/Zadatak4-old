using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Zadatak4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>()
            {
                new Osoba("Jovan", "Jovanovic", "Beograd", 250350),
                new Osoba("Marko", "Markovic", "Novi Sad", 175000),
                new Osoba("Ivana", "Ivanovic", "Beograd", 193000),
                new Osoba("Petar", "Petrovic", "Beograd", 265000),
                new Osoba("Ana", "Anic", "Zrenjanin", 384500),
            };

            using (var swriter = new StreamWriter(@"F:\FAKULTET\Programiranje moblinih komunikacija\Zadatak4\Fajlovi\osobe.xml"))
            {
                XmlSerializer xmlSerializerOsobe = new XmlSerializer(typeof(List<Osoba>));
                xmlSerializerOsobe.Serialize(swriter, osobe);
            }

            
            bool idi = true;
            while (idi)
            {
                var dalje = "";
                Console.WriteLine("Da li zelite uneti novu osobu i izvrsiti serijalizaciju te osobe ili " +
                    "zelite procitati sve osobe?");
                Console.Write("(pisi/citaj): ");
                dalje = Console.ReadLine();
                Console.WriteLine();

                if (dalje == "pisi")
                {
                    Console.WriteLine("Unesite Ime osobe: ");
                    var ime1 = Console.ReadLine();

                    Console.WriteLine("Unesite Prezime osobe: ");
                    var prezime1 = Console.ReadLine();

                    Console.WriteLine("Unesite Radno Mesto osobe: ");
                    var radnomesto1 = Console.ReadLine();

                    Console.WriteLine("Unesite Godisnji prihod osobe: ");
                    var godisnjiprihodi1 = Console.ReadLine();
                    double godisnjiprihodi1DBL = Convert.ToDouble(godisnjiprihodi1);

                    osobe.Add(new Osoba(ime1, prezime1, radnomesto1, godisnjiprihodi1DBL));

                    using (var swriter = new StreamWriter(@"F:\FAKULTET\Programiranje moblinih komunikacija\Zadatak4\Fajlovi\osobe.xml"))
                    {
                        XmlSerializer xmlSerializerOsobe = new XmlSerializer(typeof(List<Osoba>));
                        xmlSerializerOsobe.Serialize(swriter, osobe);
                    }

                    Console.WriteLine("\nUspesno ste uneli osobu.");

                    idi = true;
                }
                else if (dalje == "citaj")
                {
                    Console.WriteLine("Sve osobe: \n");
                    using (var sreader = new StreamReader(@"F:\FAKULTET\Programiranje moblinih komunikacija\Zadatak4\Fajlovi\osobe.xml"))
                    {
                        XmlSerializer xmlSerializerOsobe = new XmlSerializer(typeof(List<Osoba>));
                        osobe = (List<Osoba>)xmlSerializerOsobe.Deserialize(sreader);
                        foreach (var osoba in osobe)
                        {
                            Console.WriteLine(osoba);
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Pogresan izbor.");
                    Console.Write("(pisi/citaj): ");
                    dalje = Console.ReadLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
