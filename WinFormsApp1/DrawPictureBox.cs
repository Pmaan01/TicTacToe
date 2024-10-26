using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class DrawPictureBox : PictureBox
    {
        public Font font { get; set; } // This property will be set externally.
        protected override void OnPaint(PaintEventArgs pe)
        {
            //Getting font from properties_click
            Font xfont = Form1.Xfont;
            Font yfont = Form1.Ofont;

            if (this.Tag != "X")
                font = xfont;
            else { font = yfont; }
            base.OnPaint(pe);

            // Draw "X" or "O" based on the Tag property
            if (this.Tag != null)
            {
                string text = this.Tag.ToString();

                // Use the provided 'font' or default to Arial if not set
                Font currentFont = font;

                // Center the text in the PictureBox
                SizeF textSize = pe.Graphics.MeasureString(text, currentFont);
                pe.Graphics.DrawString(text, currentFont, Brushes.Black,
                    new PointF((Width - textSize.Width) / 2, (Height - textSize.Height) / 2));
            }
        }
    }

}
