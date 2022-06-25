using System;

namespace EssentialMaths
{
    public class MatrixMultiplier
    {
        public static void Multiplies(int[,] array1, int[,] array2)
        {
            int r1 = array1.GetLength(0);
            int c1 = array1.GetLength(1);
            int r2 = array2.GetLength(0);
            int c2 = array2.GetLength(1);
            int sum;

            int[,] crr1 = new int[r1, c2];

            if (c1 != r2)
            {
                Console.Write("Mutiplication of Matrix is not possible.");
                Console.Write("\nColumn of first matrix and row of second matrix must be same.");
            }
            else
            {
                //multiplication of matrix
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        crr1[i, j] = 0;
                    }
                }

                for (int i = 0; i < r1; i++)    //row of first matrix
                {
                    for (int j = 0; j < c2; j++)    //column of second matrix
                    {
                        sum = 0;
                        for (int k = 0; k < c1; k++)
                        {
                            sum = sum + array1[i, k] * array2[k, j];
                        }
                        crr1[i, j] = sum;
                    }
                }
                Console.Write("\nThe multiplication of two matrix is : \n");
                Matrix2D matrix2D = new Matrix2D(crr1);
            }
            Console.Write("\n\n");
        }
    }
}
