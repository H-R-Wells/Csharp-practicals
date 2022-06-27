using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            String str = Console.ReadLine();
            int vowels = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowels++;
                }
            }
            Console.WriteLine("Number of vowels in the string is " + vowels);
            Console.ReadKey();
        }
    }
}
