namespace _2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            int equal = 0;

            for (int row = 0; row < size[0]; row++)
            {
                char[] element = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < size[1]; col++)
                    matrix[row, col] = element[col];
            }

            for (int element = 0; element < size[0] - 1; element++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    char curChar = matrix[element, col];

                    if (matrix[element + 1, col] == curChar && matrix[element, col + 1] == curChar && matrix[element + 1, col + 1] == curChar)
                        equal++;
                }
            }

            Console.WriteLine(equal);
        }
    }
}