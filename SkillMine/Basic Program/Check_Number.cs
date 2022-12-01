using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Basic_Program
{
    class Check_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num>0)
                Console.WriteLine("Positive number");
            else if(num<0)
                Console.WriteLine("Negative number");
            else
                Console.WriteLine("Zero");

        }
    }
}
