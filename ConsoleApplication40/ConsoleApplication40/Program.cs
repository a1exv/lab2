using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int [] A;
            double[,] B;
            A = new int[5];
            B = new double[3,4];
            Random R = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Vvedite chislo "+(i+1));
                A[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = R.NextDouble()*10;
                }
            }
            foreach (int i in A)
            {
                Console.Write(i+"  ");
            }
            Console.Write("\n");
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i,j] + "   ");
                }
                Console.Write("\n");
            }
            double max=A[0];
            double min=A[0];
            double sum=A[0];
            double prsum = A[0];
            int sumch=0;
            double sumnech=0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max) max = A[i];
                if (A[i] < min) min = A[i];
                sum += A[i];
                prsum *= A[i];
                if (i % 2 == 0) sumch += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > max) max = B[i, j];
                    if (B[i, j] < min) min = B[i, j];
                    sum += B[i, j];
                    prsum *= B[i, j];
                    if (j % 2 != 0) sumnech += B[i, j];
                }
            }
            Console.Write("max= {0}   min= {1}    sum= {2}   proizv = {3}   summa chetnih A =  {4}      summa nechetnih stolbcov B= {5} ", max, min, sum, prsum, sumch, sumnech);
        }
    }
}
