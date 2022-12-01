using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Basic_Program
{
    class Divided_By_3_or_9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num %3 ==0 || num %9 ==0)
                Console.WriteLine("This number Divided by 3 and 9");
            else
                Console.WriteLine("This number not Divided by 3 and 9");
        }
    }
}
