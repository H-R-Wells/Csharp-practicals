using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            bool b1 = true;

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    b1 = false;
                    break;
                }
            }

            if (b1)
            {
                Console.WriteLine(n+" is a prime number");
            }
            else
            {
                Console.WriteLine(n+" is not a prime number");
            }

            Console.ReadKey();
        }
    }
}
