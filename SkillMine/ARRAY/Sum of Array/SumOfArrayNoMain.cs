using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Sum_of_Array
{
    class SumOfArrayNoMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur Array");
            int[] a = new int[5];
            for(int i=0;i<5;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int g = 0;
            Sum_of_ArrayNo sa = new Sum_of_ArrayNo();
            foreach(int e in a)
            {
                int f = sa.Display(e);
                g = f;
                
            }
            Console.WriteLine("Even Number sum is " + g);

        }
    }
}
