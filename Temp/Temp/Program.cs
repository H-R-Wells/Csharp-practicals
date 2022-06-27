using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
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
                char a = str[i];
                switch (a)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine(a + " is a vowel");
                        vowels++;
                        break;
                    default:
                        Console.WriteLine(a + " is not a vowel");
                        break;
                }
            }
            Console.WriteLine("Totel number of vowels is "+vowels);

            Console.ReadKey();
        }
    }
}