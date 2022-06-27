using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int final = 0;
            int rem;

            while(num != 0)
            {
                rem = num % 10;
                final = final * 10 + rem;
                num = num / 10;
            }

            Console.WriteLine("Reverse of given number is "+final);
        }
    }
}
