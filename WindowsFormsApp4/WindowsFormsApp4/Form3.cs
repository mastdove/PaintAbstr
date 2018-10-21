using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        Color currentColor = Color.Black;
        bool ispressed = false;
        Point currentPoint;
        Point PrevPoint;
        Graphics g;
        int size = 5;
        public Form3()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = colorDialog1.Color;

            }
        }
        private void for_paint()
        {
            size = Convert.ToInt32(textBox1.Text);
            Pen p = new Pen(currentColor, size);
            g.DrawRectangle(p, currentPoint.X, currentPoint.Y, size, size);



        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ispressed = true;
            currentPoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ispressed)
            {
                PrevPoint = currentPoint;
                currentPoint = e.Location;
                x = e.Location.X;
                y = e.Location.Y;
                for_paint();

            }
        }
        float x, y;

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ispressed = false;
        }
    }
}
