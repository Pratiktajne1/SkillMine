using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class DiviedBy_5_and_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<num;i++)
            {
                if (num % 5 == 0 && num % 7 == 0)
                    Console.WriteLine($"This number {i} is divided by 5 and 7");

            }
           
           
        }
    }
}
