using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class UseContinue
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
