using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Zadatak4_2.Klase;

namespace Zadatak4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Nije mi najjasnije sta je bilo potrebno uraditi u ovom programu sto se tice obavestenja
            List<Pretplatnici> pretplatnici = new List<Pretplatnici>()
            {
                new Pretplatnici("Jovan", "Jovanovic", "Beograd"),
                new Pretplatnici("Marko", "Markovic", "Beograd"),
                new Pretplatnici("Ivana", "Ivanovic", "Zrenjanin"),
                new Pretplatnici("Nikola", "Nikolic", "Novi Sad"),
                new Pretplatnici("Marija", "Maric", "Zrenjanin"),
            };

            pretplatnici.ForEach(Console.WriteLine);

            var putanja = @"F:\FAKULTET\Programiranje moblinih komunikacija\Zadatak4\Fajlovi\pretplatnik.txt";

            List<string> sve_pogodnosti = new List<string>();

            Pogodnosti pogodnost1 = new Pogodnosti("Nova pogodnost");
            Pogodnosti pogodnost2 = new Pogodnosti("Nova pogodnost 2");
            Pogodnosti pogodnost3 = new Pogodnosti("Nova pogodnost 3");
            Pogodnosti pogodnost4 = new Pogodnosti("Nova pogodnost 4");

            sve_pogodnosti.Add(Convert.ToString(pogodnost1));
            sve_pogodnosti.Add(Convert.ToString(pogodnost2));
            sve_pogodnosti.Add(Convert.ToString(pogodnost3));
            sve_pogodnosti.Add(Convert.ToString(pogodnost4));

            File.WriteAllLines(putanja, sve_pogodnosti.ToArray());

            Console.WriteLine();

            if(new FileInfo(putanja).Length != 0)
            {
                Console.WriteLine("OBAVESTENJE!\n");
                for(int i = 0; i < sve_pogodnosti.Count; i++)
                {
                    Thread.Sleep(3000);
                    var pogodnost_citaj = File.ReadAllLines(putanja);
                    Console.WriteLine(pogodnost_citaj[i]);
                }
            }

            //var pogodnost1_str = Convert.ToString(pogodnost1);
            //File.WriteAllText(putanja, pogodnost1_str);

        }
    }
}
