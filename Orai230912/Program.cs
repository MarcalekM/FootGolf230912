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
            Console.WriteLine("3. feladat");
            Console.WriteLine($"Versenyzők száma: {sportolok.Count()}");

            Console.WriteLine("4. feladat");
            int nsz = sportolok.Count(v => !v.Kategoria);
            float na = nsz / (float)sportolok.Count() * 100;
            Console.WriteLine($"Nói versenyzők aránya: {na:0.00}%");

            var nb = sportolok
                .Where(v => !v.Kategoria)
                .OrderBy(v.)
        }
    }
}
