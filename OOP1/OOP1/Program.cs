using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class temp
    {
        String name, hobby;

        public void getData()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter hobby");
            hobby = Console.ReadLine();
            Console.WriteLine();
        }
        public void displayData()
        {
            Console.WriteLine(name+"'s hobby is "+hobby);
        }
        public String tHobby()
        {
            return hobby;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            temp[] info = new temp[5];

            for (int i = 0; i < 5; i++)
            {
                info[i] = new temp();
                info[i].getData();
            }
            for (int i = 0; i < 5; i++)
            {
                if (info[i].tHobby() == "reading")
                {
                    info[i].displayData();
                }
            }
        }
    }
}
