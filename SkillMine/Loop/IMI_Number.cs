using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class IMI_Number
    {
        static void Main(string[] args)
        {
            long a, sum = 0;
            Console.WriteLine("enter any 15 digit number");
            long num = long.Parse(Console.ReadLine());
            while (num > 0)
            {
                a = num % 10;
                sum = sum + a;
                num = num / 10; ;
            }
            if (sum % 10 == 0)
            {
                Console.WriteLine("IMI number");
            }
            else
            {
                Console.WriteLine("not IMI number");
            }



        }
    }
}
