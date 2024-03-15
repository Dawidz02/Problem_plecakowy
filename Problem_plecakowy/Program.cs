using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly:
InternalsVisibleTo("TestProblemPlecakowy"), InternalsVisibleTo("WinFormsPlecak")]

namespace Problem_plecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Podaj liczbe przedmiotow :");
            int l_przedmiotow = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the seed :");
            int seed = int.Parse(Console.ReadLine());
            Console.WriteLine(" Podaj pojemnosc plecaka ");
            int C = int.Parse(Console.ReadLine());
            Problem problem1 = new Problem(l_przedmiotow, seed);
            problem1.Solve(C);
        }
    }
}
