using System;

namespace EssentialMaths
{
    public class Matrix2D
    {
        public Matrix2D(int[,] array)
        {
            ReturnArray(array);
            DisplayArray(array);
        }

        public void ReturnArray(int[,] array)
        {
            Console.WriteLine("\nMatrix is:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        public void DisplayArray(int[,] array)
        {
            Console.WriteLine("\nMatrix contents are:");
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
