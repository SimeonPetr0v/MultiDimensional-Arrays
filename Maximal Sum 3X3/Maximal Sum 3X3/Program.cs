namespace Maximal_Sum_3X3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
            
            int[,] matrix = new int[size[0], size[1]];
            int[,] highest = new int[3, 3];
            int biggestSum = int.MinValue;

            for (int row = 0; row < size[0]; row++)
            {
                int[] element = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
                
                for (int col = 0; col < size[1]; col++)
                    matrix[row, col] = element[col];
            }

            for (int row = 0; row < size[0] - 2; row++)
            {
                for (int col = 0; col < size[1] - 2; col++)
                {
                    
                    int[,] secondMatrix = SecondMatrix(matrix, row, col);
                    int sum = 0;
                    foreach (int n in secondMatrix)
                        sum += n;

                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        highest = secondMatrix;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{highest[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] SecondMatrix(int[,] matrix, int row, int col)
        {
            int[,] subMatrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    subMatrix[i, j] = matrix[row + i, col + j];
                }
            }

            return subMatrix;
        }
    }
}