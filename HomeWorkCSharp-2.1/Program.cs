using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            //2.1. Составить программу:
            //а) вычисления значения функции y = 7x^2 + 3x + 6 при любом значении x;
            //б) вычисления значения функции x = 12a^2 + 7a + 12 при любом значении а.            
            Console.Write("а) Вычислите значение функции y = 7x^2 + 3x + 6\nВведите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = (7 * (x * x)) + (3 * x) + 6;
            Console.WriteLine($"Значение функции У при значении X = {x} равняется {y}");
            Console.Write("б) Вычислите значение функции x = 12a^2 + 7a + 12\nВведите значение A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double x1 = (12 * (a * a)) + (7 * a) + 12;
            Console.WriteLine($"Значение функции X при значении A = {a} равняется {x1}");
        }
    }
}
