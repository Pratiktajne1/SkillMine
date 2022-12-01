using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Basic_Program.Area_of_Cricle
{
    class AreaOfCricleMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter radius");
            int a = Convert.ToInt32(Console.ReadLine());
            Area_of_Cricle AC = new Area_of_Cricle();
            float s =AC.Display(a);
            Console.WriteLine(s);
        }
    }
}
