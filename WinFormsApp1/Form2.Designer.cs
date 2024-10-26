namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            colorDialog2 = new ColorDialog();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            fontDialog2 = new FontDialog();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(237, 46);
            button1.Name = "button1";
            button1.Size = new Size(266, 56);
            button1.TabIndex = 0;
            button1.Text = "Background Color";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkRed;
            button2.Location = new Point(237, 129);
            button2.Name = "button2";
            button2.Size = new Size(266, 56);
            button2.TabIndex = 1;
            button2.Text = "Font STyle O";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.DarkRed;
            button3.Location = new Point(237, 212);
            button3.Name = "button3";
            button3.Size = new Size(266, 56);
            button3.TabIndex = 2;
            button3.Text = "Board Color";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.DarkRed;
            button4.Location = new Point(237, 449);
            button4.Name = "button4";
            button4.Size = new Size(266, 56);
            button4.TabIndex = 3;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCyan;
            button5.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.DarkRed;
            button5.Location = new Point(237, 296);
            button5.Name = "button5";
            button5.Size = new Size(266, 56);
            button5.TabIndex = 4;
            button5.Text = "Font STyle X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightCyan;
            button6.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.DarkRed;
            button6.Location = new Point(237, 377);
            button6.Name = "button6";
            button6.Size = new Size(266, 56);
            button6.TabIndex = 5;
            button6.Text = "Save Changes";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_20_163927;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(763, 533);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MaximumSize = new Size(781, 580);
            MinimizeBox = false;
            MinimumSize = new Size(781, 580);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Properties";
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private FontDialog fontDialog2;
        private Button button6;
    }
}