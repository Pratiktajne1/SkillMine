using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Basic_Program.Area_of_Tringle
{
    class Area_of_triangle_Main
    {
        static void Main(string[] arge)
        {
            Console.WriteLine("enter Base");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height");
            double h = Convert.ToDouble(Console.ReadLine());
            Area_of_Triangle AoT = new Area_of_Triangle();
            double result = AoT.Result(b, h);
            Console.WriteLine("Answer is " + result);


        }
    }
}
