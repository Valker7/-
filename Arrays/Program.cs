using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            TaskFour();

        }

        static void TaskFour()
        {
            Random rand = new Random();
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] Array = new int[N,M];

            for (int i = 0; i<Array.Length; i++)
            {
                for (int j = 0; j<Array.Length; j++)
                {
                    Array[i,j] = rand.Next(1, 70);
                }
               
            }
            Print(Array);

            

        }
        static void Print(int[,] arr)
            {
                for (int i = 0; i<arr.Length; i++)
                {
                    for (int j = 0; j<arr.Length; j++)
                    {
                    Console.Write(arr[i,j] + " ");
                    Console.WriteLine();
                    }
                    
                }
            }

    }
}
//int[] newArray = new int[Array.Length];
