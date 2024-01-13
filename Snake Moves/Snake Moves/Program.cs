namespace Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string snake = Console.ReadLine();
            int pointer = 0;
            char[][] path = new char[size[0]][];

            
            for (int row = 0; row < size[0]; row++)
            
            {
                path[row] = new char[size[1]];
                for (int col = 0; col < size[1]; col++)
                {
                    path[row][col] = snake[pointer];

                    if (pointer == snake.Length - 1)
                    {
                        pointer = 0;
                    }
                    else
                    {
                        pointer++;
                    }
                }

                if (row % 2 != 0)
                {
                    path[row] = path[row]
                        .Reverse()
                        .ToArray();
                }
            }

            
            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    Console.Write(path[row][col]);
                }
               
                Console.WriteLine();
            }
        }
    }
}