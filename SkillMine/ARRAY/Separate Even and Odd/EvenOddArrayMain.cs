using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Separate_Even_and_Odd
{
    class EvenOddArrayMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Array");
            int[] arr = new int[a];
            for(int i = 0;i<a;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            EvenOddArray EO = new EvenOddArray();
            EO.Display(arr);
        }
    }
}
