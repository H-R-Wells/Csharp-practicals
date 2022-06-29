using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{

    public class temp1
    {
        String name = "Shubham", hobby;



        public void getdata()
        {
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your hobby");
            hobby = Console.ReadLine();
        }



        public void displayData()
        {
            Console.WriteLine(name+"'s hobby is " +hobby);
        }

        public String getHobby()
        {
            return hobby;
        }


        /*
            temp1[] objStaff = new temp1[5];
            for (int i = 0; i < 2; i++)
            {
                objStaff[i] = new temp1();
                objStaff[i].getdata();
            }
            Console.WriteLine(objStaff[0].getHobby());
            for (int i = 0; i < 2; i++)
            {
                if (objStaff[i].getHobby() == "reading")
                    objStaff[i].displayData();
            }
         */

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            temp1[] temps = new temp1[5];

            for (int i = 0; i < 5; i++)
            {
                temps[i] = new temp1();
                temps[i].getdata();
            }
            for (int i = 0; i < 5; i++)
            {
                if (temps[i].getHobby() == "coding")
                {
                    temps[i].displayData();
                }

            }

        }
    }
}