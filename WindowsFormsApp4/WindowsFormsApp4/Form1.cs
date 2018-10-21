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
    public partial class Form1 : Form
    {
       // KindOfCanvas CreateCanvas();
         //KindOfBrush CreateBrush();

        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SquereCan squereCan = new SquereCan();
        private void rectangularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (squereCan.newForm == null)
            {
                squereCan.newForm = new Form3();
                squereCan.newForm.MdiParent = this;
                squereCan.newForm.FormClosed += new FormClosedEventHandler(recCan_FormCloseEventHandler);
             
            }
            else
                squereCan.newForm.Activate();

            squereCan.active(squereCan);


        }
        CircleCan circleCan = new CircleCan();
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CircleCan circleCan = new CircleCan();



            if (circleCan.newForm == null)
            {
                circleCan.newForm = new Form2();
                circleCan.newForm.MdiParent = this;
                circleCan.newForm.FormClosed += new FormClosedEventHandler(recCan_FormCloseEventHandler);
                circleCan.SetName();
                circleCan.newForm.Show();
            }
            else
                circleCan.newForm.Activate();

            
        }

        


        public void recCan_FormCloseEventHandler(object sender, FormClosedEventArgs e)
        {
            circleCan.newForm = null;
        }
    }
}
