using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Zadatak4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koliko brojeva zelite: ");
            int br_ukupno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] brojevi = new int[br_ukupno];

            Console.WriteLine("Unesite min za opseg brojeva: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Unesite max za opseg brojeva: ");
            int max = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for(int i = 0; i < br_ukupno;i++)
            {
                brojevi[i] = random.Next(min, max);
            }

            Console.WriteLine("===================================");

            string lokacija = @"F:\FAKULTET\Programiranje moblinih komunikacija\Zadatak4\Fajlovi\brojevi.txt";

            StreamWriter streamWriter = File.CreateText(lokacija);
            foreach (var broj in brojevi)
            {
                streamWriter.Write($"{broj} ");
            }

            streamWriter.Close();

            var sadrzaj = File.ReadAllLines(lokacija);

            //foreach (var linija in sadrzaj)
            //{
            //    Console.Write(linija + " ");
            //}
            //Console.WriteLine();

            var strjoin = string.Join("", sadrzaj);
            string[] strsep = strjoin.Split(' ');
            //Console.WriteLine(strsep.Length);

            int[] brojevifolder = new int[strsep.Length - 1];

            int k = 0;
            foreach (var broj in strsep)
            {
                try
                {
                    brojevifolder[k] = Int32.Parse(broj);
                    k++;
                    //Console.Write(broj + " ");
                } catch(Exception e) { continue; }
            }

            Console.WriteLine();
            //Console.WriteLine(brojevifolder[2].GetType());

            double avg = (double)brojevifolder.Average();
            Console.WriteLine($"Srednja vrednost je: {avg}.");

            int minV = (int)brojevifolder.Min();
            Console.WriteLine($"Najmanja vrednost je: {minV}.");

            int maxV = (int)brojevifolder.Max();
            Console.WriteLine($"Najveca vrednost je: {maxV}.");
        }
    }
}
