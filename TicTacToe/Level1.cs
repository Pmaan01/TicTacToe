using System;

namespace TicTacToe
{
    // This class implements the Level 1 difficulty for the Tic-Tac-Toe game.
    // The computer will either try to win or block the user from winning.
    public class Level1 : IDifficulty
    {
        private Random rand = new Random();

        public void SelectMove(int[] board) // Method to select the next move
        {
            // Check for a winning move or blocking move
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0) // Check if the space is empty
                {
                    // Try to win
                    board[i] = -1; // Place the computer's move

                    if (TicTacToeHelper.checkWin(board, -1)) // Check if this move wins
                    {
                        return; // If the computer can win, make the move and exit
                    }
                    board[i] = 0; // Undo the move if it doesn't win

                    // Try to block user
                    int blockMove = TicTacToeHelper.BlockUserWin(board);

                    if (blockMove != -1) // If a blocking move is found
                    {
                        board[blockMove] = -1; // Block the user's winning move
                        return; // Exit the function after blocking
                    }
                }
            }

            // If no winning or blocking move is found, move randomly
            int move;
            do
            {
                move = rand.Next(0, 9); // Generate a random number between 0 and 8
            }
            while (board[move] != 0); // Continue until a free cell (0) is found

            board[move] = -1; // Make the random move
        }
    }
}
