namespace Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }

            }
            Console.WriteLine();
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col< matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach(int row in matrix)
            {
                Console.WriteLine(row);
            }
        }
    }
}