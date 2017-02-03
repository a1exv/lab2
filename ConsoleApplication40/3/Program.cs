using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite stroku");
            string str = Console.ReadLine();
            int lenght = str.Length;
            int back=lenght-1;
            int i;
            for (i = 0; i < lenght / 2; i++)
            {
                if (str[i] == str[back])
                {
                    back--;
                    continue;
                }
                else break;
            }
            if (i == lenght / 2) Console.WriteLine("palindrom");
            else Console.WriteLine("net");
        }
    }
}
