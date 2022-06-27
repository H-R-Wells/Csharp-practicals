using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            String str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            String str2 = String.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                str2 = str2 + arr[arr.Length-i-1];
            }

            Console.WriteLine(str2);
            Console.ReadKey();

        }
    }
}
