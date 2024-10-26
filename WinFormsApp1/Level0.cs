using System;

namespace Assignment1
{

    // This class represents the easiest difficulty level for the Tic-Tac-Toe game.
    // The computer randomly selects its move without any strategy.
    public class Level0 : IDifficulty
    {
        //Chosing a random move
        public void SelectMove(int[] board)
        {
            Random rand = new Random();
            int move;
            do
            {
                // Generate a random number between 0 and 8
                move = rand.Next(0, 9);
            }
            while (board[move] != 0); // Continue until a free cell (0) is found
            board[move] = -1;
        }
    }
}
