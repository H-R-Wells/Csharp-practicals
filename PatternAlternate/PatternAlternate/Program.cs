using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAlternate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
