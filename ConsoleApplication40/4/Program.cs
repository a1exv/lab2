using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite predlozhenie");
            string str = Console.ReadLine();
            int count = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] == ' ')||(str[i]=='\n')) count++;
            }
            Console.WriteLine("Kol-vo slov = " + count);
        }
    }
}
