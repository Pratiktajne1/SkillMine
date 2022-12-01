using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Frequence
{
    class FrequencyMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Array");
            int[] arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Frequency f = new Frequency();
            f.Display(arr);
        }
    }
}
