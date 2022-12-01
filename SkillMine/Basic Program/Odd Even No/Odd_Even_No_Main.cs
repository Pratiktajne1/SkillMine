using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Basic_Program.Odd_Even_No
{
    class Odd_Even_No_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int a = int.Parse(Console.ReadLine());
            if(a%2==0)
                Console.WriteLine("Even No");
            else
                Console.WriteLine("Odd No");
          
        }
    }
}
