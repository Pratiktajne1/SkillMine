using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Display_Vowels
{
    class Vowels_Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter all chareter");
            char[] ch = new char[10];
            for(int i=0;i<ch.Length;i++)
            {
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            Vowel v = new Vowel(ch);
            v.Disply();
        }
    }
}
