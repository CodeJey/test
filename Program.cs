using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What are the dimensions of your matrix? {Environment.NewLine}(For 2 or 3 dimensional ones calculations are available.)");

            int rowsCount = int.Parse(Console.ReadLine());
            Console.WriteLine('X');
            int stablesCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the numbers.");

            double[,] dist = new double[rowsCount, stablesCount];
            double value = 0;

            for (int row = 0; row <= rowsCount - 1; row++)
            {
                for (int stabl = 0; stabl <= stablesCount - 1; stabl++)
                {
                    dist[row, stabl] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine($"There is the {rowsCount}x{stablesCount} matrix from the elements you have just initialised.");

            for (int i = 0; i <= rowsCount - 1; i++)
            {
                for (int j = 0; j <= stablesCount - 1; j++)
                {
                    Console.Write(dist[i,j] + " ");
                }
                Console.WriteLine();
            }
            
            if (rowsCount == 2 && stablesCount == 2)
            {
                value = twoD(dist);
                Console.WriteLine($"And its value is {value}");
            }
                
                else if (rowsCount == 3 && stablesCount == 3)
                {
                    value = threeD(dist);
                    Console.WriteLine($"And its value is {value}");
                }

                    else Console.WriteLine("We cannot calculate your matrix, but maybe soon we will can. :)");
        }

        private static double twoD(double[,] matrix)
        {
            double value = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            return value;
        }

        private static double threeD(double[,] matrix)
        {
            double value = (matrix[0,0] * matrix[1,1] * matrix[2,2]) + (matrix[0,1] * matrix[1,2] * matrix[2,0]) + (matrix[0,2] * matrix[1,0] * matrix[2,1]) - (matrix[0,2] * matrix[1,1] * matrix[2,0]) - (matrix[0,0] * matrix[1,2] * matrix[2,1]) - (matrix[0,1] * matrix[1,0] * matrix[2,2]);
            return value;
        }
    }
}


