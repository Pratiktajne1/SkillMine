using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Basic_Program
{
    class DiviededBy_5_and_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0 && num % 7 == 0)
                Console.WriteLine("This number Divided by 7 and 5");
            else
                Console.WriteLine("This number not Divided by 5 and 7");
        }
    }
}
