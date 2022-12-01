using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Sum_of_All_Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(a>0)
            {
                int r = a % 10;
                sum = sum + r;
                a = a / 10;
            }
            Console.WriteLine("Digit sum is " + sum);
        }
    }
}
