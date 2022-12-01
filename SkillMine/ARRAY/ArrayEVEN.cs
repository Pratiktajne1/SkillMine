using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY
{
    class ArrayEVEN
    {
        int[] arr;
        public ArrayEVEN(int[] a)
        {
            arr = new int[a.Length];
            int j = 0;
            for(int i=0;i<a.Length;i++)
            {
                arr[j] = a[i];
                j++;
            }
        }
        public void Display()
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter any Array");
            int[] a = new int[5];
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            ArrayEVEN AE = new ArrayEVEN(a);
            AE.Display();
        }
    }
}
