namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Newgame = new Button();
            Restart = new Button();
            properties = new Button();
            difficulty = new GroupBox();
            medium = new RadioButton();
            hard = new RadioButton();
            easy = new RadioButton();
            panel1 = new Panel();
            pictureBox7 = new DrawPictureBox();
            pictureBox8 = new DrawPictureBox();
            pictureBox9 = new DrawPictureBox();
            pictureBox4 = new DrawPictureBox();
            pictureBox5 = new DrawPictureBox();
            pictureBox3 = new DrawPictureBox();
            pictureBox6 = new DrawPictureBox();
            pictureBox2 = new DrawPictureBox();
            pictureBox1 = new DrawPictureBox();
            Hint = new Button();
            label1 = new Label();
            label2 = new Label();
            difficulty.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Newgame
            // 
            Newgame.BackColor = Color.LightCyan;
            Newgame.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Newgame.ForeColor = Color.DarkRed;
            Newgame.Location = new Point(597, 332);
            Newgame.Name = "Newgame";
            Newgame.Size = new Size(149, 28);
            Newgame.TabIndex = 0;
            Newgame.Text = "New Game";
            Newgame.UseVisualStyleBackColor = false;
            Newgame.Click += Newgame_Click;
            // 
            // Restart
            // 
            Restart.BackColor = Color.LightCyan;
            Restart.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Restart.ForeColor = Color.DarkRed;
            Restart.Location = new Point(597, 367);
            Restart.Name = "Restart";
            Restart.Size = new Size(149, 28);
            Restart.TabIndex = 1;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = false;
            Restart.Click += Restart_Click;
            // 
            // properties
            // 
            properties.BackColor = Color.LightCyan;
            properties.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            properties.ForeColor = Color.DarkRed;
            properties.Location = new Point(597, 402);
            properties.Name = "properties";
            properties.Size = new Size(149, 28);
            properties.TabIndex = 2;
            properties.Text = "Properties";
            properties.UseVisualStyleBackColor = false;
            properties.Click += properties_Click;
            // 
            // difficulty
            // 
            difficulty.BackColor = Color.LightCyan;
            difficulty.Controls.Add(medium);
            difficulty.Controls.Add(hard);
            difficulty.Controls.Add(easy);
            difficulty.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            difficulty.ForeColor = Color.DarkRed;
            difficulty.Location = new Point(506, 54);
            difficulty.Name = "difficulty";
            difficulty.Size = new Size(332, 86);
            difficulty.TabIndex = 3;
            difficulty.TabStop = false;
            difficulty.Text = "Difficulity";
            // 
            // medium
            // 
            medium.AutoSize = true;
            medium.Location = new Point(110, 39);
            medium.Name = "medium";
            medium.Size = new Size(97, 22);
            medium.TabIndex = 2;
            medium.TabStop = true;
            medium.Text = "Medium";
            medium.UseVisualStyleBackColor = true;
            medium.CheckedChanged += medium_CheckedChanged;
            // 
            // hard
            // 
            hard.AutoSize = true;
            hard.Location = new Point(232, 39);
            hard.Name = "hard";
            hard.Size = new Size(75, 22);
            hard.TabIndex = 1;
            hard.TabStop = true;
            hard.Text = "Hard";
            hard.UseVisualStyleBackColor = true;
            hard.CheckedChanged += hard_CheckedChanged;
            // 
            // easy
            // 
            easy.AutoSize = true;
            easy.Location = new Point(6, 39);
            easy.Name = "easy";
            easy.Size = new Size(68, 22);
            easy.TabIndex = 0;
            easy.TabStop = true;
            easy.Text = "Easy";
            easy.UseVisualStyleBackColor = true;
            easy.CheckedChanged += easy_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(34, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 445);
            panel1.TabIndex = 4;
            // 
            // pictureBox7
            // 
            pictureBox7.font = new Font("Arial", 24F);
            pictureBox7.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox7.Location = new Point(27, 272);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(121, 127);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.font = new Font("Arial", 24F);
            pictureBox8.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox8.Location = new Point(154, 273);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(118, 127);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.font = new Font("Arial", 24F);
            pictureBox9.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox9.Location = new Point(278, 272);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(127, 127);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 6;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.font = new Font("Arial", 24F);
            pictureBox4.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox4.Location = new Point(27, 148);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(121, 125);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.font = new Font("Arial", 24F);
            pictureBox5.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox5.Location = new Point(154, 148);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(118, 125);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.font = new Font("Arial", 24F);
            pictureBox3.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox3.Location = new Point(278, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.font = new Font("Arial", 24F);
            pictureBox6.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox6.Location = new Point(278, 148);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(127, 125);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.font = new Font("Arial", 24F);
            pictureBox2.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox2.Location = new Point(154, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.font = new Font("Arial", 24F);
            pictureBox1.Image = Properties.Resources.Leonardo_Phoenix_Create_an_image_depicting_a_stylized_flip_but_0;
            pictureBox1.Location = new Point(27, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox_Click;
            // 
            // Hint
            // 
            Hint.BackColor = Color.LightCyan;
            Hint.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Hint.ForeColor = Color.DarkRed;
            Hint.Location = new Point(597, 436);
            Hint.Name = "Hint";
            Hint.Size = new Size(149, 33);
            Hint.TabIndex = 11;
            Hint.Text = "Hint";
            Hint.UseVisualStyleBackColor = false;
            Hint.Click += Hint_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(34, 54);
            label1.Name = "label1";
            label1.Size = new Size(388, 43);
            label1.TabIndex = 12;
            label1.Text = "Let's Play TicTacToe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(597, 280);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 13;
            label2.Text = "Main Menu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(882, 653);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Hint);
            Controls.Add(panel1);
            Controls.Add(difficulty);
            Controls.Add(properties);
            Controls.Add(Restart);
            Controls.Add(Newgame);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(900, 700);
            MinimizeBox = false;
            MinimumSize = new Size(900, 700);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            difficulty.ResumeLayout(false);
            difficulty.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Newgame;
        private Button Restart;
        private Button properties;
        private GroupBox difficulty;
        private RadioButton medium;
        private RadioButton hard;
        private RadioButton easy;
        protected Panel panel1;
        private Button Hint;
        private Label label1;
        private Label label2;
        private DrawPictureBox pictureBox7;
        private DrawPictureBox pictureBox8;
        private DrawPictureBox pictureBox9;
        private DrawPictureBox pictureBox4;
        private DrawPictureBox pictureBox5;
        private DrawPictureBox pictureBox6;
        private DrawPictureBox pictureBox3;
        private DrawPictureBox pictureBox2;
        private DrawPictureBox pictureBox1;
    }
}