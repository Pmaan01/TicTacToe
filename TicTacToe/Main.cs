using System;
using TicTacToe;

class Program
{
    // This program is a Tic-Tac-Toe game where a user plays against a computer. 
    // The user can choose to start the game or let the computer start. 
    // They can also pick how hard they want the game to be. 
    // The game goes on until someone wins or it ends in a tie.

    static int[] board = new int[9]; // Array representing the Tic-Tac-Toe board (0 = free, 1 = user, -1 = computer)

    public static void Main(string[] args)
    {
        do
        {
            int difficulty; // Variable to hold the difficulty level
            char startPlayer; // Starting player variable

            // Loop for starting player input
            while (true)
            {
                Console.WriteLine("Starting Player (c/u):");
                startPlayer = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine(); // Move to the next line after input

                if (startPlayer == 'c' || startPlayer == 'u')
                {
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'c' for computer or 'u' for user.");
                }
            }

            while (true) // Infinite loop until a valid input is received
            {
                Console.WriteLine("\nDifficulty Level (0/1/2):");
                string input = Console.ReadLine(); // Read user input

                // Check if the input is valid
                if (input == "0" || input == "1" || input == "2")
                {
                    difficulty = int.Parse(input); // Parse the input and store it in the difficulty variable
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid input. Choose again.");
                }
            }

            // Create an instance of IDifficulty
            IDifficulty computer;

            // Assigning the correct difficulty level
            switch (difficulty)
            {
                case 0:
                    computer = new Level0();
                    break;
                case 1:
                    computer = new Level1();
                    break;
                case 2:
                    computer = new Level2();
                    break;
                default:
                    computer = new Level0();
                    break;
            }

            // Gaming loop
            do
            {
                // Check if the user starts the game
                if (startPlayer == 'u')
                {
                    // User makes their move
                    TicTacToeHelper.userMove(board);

                    // After the user's move, check if the game is over
                    if (TicTacToeHelper.GameOver(board))
                    {
                        // If the game is over, display the final board
                        TicTacToeHelper.displayBoard(board);
                        // Exit the loop
                        break;
                    }

                    // If the game is not over, let the computer make its move
                    computer.SelectMove(board);
                }
                else // Computer starts the game
                {
                    // Computer makes its move first
                    computer.SelectMove(board);

                    // After the computer's move, check if the game is over
                    if (TicTacToeHelper.GameOver(board))
                    {
                        // If the game is over, display the final board
                        TicTacToeHelper.displayBoard(board);
                        // Exit the loop, as the game has ended
                        break;
                    }

                    // If the game is not over, it's now the user's turn to make a move
                    TicTacToeHelper.userMove(board);
                }

                // After each round (both user and computer moves), display the current state of the board
                TicTacToeHelper.displayBoard(board);

            } while (!TicTacToeHelper.GameOver(board)); // Keep looping as long as the game isn't over

            // Once the game is over, announce the result (win, lose, or draw)
            TicTacToeHelper.AnnounceResult(board);

            Console.WriteLine("Do you want to play again? 'Y' for Yes, 'N' for No: ");
            char response = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Check if the user wants to play again
            if (response != 'Y')
            {
                break; // Exit the main game loop if the user doesn't want to play again
            }

            // Reset the board for a new game
            Array.Clear(board, 0, board.Length); // Clear the board

        } while (true);
    }
}
