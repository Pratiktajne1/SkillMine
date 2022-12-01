using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Star5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number for print 'N' ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) //6
            {
                for (int j = 0; j < num; j++)  //6
                {
                    if (j == 0 || j == num - 1 || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }

        }
    }
}
