using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = ['.', '.', '.', '.', '.', '.', '.', '.', '.'];
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            PlayGame();     
        }

        static void PlayGame() {
            PrintBoard(board);
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0) {
                    AskMove('1');
                } else {
                    AskMove('2');
                }
                PrintBoard(board);
                if (checkWinner())
                {
                    Console.WriteLine("Player {0} wins!", i % 2 == 0 ? '1' : '2');
                    PlayAgain();
                }
                if (i == 8)
                {
                    Console.WriteLine("It's a draw!");
                    PlayAgain();
                }
            }
        }

        static void AskMove(char player) {
            Console.WriteLine("Player {0}, please enter your move (1-9): ", player);
            bool isNumber = Int32.TryParse(Console.ReadLine(), out int move);

            if (checkIfValidMove(isNumber, move)) {
                board[move-1] = player == '1' ? 'X' : 'O';
            } else {
                PlayGame();
            }
        }

        static bool checkIfValidMove(bool isNumber, int move) {
            if (!isNumber || move < 1 || move > 9 || board[move-1] != '.' )
            {
                Console.WriteLine("Invalid input, please try again.");
                return false;
            }
            return true;
        }

        static void PrintBoard(char[] board)
        {
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("|"+board[i]);
                if (i % 3 == 2)
                {
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
        }

        static bool checkWinner() {
            // 012, 345, 678, 036, 147, 258, 048, 246 are winners
            int[][] winnerIndexes = new int[][] { 
                new int[] {0, 1, 2}, new int[] {3, 4, 5}, new int[] {6, 7, 8}, new int[] {0, 3, 6}, new int[] {1, 4, 7}, new int[] {2, 5, 8}, new int[] {0, 4, 8}, new int[] {2, 4, 6} };
            for (int i = 0; i < 8; i++)
            {
                if (board[winnerIndexes[i][0]] != '.' && 
                    board[winnerIndexes[i][0]] == board[winnerIndexes[i][1]] && 
                    board[winnerIndexes[i][1]] == board[winnerIndexes[i][2]])
                {
                    return true;
                }
            }
            return false;
        }

        static void PlayAgain() {
            Console.WriteLine("Do you want to play again? (y/n):");
            string playAgain = Console.ReadLine();
            if (playAgain == "y")
            {
                board = ['.', '.', '.', '.', '.', '.', '.', '.', '.'];
                PlayGame();
            } else {
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }
        }
    }
}