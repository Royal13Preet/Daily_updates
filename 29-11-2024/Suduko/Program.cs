using System;

namespace Sudoku
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] board = new int[9, 9];
            GenerateSudoku(board);
            Console.WriteLine("Sudoku Puzzle:");
            DisplayBoard(board);

            while (true)
            {
                Console.WriteLine("Enter your move in the format 'row col num' (e.g., 1 1 5) or 'q' to quit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }

                string[] parts = input.Split(' ');
                if (parts.Length != 3 || !int.TryParse(parts[0], out int row) || !int.TryParse(parts[1], out int col) || !int.TryParse(parts[2], out int num))
                {
                    Console.WriteLine("Invalid input. Please enter numbers in the format 'row col num'.");
                    continue;
                }

                row--; col--; // Convert to 0-based indexing

                if (row < 0 || row >= 9 || col < 0 || col >= 9 || num < 1 || num > 9)
                {
                    Console.WriteLine("Invalid move. Please enter numbers between 1 and 9.");
                    continue;
                }

                if (board[row, col] != 0)
                {
                    Console.WriteLine("Cell is already filled. Try a different cell.");
                    continue;
                }

                var validationResult = IsValid(board, row, col, num);
                if (!validationResult.isValid)
                {
                    Console.WriteLine($"Invalid move: {validationResult.message}");
                    continue;
                }

                board[row, col] = num;
                DisplayBoard(board);

                if (IsBoardComplete(board))
                {
                    Console.WriteLine("Congratulations! You solved the Sudoku.");
                    break;
                }
            }
        }

        static void GenerateSudoku(int[,] board)
        {
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = 0;
                }
            }

            int filledCells = 20; // Number of cells to fill initially
            for (int count = 0; count < filledCells;)
            {
                int row = random.Next(0, 9);
                int col = random.Next(0, 9);
                int num = random.Next(1, 10);

                if (board[row, col] == 0 && IsValid(board, row, col, num).isValid)
                {
                    board[row, col] = num;
                    count++;
                }
            }
        }

        static (bool isValid, string message) IsValid(int[,] board, int row, int col, int num)
        {
            // Check row
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num)
                {
                    return (false, $"Number {num} already exists in row {row + 1}.");
                }
            }

            // Check column
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num)
                {
                    return (false, $"Number {num} already exists in column {col + 1}.");
                }
            }

            // Check 3x3 grid
            int gridRowStart = (row / 3) * 3;
            int gridColStart = (col / 3) * 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[gridRowStart + i, gridColStart + j] == num)
                    {
                        return (false, $"Number {num} already exists in the 3x3 grid starting at ({gridRowStart + 1}, {gridColStart + 1}).");
                    }
                }
            }

            return (true, "");
        }

        static bool IsBoardComplete(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void DisplayBoard(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                    {
                        Console.Write(". ");
                    }
                    else
                    {
                        // Highlight the filled numbers with a different color
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(board[i, j] + " ");
                        Console.ResetColor();
                    }

                    // Add vertical grid lines every 3 columns
                    if ((j + 1) % 3 == 0 && j != 8)
                    {
                        Console.Write("| ");
                    }
                }
                Console.WriteLine();

                // Add horizontal grid lines every 3 rows
                if ((i + 1) % 3 == 0 && i != 8)
                {
                    Console.WriteLine("---------------------");
                }
            }
        }
    }
}
