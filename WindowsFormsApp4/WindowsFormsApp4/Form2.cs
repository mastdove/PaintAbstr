using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        Color currentColor = Color.Black;
        bool ispressed = false;
        Point currentPoint;
        Point PrevPoint;
        Graphics g;
        int size = 5;
        public Form2()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
                Rectangle rect = new Rectangle(0, 0, 320, 320);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(rect);
                Region region = new Region(path);
                pictureBox1.Region = region;
              return;
  
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


            p.StartCap = LineCap.RoundAnchor;
            p.EndCap = LineCap.RoundAnchor;
            g.DrawLine(p, PrevPoint, currentPoint);


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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ispressed = false;
        }
        float x, y;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }
    }
}
