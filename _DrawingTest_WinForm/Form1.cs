using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        int index;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

   
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            // Define transformation for container.
            Rectangle srcRect = new Rectangle(0, 0, 200, 200);
            Rectangle destRect = new Rectangle(100, 100, 150, 150);

            // Begin graphics container.
            GraphicsContainer containerState = e.Graphics.BeginContainer(
                destRect, srcRect,
                GraphicsUnit.Pixel);

            // Fill red rectangle in container.
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), 0, 0, 300, 200);

            // End graphics container.
            e.Graphics.EndContainer(containerState);

            // Fill untransformed rectangle with green.
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), 0, 0, 200, 200);

        }
    }
}
