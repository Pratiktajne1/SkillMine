using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.Loop
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int k = 0, num, t, v, sum = 0, b = 1, num2;
            Console.WriteLine("enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            t = num;
            num2 = num;
            while (num > 0)              //153
            {
                while (t > 0)
                {
                    t = t / 10;
                    k++;                   // k=3
                }
                v = num % 10;              // v = 153%10 = 3
                for (int i = 1; i <= k; i++)
                {
                    b = b * v;             //  b = 3*3*3 = 24
                }
                sum = sum + b;            //sum = 24 .....(b=24)
                b = 1;                    //b = 1
                num = num / 10;           // num = 153/10 = 15

            }
            if (num2 == sum)
            {
                Console.WriteLine("armstrong");
            }
            else
            {
                Console.WriteLine("not armstrong");
            }


        }
    }
}
