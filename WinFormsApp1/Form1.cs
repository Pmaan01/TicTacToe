using TicTacToe;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Game board represented as an array
        static int[] board = new int[9];
        string level; // Difficulty level
        IDifficulty computer; // Computer player
        private DrawPictureBox[] drawPictureBoxes = new DrawPictureBox[9]; // Array to hold PictureBox controls
        private Image[] pictureBoxImages = new Image[9]; // Array to hold initial images of PictureBoxes
        bool userplayer = false; // Determines who starts the game
        // Create an instance of the settings form
        static Form2 settingsForm = new Form2();
        public static Font Xfont = settingsForm.XFont;
        public static Font Ofont = settingsForm.OFont;

        public Form1()
        {
            InitializeComponent();
            InitializePictureBoxes(); // Initialize PictureBox controls
            InitializeGameState(); // Set up the initial game state
            UnselectRadioButtons(); // Unselect radio buttons for difficulty
        }

        // Unselects all radio buttons and sets the default difficulty to hard
        private void UnselectRadioButtons()
        {
            hard.Checked = true; // Default to hard difficulty
        }

        // Initializes the PictureBox controls and their event handlers
        private void InitializePictureBoxes()
        {
            // Assign PictureBox controls to the array
            drawPictureBoxes[0] = pictureBox1;
            drawPictureBoxes[1] = pictureBox2;
            drawPictureBoxes[2] = pictureBox3;
            drawPictureBoxes[3] = pictureBox4;
            drawPictureBoxes[4] = pictureBox5;
            drawPictureBoxes[5] = pictureBox6;
            drawPictureBoxes[6] = pictureBox7;
            drawPictureBoxes[7] = pictureBox8;
            drawPictureBoxes[8] = pictureBox9;

            // Store initial images and add click event handlers
            for (int i = 0; i < drawPictureBoxes.Length; i++)
            {
                pictureBoxImages[i] = drawPictureBoxes[i].Image; // Store initial images
             
            }
        }

        // Initializes the game state and asks the user who starts
        private void InitializeGameState()
        {
            // Ask the user if they want to start the game
            DialogResult result = MessageBox.Show("Do you want to start the game? 'Yes' for User to Start First 'No' for computer to make first move.", "Start Game", MessageBoxButtons.YesNo);
           
            // Set userplayer based on user choice
            userplayer = (result == DialogResult.Yes);

            // Initialize the game
            InitializeGame();
            Array.Fill(board, 0); // Reset the board to empty (all 0)
        }

        // Handles PictureBox clicks for user moves
        private void pictureBox_Click(object sender, EventArgs e)
        {
            DrawPictureBox clickedPictureBox = sender as DrawPictureBox;

            // Check if the game is over or the clicked PictureBox is already occupied
            if (TicTacToeHelper.GameOver(board) || clickedPictureBox.Tag != null) return;

            int index = Array.IndexOf(drawPictureBoxes, clickedPictureBox);
            clickedPictureBox.Image = null; // Clear the image for the user's move
            if (index == -1) return;

            // User's move
            board[index] = 1; // Mark the move on the board
            clickedPictureBox.Tag = "X"; // Set tag to indicate user move
            clickedPictureBox.Invalidate(); // Redraw the PictureBox

            // Check if the game is over after the user's move
            if (CheckGameOver()) return;

            // If it's not the user's turn and the computer exists, make the computer move
            if (!userplayer && computer != null)
            {
                computer.SelectMove(board); // Computer makes a move
                UpdateBoardUI(); // Update the UI to reflect the move
                CheckGameOver(); // Check if the game is over
            }
            else if (userplayer && computer != null)
            {
                // After the user moves, the computer should make a move
                computer.SelectMove(board);
                UpdateBoardUI();
                CheckGameOver();
            }
        }

        // Checks if the game is over and shows the result
        private bool CheckGameOver()
        {
            if (TicTacToeHelper.GameOver(board))
            {
                TicTacToeHelper.AnnounceResult(board); // Announce the result
                if (TicTacToeHelper.checkWin(board, 1))
                    MessageBox.Show("Congrats: User Won.");
                else if (TicTacToeHelper.checkWin(board, -1))
                {
                    UpdateBoardUI();
                    MessageBox.Show("Computer won!");
                }
                else
                    MessageBox.Show("It's a Tie!!"); // Announce a tie
                return true; // Game is over
            }
            return false; // Game is still ongoing
        }

        // Handles difficulty selection
        private void easy_CheckedChanged(object sender, EventArgs e) => SetDifficulty("easy");
        private void medium_CheckedChanged(object sender, EventArgs e) => SetDifficulty("medium");
        private void hard_CheckedChanged(object sender, EventArgs e) => SetDifficulty("hard");

        // Sets the difficulty level and initializes the computer player
        private void SetDifficulty(string difficultyLevel)
        {
            level = difficultyLevel; // Set the difficulty level

            // Using if-else to set the difficulty level
            if (level == "easy")
            {
                computer = new Level0(); // Easy level
            }
            else if (level == "medium")
            {
                computer = new Level1(); // Medium level
            }
            else
            {
                computer = new Level2(); // Hard level
            }

            // If it's the computer's turn, make a move
            if (!TicTacToeHelper.GameOver(board) && CountMoves(-1) < CountMoves(1))
            {
                computer.SelectMove(board); // Computer makes a move
                UpdateBoardUI(); // Update the UI
            }
        }

        // Counts the number of moves made by the user or computer
        private int CountMoves(int player)
        {
            int count = 0;
            foreach (int move in board)
            {
                if (move == player) count++; // Count moves for the specified player
            }
            return count; // Return the count
        }

        // Starts a new game when the 'New' button is clicked
        private void Newgame_Click(object sender, EventArgs e)
        {
            // Ask the user if they want to start the game
            DialogResult result = MessageBox.Show("Do you want to start the game?", "Start Game", MessageBoxButtons.YesNo);

            // Set userplayer based on user choice
            userplayer = (result == DialogResult.Yes);

            // Initialize the game
            InitializeGame();
        }

        // Initializes the game based on who starts
        private void InitializeGame()
        {
            ResetBoardState(); // Reset the board state
            if (!userplayer) // If the computer starts
            {
                SetDifficulty(level); // Set the difficulty level
                computer.SelectMove(board); // Computer makes a move
                UpdateBoardUI(); // Update the UI
            }
        }

        // Resets the board state for a new game
        private void ResetBoardState()
        {
            Array.Fill(board, 0); // Reset the board to empty
            for (int i = 0; i < drawPictureBoxes.Length; i++)
            {
                drawPictureBoxes[i].Image = pictureBoxImages[i]; // Restore initial images
                drawPictureBoxes[i].Tag = null; // Clear tags
                drawPictureBoxes[i].Invalidate(); // Redraw PictureBoxes
            }
        }

        // Resets the game when the 'Restart' button is clicked
        private void Restart_Click(object sender, EventArgs e)
        {
            ResetBoardState(); // Reset the board state
            UnselectRadioButtons(); // Unselect difficulty radio buttons
        }

        // Updates the board UI after moves
        private void UpdateBoardUI()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == 1 && drawPictureBoxes[i].Tag == null) // User move
                {
                    drawPictureBoxes[i].Tag = "X"; // Set tag for user move
                    drawPictureBoxes[i].Invalidate(); // Redraw PictureBox
                }
                else if (board[i] == -1 && drawPictureBoxes[i].Tag == null) // Computer move
                {
                    drawPictureBoxes[i].Image = null; // Clear image for computer move
                    drawPictureBoxes[i].Tag = "O"; // Set tag for computer move
                    drawPictureBoxes[i].Invalidate(); // Redraw PictureBox
                }
            }
        }

        // Opens the settings form to change properties
        // Opens the settings form to change properties
        private void properties_Click(object sender, EventArgs e)
        {
            // Show the settings form as a dialog and check if the user clicked OK
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                // Apply the selected background color to the main form
                this.BackColor = settingsForm.FormColor;
                this.Refresh(); // Refresh the main form to apply the new background color

                // Apply the selected board color to the panel
                panel1.BackColor = settingsForm.BoardColor;
                panel1.Refresh(); // Refresh the panel to apply the new board color
                Xfont = settingsForm.XFont;
                Ofont = settingsForm.OFont;
            }
        }
    
    

        // Handles player selection - computer starts
        private void Computer_CheckedChanged(object sender, EventArgs e)
        {
            userplayer = false; // Set to false indicating computer starts
            StartGame(); // Start the game
        }

        // Handles player selection - user starts
        private void User_CheckedChanged(object sender, EventArgs e)
        {
            userplayer = true; // Set to true indicating user starts
            StartGame(); // Start the game
        }

        // Starts the game after player selection
        private void StartGame()
        {
            InitializeGame(); // Initialize the game state
        }

        // Provides a hint by letting the computer make a move
        private void Hint_Click(object sender, EventArgs e)
        {
            userplayer = true; // Set userplayer to true for the hint

            // Step 1: Check if the game is still ongoing and it's the user's turn
            if (!TicTacToeHelper.GameOver(board) && userplayer)
            {
                // Set the difficulty to "hard" (Level 2) for the computer
                SetDifficulty("hard");

                // Create a copy of the board to simulate the computer's hint move without altering the original board
                int[] boardCopy = (int[])board.Clone();

                // Step 2: Let the computer simulate a move on the copied board
                computer.SelectMove(boardCopy); // Computer selects a hint move for the user

                // Step 3: Find the index where the computer made the hint move
                int hintMove = -1;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == 0 && boardCopy[i] == -1) // Check where the hint move was made by the computer
                    {
                        hintMove = i;
                        break; // Exit once the move is found
                    }
                }

                // Step 4: If a valid hint move was found, mark it as a suggested move for the user
                if (hintMove != -1)
                {
                    board[hintMove] = 1; // Make the user's move (X) at the suggested spot
                    drawPictureBoxes[hintMove].Image = null; // Clear any existing image for the hint
                    drawPictureBoxes[hintMove].Tag = "X"; // Set the tag as X for the user
                    drawPictureBoxes[hintMove].Invalidate(); // Redraw the PictureBox with X
                    drawPictureBoxes[hintMove].BackColor = Color.Green; // Highlight the hint move
                }

                // Step 5: Update the board UI to reflect the user's move
                UpdateBoardUI();

                // Step 6: Check if the game is over after the user's "hinted" move
                if (!CheckGameOver())
                {
                    // Step 7: Now let the computer make its own move on the real board
                    computer.SelectMove(board); // Let the computer make a real move

                    // Update the board UI again to reflect the computer's move
                    UpdateBoardUI();

                    // Step 8: Check if the game is over after the computer's move
                    if (!CheckGameOver())
                    {
                        // Switch turns back to the user
                        userplayer = true;
                    }
                    else
                    {
                        userplayer = false; // Game is over, no more moves
                    }
                }
            }
            else
            {
                // Optionally, show a message if the game is over or it's not the user's turn
                MessageBox.Show("It's not your turn or the game is already over!");
            }

        }
    }
}