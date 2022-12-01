using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Sorting
{
    class SortingMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int f = int.Parse(Console.ReadLine());
            int[] ar = new int[f];
            for(int i=0;i<ar.Length;i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sorting S = new Sorting();
            int[] d =S.Display(ar);
            for(int i=0;i<ar.Length;i++)
            {

            }
        }
    }
}
// Marge 2 Array and in 1 array but remove duplicate