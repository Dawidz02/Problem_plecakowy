using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:
InternalsVisibleTo("TestProblemPlecakowy"), InternalsVisibleTo("WinFormsPlecak")]

namespace Problem_plecakowy
{
    internal class Result
    {
        public int wynik_wag;
        public int wynik_wartosci;
        public List<int> wynik_nr_przedmiotow;
        public Result(List<int> spakowane_przed, int laczna_war, int laczna_wag)
        {
            Console.WriteLine($"Laczna wartosc przedmiotow: {laczna_war}     Laczna waga przedmiotow: {laczna_wag}");
            Console.WriteLine("Numery spakowanych przedmiotow:");
            for (int i = 0; i < spakowane_przed.Count; i++)
            {
                Console.Write($"[{spakowane_przed[i]}], ");
            }

            wynik_wag = laczna_wag;
            wynik_wartosci = laczna_war;
            wynik_nr_przedmiotow = spakowane_przed;
            
        }

        //Przeciazenie toString()
        public override string ToString()
        {
            return $"\nWaga: {wynik_wag} \nWartość: {wynik_wartosci} \nPrzedmioty: {string.Join(", ", wynik_nr_przedmiotow)}";
        }
    }
}
