using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any no.");
            int num = int.Parse(Console.ReadLine());
            bool v = true;
            int g=0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    v = false;
                    break;
                }
                g = i;
            }
            if (v)
            {
                Console.WriteLine($"number is prime = {g}");
            }
            
           
        }
    }
}
