using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class UseBreak
    {
        static void Main(string[] args)
        {
          
            for (int i = 0; i <= 10; i++)
            {
                if(i==5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
