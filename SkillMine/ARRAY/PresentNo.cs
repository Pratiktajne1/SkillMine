using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY
{
    class PresentNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any size");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[num];
            Console.WriteLine("Enter Array");
            for(int i=0;i<ar.Length;i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter any Number for searching");
            int num2 = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for(int i=0;i<ar.Length;i++)
            {
                if(ar[i]==num2)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Not Present");
            }

        }
    }
}
