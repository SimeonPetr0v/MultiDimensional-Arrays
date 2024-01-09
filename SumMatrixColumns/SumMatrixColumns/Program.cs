namespace SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size[1]; col++)
                    matrix[row, col] = elements[col];
            }

            for (int col = 0; col < size[1]; col++)
            {
                int colSum = 0;

                for (int row = 0; row < size[0]; row++)
                    colSum += matrix[row, col];

                Console.WriteLine(colSum);
            }
        }
    }
}