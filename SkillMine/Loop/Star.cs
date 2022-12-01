using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Star
    {
        static void Main(string[] args)
        {
            for(int i=0;i<4;i++)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
