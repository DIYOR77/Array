using System;
using System.Globalization;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n=random.Next(2,9);   
            int[][] arr = new int[n][];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[random.Next(1,9)];    
            }
            fillarray(arr, n);
        }
        
        public static int fillarray(int[][]arr,int n)
        {
            Random random=new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(11, 99);
                    Console.Write(" " + arr[i][j]);
                }
                Console.WriteLine();
            }
            return arr.Length;

        }
    }
}