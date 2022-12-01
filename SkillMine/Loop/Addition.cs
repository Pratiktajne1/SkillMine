using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Addition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=0;i<=a;i++)
            {
                sum = i + sum;
            }
            Console.WriteLine(sum);

          
        }

    }
}
