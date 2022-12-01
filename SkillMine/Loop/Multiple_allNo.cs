using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Multiple_allNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any no");
            int a = int.Parse(Console.ReadLine());
            int s= 1;
             for(int i=0;i<=a;i++)
            {
                s = s * i;
            }
            Console.WriteLine(s);
        }
    }
}
