using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY
{
    class ReverseIntCharFloat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size");
            int s = Convert.ToInt32(Console.ReadLine());         
            int[] ar = new int[s];
            char[] ac = new char[s];
            float[] af = new float[s];
            Console.WriteLine("Enter any int Array");
            for (int i=0;i<ar.Length;i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter any Char Array");
            for (int i = 0; i < ac.Length; i++)
            {
                ac[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter any float Array");
            for (int i = 0; i < af.Length; i++)
            {
                af[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Revers INT Array is ");
            for (int i = ar.Length-1; i >=0; i--)
            {
                Console.Write(ar[i]+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("Revers CHAR Array is ");
            for (int i = ac.Length - 1; i >= 0; i--)
            {
                Console.Write(ac[i]+"  ");
            }
            Console.WriteLine();
            Console.WriteLine("Revers FLOAT Array is ");
            for (int i = af.Length - 1; i >= 0; i--)
            {
                Console.Write(af[i]+"  ");
            }



        }
    }
}
