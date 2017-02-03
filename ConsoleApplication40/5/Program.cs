using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand=new Random();
            int[,] array = new int[5, 5];
            for(int i=0; i<5; i++)
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(200)-100;
                }
            int max=array[0,0];
            int min=array[0,0];
            foreach(int x in array){
                if (max>x) max=x;
                if(min<x) min=x;
            }
            int sum=0;
            foreach(int x in array){
                if ((x!=max)&&(x!=min)) sum+=x;
                Console.Write(x+"   ");
            }
            Console.WriteLine(sum);
            

        }
    }
}
