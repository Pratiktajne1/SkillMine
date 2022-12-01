using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Separate_Even_and_Odd
{
    class EvenOddArray
    {
        public void Display(int[] ar)
        {
            int count = 0;
            Console.WriteLine();
            Console.WriteLine("Total Array------>");
            for(int i=0;i<ar.Length;i++)
            {
                if(ar[i]%2==0)
                {
                    count++;
                }
                Console.Write(ar[i] + "  ");             
            }
            Console.WriteLine();
            int[] Ev = new int[count];
            int[] Od = new int[ar.Length - count];
            int h = 0, k = 0;

            for(int i=0;i<ar.Length;i++)
            {
                if(ar[i]%2==0)
                {
                    Ev[h] = ar[i];
                    h++;
                }
                else
                {
                    Od[k] = ar[i];
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Even Array is------>");          
            for (int i=0;i<Ev.Length;i++)
            {
                Console.Write(Ev[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Odd Array------>");
            for (int i=0;i<Od.Length;i++)
            {
                Console.Write(Od[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
