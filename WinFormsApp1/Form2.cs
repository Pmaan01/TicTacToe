using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Color BoardColor { get; private set; }
        public Color FormColor { get; private set; }
        public Font XFont { get; private set; }
        public Font OFont { get; private set; }

        public Form2()
        {
            InitializeComponent();
            // Set default colors and fonts
            BoardColor = Color.White;
            FormColor = Color.Black;
            XFont = new Font("Arial", 24);
            OFont = new Font("Arial", 24);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Indicate OK was clicked
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    FormColor = colorDialog.Color; // Update FormColor property
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    XFont = fontDialog.Font; // Update XFont property
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    BoardColor = colorDialog.Color; // Update BoardColor property
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    OFont = fontDialog.Font; // Update OFont property
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form or dialog

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  // Set dialog result to OK when the user confirms
            this.Close();
        }
    }
}
