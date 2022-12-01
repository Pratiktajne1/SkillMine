using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class AdditionOfPrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any no");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
           

            for(int i=2;i<num;i++)
            {
                bool flag = true;
                for (int j=2;j<i;j++)
                {
                 
                    if (i%j==0 && num%j==0)
                    {
                        flag = false;
                        break;
                        
                    }
                   
                }
                if (flag)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Prime Number Addition is " + sum);
            Console.ReadLine();
        }
    }
     
}
