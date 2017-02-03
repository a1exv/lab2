using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1;
            array1 = new int[5] { 2, 5, 8, 5, 11 };
            int[] array2 = new int[5] { 3, 5, 5, 11, 14 };
            int[] array3 = new int[5];
            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                int temp;
                for (int k = 0; k < 5; k++)
                {
                    if (array1[i] == array2[k])
                    {
                        temp = array1[i];
                        break;
                    }

                }
                if (array3.Contains(temp)) continue;
                else
                {
                    array3[j] = array1[temp];
                    j++;
                }

            }
            foreach (int x in array3)
            {
                Console.Write(x + " ");
            }
        }
    }
}


