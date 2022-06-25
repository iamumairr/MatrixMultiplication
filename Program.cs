namespace EssentialMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r1, c1, r2, c2;
            Console.Write("\nInput the number of rows and columns of the first matrix :\n");
            Console.Write("Rows : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput the number of rows of the second matrix :\n");
            Console.Write("Rows : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[r1, c1];
            int[,] brr1 = new int[r2, c2];

            Console.Write("Input elements in the first matrix :\n");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Input elements in the second matrix :\n");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            MatrixMultiplier.Multiplies(arr1, brr1);

            Console.ReadLine();
        }
    }
}
