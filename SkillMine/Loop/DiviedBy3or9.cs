using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class DiviedBy3or9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (num % 3 == 0 || num % 9 == 0)
                    Console.WriteLine($"This number {i} is divided by 3 or 9");

            }


        }
    }
}
