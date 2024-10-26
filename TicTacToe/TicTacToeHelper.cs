using System;

namespace TicTacToe
{
    // The TicTacToeHelper class includes helpful methods for playing a Tic-Tac-Toe game. 
    // It has functions to check if a player has won, see if the board is full, handle the 
    // player's move, and display the current game board. It also checks if the game is over 
    // and announces the winner or if the game is a tie. This class makes it easier to manage 
    // the game and keeps the main code clean and easy to understand.
    public static class TicTacToeHelper
    {
        // This method checks if the specified player has won the game.
        public static bool checkWin(int[] board, int player)
        {
            int[][] winPatterns = {
            new int[] {0, 1, 2}, new int[] {3, 4, 5}, new int[] {6, 7, 8}, // Rows
            new int[] {0, 3, 6}, new int[] {1, 4, 7}, new int[] {2, 5, 8}, // Columns
            new int[] {0, 4, 8}, new int[] {2, 4, 6}  // Diagonals
        };
            // Check each winning pattern to see if the player occupies all three positions.
            foreach (int[] pattern in winPatterns)
            {
                if (board[pattern[0]] == player && board[pattern[1]] == player && board[pattern[2]] == player)// checking if position is occupied by same player 
                {
                    return true;// Player has won
                }
            }
            return false;//// No win found
        }

        //Check if board is empty
        public static bool isBoardFull(int[] board)
        {
            // Loop through the board to find any empty spaces.
            foreach (int space in board)
            {
                if (space == 0)
                    return false;
            }
            return true;
        }

        // Method for handling user's move
        public static void userMove(int[] board)
        {
            int move;
            bool validMove = false;

            // Keep asking for a valid move until the user provides one.
            do
            {
                Console.WriteLine("Next Move (0-8): ");
                if (int.TryParse(Console.ReadLine(), out move) && move >= 0 && move < 9 && board[move] == 0)
                {
                    board[move] = 1; // User is X
                    validMove = true; // Move is valid
                }
                else
                {
                    Console.WriteLine("Incorrect Move. Try Again:");
                }
            } while (!validMove);
        }
        //Method to block user from Winning
        public static int BlockUserWin(int[] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0) // Empty cell
                {
                    // Simulate the user's move
                    board[i] = 1;

                    // Check if the user would win with this move
                    if (checkWin(board, 1))
                    {
                        // Undo the move and return the position to block
                        board[i] = 0;
                        return i; // Return index to block
                    }

                    // Undo the move
                    board[i] = 0;
                }
            }

            return -1; // No blocking move found
        }

        // Method for displaying the current board state
        public static void displayBoard(int[] board)
        {
            Console.WriteLine("Current Board:");
            for (int i = 0; i < 9; i += 3)
            {
                // Display each row of the board.
                Console.WriteLine($" {getSymbol(board[i])} | {getSymbol(board[i + 1])} | {getSymbol(board[i + 2])} ");
                if (i < 6) 
                {
                    Console.WriteLine("---|---|---"); // Line between rows
                }
            }
            Console.WriteLine();
        }

        //To get symbol
        public static char getSymbol(int value)
        {
            if (value == 1) return 'X'; // User's move
            if (value == -1) return 'O'; // Computer's move
            return ' '; // Empty cell
        }

        // Method for checking if the game is over
        public static bool GameOver(int[] board)
        {
            // Check for a win for either player or if the board is full.
            return checkWin(board, 1) || checkWin(board, -1) || isBoardFull(board);
        }

        // Method for announcing the game result
        public static void AnnounceResult(int[] board)
        {
            // Determine the outcome of the game and display it.
            if (checkWin(board, 1))
            {
                Console.WriteLine("User Won!");
            }
            else if (checkWin(board, -1))
            {
                Console.WriteLine("Computer Won!");
            }
            else
            {
                Console.WriteLine("It's a Tie!");
            }
        }
    }

}
