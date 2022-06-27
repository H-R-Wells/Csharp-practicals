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
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3, 4 };
            arr[1] = new int[] { 1, 2, 3, 4 ,5 };
            arr[2] = new int[] { 1, 2, 3, 4, 5, 6 };

            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}