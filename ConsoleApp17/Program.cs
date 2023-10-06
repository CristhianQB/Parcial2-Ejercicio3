using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("*");
            int i = 1;
            while (i < num)
            {
                int aste = 1;
                while (aste <= i*2)
                {
                    Console.Write("*");
                    aste++;
                }
                i++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
