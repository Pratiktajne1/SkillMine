using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Frequence
{
    class Frequency
    {
        public void Display(int[] ar)
        {
            for(int i=0;i<ar.Length;i++)
            {
                int count = 1;
                bool flag = true;
                for (int k=0;k<i;k++)
                {
                    if(ar[i]==ar[k])
                    {
                        flag = false;
                        break;
                    }
                }
                if(flag)
                {
                    for(int j=i+1;j<ar.Length-1;j++)
                    {
                        if(ar[i]==ar[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{ar[i]} frequency is --> {count}");
                }
            }
        }
    }
}
