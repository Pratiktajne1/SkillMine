using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Star2
    {
        static void Main(string[] args)
        {
            for(int i='A';i<='D';i++)
            {
                for(int j='A';j<='D';j++)
                {
                    Console.Write((char)j);
                }
                Console.WriteLine();
            }
        }
    }
}
