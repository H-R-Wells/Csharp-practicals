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
            String str = Console.ReadLine();
            int vowels = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u'){
                    vowels++;
                }
            }

            Console.WriteLine("Number of vowels present in the string is " + vowels);
            Console.ReadKey();
        }
    }
}
