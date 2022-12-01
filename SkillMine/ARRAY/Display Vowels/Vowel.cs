using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Display_Vowels
{
    class Vowel
    {
        char[] chr;
        char[] f;
        public Vowel(char[] ch)
        {
            chr = new char[ch.Length];
            for(int i=0;i<ch.Length;i++)
            {
                chr[i] = ch[i];
            }
        }
        public void Disply()
        {
            int j = 0;
          
            for(int i=0;i<chr.Length;i++)
            {
                
                if(chr[i] == 'a' || chr[i] == 'e' || chr[i] == 'i' || chr[i] == 'o' || chr[i] == 'u')
                {
                   
                    j++;
                }
            }
            char[] f = new char[j];
            for(int i=0,k=0;i<chr.Length || k<j;)
            {
                if (chr[i] == 'a' || chr[i] == 'e' || chr[i] == 'i' || chr[i] == 'o' || chr[i] == 'u')
                {
                    f[k] = chr[i];
                    k++;
                    
                }
                i++;

            }
            Console.WriteLine("-------------------------------------------------");
            for(int i=0;i<j;i++)
            {
                Console.WriteLine(f[i]);
            }
            Console.WriteLine("Total Vowels is = "+j);
            Console.WriteLine("-------------------------------------------------");
        }
       

    }
}
