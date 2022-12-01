using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Star4
    {
        static void Main(string[] args)
        {
            for(int i =0;i<5;i++)
            {
                for(int j=0;j<9;j++)
                {
                    if(j>i+3 || j<5-i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            for(int i =3;i>=0;i--)
            {
                for(int j=8;j>=0;j--)
                {
                    if(j>i+3 || j<5-i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
          
        }
    }
}
