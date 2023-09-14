using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Orai230912
{
    class Program
    {
        static void Main(string[] args)
        {
            var sportolok = new List<Sportolo>();
            var sr = new StreamReader(
                path: @"..\..\..\src\fob2016.txt",
                Encoding.UTF8);
            while (!sr.EndOfStream) sportolok.Add(new Sportolo(sr.ReadLine()));
            Console.WriteLine($"3. feladat: Versenyzők száma: {sportolok.Count()}");

            int nsz = sportolok.Count(v => !v.Kategoria);
            float na = nsz / (float)sportolok.Count() * 100;
            Console.WriteLine($"4. feladat: Női versenyzők aránya: {na:0.00}%");

            Console.WriteLine("6. feladat:");
            var noiBajnok = sportolok
                .Where(v => !v.Kategoria)
                .OrderBy(v => v.Osszpontszam)
                .Last();
            Console.WriteLine($"\tNév: {noiBajnok.Nev}");
            Console.WriteLine($"\tEgyesület: {noiBajnok.Egyesulet}");
            Console.WriteLine($"\tÖsszpontszám: {noiBajnok.Osszpontszam}");

            using var sw = new StreamWriter
            (
                path: @"..\..\..\src\Osszpontszam.txt",
                append: false,
                encoding: Encoding.UTF8);

            foreach (var v in sportolok)
            {
                if (v.Kategoria) sw.WriteLine($"{v.Nev} {v.Osszpontszam};");
            }
        }
    }
}
