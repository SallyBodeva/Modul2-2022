using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            
            int[,] A = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //Console.WriteLine($"A[{i}],{j}=");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("==============================");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                double average = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine($"A[{i},{j}]={A[i, j]}");
                        average += A[i, j];
                    
                }
                average /= col;
                Console.WriteLine(average);
            }
        }
    }
}
