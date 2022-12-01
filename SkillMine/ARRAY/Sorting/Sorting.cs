using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.ARRAY.Sorting
{
    class Sorting
    {
        public int[] Display(int[] arr)
        {
            bool flag=true;
            int k = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        k = arr[j];
                        arr[j] = arr[i];
                        arr[i] = k;
                    }
                }

            }

            return arr;
        }
    }
}
