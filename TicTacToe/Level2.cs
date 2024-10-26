
using System;

namespace TicTacToe
{
    // This class implements Level 2 difficulty for the Tic-Tac-Toe game,
    // where the computer looks ahead to determine its best move.
    public class Level2 : IDifficulty
    {

        private Random rand = new Random();// Create a random number generator for move selection
        private const int Computer = -1;
        private const int User = 1;
        public void SelectMove(int[] board)
        {

            // Step 1: Check for blocking move first if user is about to win
            int blockMove = TicTacToeHelper.BlockUserWin(board);
            if (blockMove != -1)
            {
                // Block the user's winning move
                board[blockMove] = Computer;
                return; // Exit the function after blocking
            }

            // Dictionary to store the outcome scores for each move
            Dictionary<int, int> moveScores = new Dictionary<int, int>();
             

            // Step 2: Evaluate each possible move (depth 1)
            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0) // Empty space
                {
                    //computer's move
                    board[i] = Computer;

                    // Step 3: Evaluate all user responses
                    int score = EvaluateResponses(board, 1, dynamicDepth(board));

                    // Store the score for this move
                    moveScores[i] = score;

                    // Undo the move
                    board[i] = 0;
                }
            }

            // Step 4: Find the best move (highest score)
            int bestMove = -1;
            int bestScore = int.MinValue;

            // Loop through the move scores to find the best move
            foreach (var move in moveScores)
            {
                if (move.Value > bestScore)  // Check if the current move has a better score
                {
                    bestScore = move.Value;// Update best score
                    bestMove = move.Key;// Update best move

                }
            }

            // If multiple moves have the same score, pick randomly
            List<int> bestMoves = new List<int>();
            foreach (var move in moveScores)
            {
                if (move.Value == bestScore)// Check for moves with the best score
                {
                    bestMoves.Add(move.Key);// Add to the list of best moves
                }
            }

            // Pick a random move from the best ones
            if (bestMoves.Count > 0)
            {
                bestMove = bestMoves[rand.Next(bestMoves.Count)];
            }

            // Make the best move
            board[bestMove] = Computer;
        }

        // Sets the evaluation depth for computer.
        // Increases depth as the game nears the end.
        // Returns a fallback depth if no specific conditions are met.
        private int dynamicDepth(int[] board)
        {
            int emptySpaces = 0;
            // Count empty spaces on the board
            foreach (int space in board)
            {
                if (space == 0)
                    emptySpaces++;
            }

            // Determine depth based on the number of empty spaces and game state
            if (emptySpaces >= 5)
            {
                return 3; // Normal depth for the beginning of the game
            }
            else if (emptySpaces == 4)
            {
                return 4; // Slightly deeper for crucial mid-game
            }
            else if (emptySpaces <= 3)
            {
                return 5; // Increase depth for late-game scenarios
            }

            return 2; // Default depth
        }

        // This helper function checks possible moves for both the computer and the user.
        // Initially, I used nested loops to look deeper into the game, but this made the code 
        // complicated and difficult to manage. Then, I realized that recursion could simplify 
        // the process.
        // EvaluateResponses assesses the possible outcomes of the game based on the current player's turn.
        // It recursively simulates moves and calculates scores to determine the best possible strategy.
        // The function returns:
        // - +10 if the computer wins
        // - -10 if the user wins
        // - 0 if the game is a tie or depth limit is reached
        // 
        // Parameters:
        // - board: The current state of the Tic-Tac-Toe board as an array.
        // - currentPlayer: The player whose turn it is (1 for User, -1 for Computer).
        // - depth: The remaining depth for the recursive search, limiting how far ahead to evaluate.
        private int EvaluateResponses(int[] board, int currentPlayer, int depth)
        {

            // Check if the current player has already won
            if (TicTacToeHelper.checkWin(board, currentPlayer))
            {
                if (currentPlayer == -1)
                {
                    return 10; // Return +10 if the computer wins
                }
                else
                {
                    return -10; // Return -10 if the user wins
                }
            }

            // If no more depth or the board is full, terminate recursion.
            if (TicTacToeHelper.isBoardFull(board) || depth == 0)
            {
                return 0; // A tie or depth limit reached, no advantage for either player
            }

            int bestScore = (currentPlayer == Computer) ? int.MinValue : int.MaxValue; // Initialize bestScore based on the current player

            for (int i = 0; i < 9; i++)
            {
                if (board[i] == 0) // Empty cell
                {
                    // Simulate the move
                    board[i] = currentPlayer;

                    // Recursively evaluate the responses of the next player
                    int responseScore = EvaluateResponses(board, -currentPlayer, dynamicDepth(board) - 1);

                    // Update the best score
                    if (currentPlayer == Computer)
                    {
                        bestScore = Math.Max(bestScore, responseScore); // Maximize score for computer
                    }
                    else
                    {
                        bestScore = Math.Min(bestScore, responseScore); // Minimize score for user
                    }

                    // Undo the move
                    board[i] = 0;
                }
            }

            return bestScore; // Return the best score found based on the current player
        }
    }
  
}