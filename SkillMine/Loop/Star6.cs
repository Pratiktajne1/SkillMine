using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Star6
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any Number for '+'");
                int num = Convert.ToInt32(Console.ReadLine());
                for(int i=0;i<num;i++)
                {
                    for(int j=0;j<num;j++)
                    {
                        if(i==num/2 || j== num/2)
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}
