using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Basic_Program.DayName
{
    class DayNameMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number from 1 to 7");
            int a = int.Parse(Console.ReadLine());
            DayName dn = new DayName();
            string s =dn.DName(a);
            Console.WriteLine(s);


        }
    }
}
