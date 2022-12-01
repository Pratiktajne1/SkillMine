using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Star3
    {
        static void Main(string[] args)
        {
            for (int i = 'A'; i <= 'D'; i++)
            {
                for (int j = 'A'; j <= i; j++)
                {
                    Console.Write((char)j);
                }
                Console.WriteLine();
            }
        }
    }
}
