using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s;
            Console.WriteLine("Enter the string=");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];
                switch (letter)
                {
                    case 'a':
                        Console.WriteLine(letter + " is vowel");
                        break;
                    case 'e':
                        Console.WriteLine(letter + " is vowel");
                        break;
                    case 'i':
                        Console.WriteLine(letter + " is vowel");
                        break;
                    case 'o':
                        Console.WriteLine(letter + " is vowel");
                        break;
                    case 'u':
                        Console.WriteLine(letter + " is vowel");
                        break;
                    default:
                        Console.WriteLine(letter+" is not vowel");
                        break;
                }
            }
            Console.ReadKey();
        }
        
    }
}
