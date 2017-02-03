using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
                int temp = 0;
                for (int k = 0; k < 5; k++)
                {
                    if (array1[i] == array2[k])
                    {
                        temp = array1[i];
                        break;
                    }

                }
                if (array3.Contains(temp) || temp == 0) continue;
                else
                {
                    array3[j] = temp;
                    j++;
                }

            }
            if (j > 0)
            {
                int[] array4 = new int[j];
                for (int a = 0; a < j; a++)
                {
                    array4[a] = array3[a];
                }
                foreach (int x in array4)
                {
                    Console.Write(x + " ");
                }
            }
            else Console.WriteLine("Net sovpadenii");
        }
    }
}
