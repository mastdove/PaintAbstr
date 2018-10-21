using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    abstract class AbstractFactory
    {
        public abstract KindOfCanvas CreateCanvas();
        public abstract KindOfBrush CreateBrush();
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override KindOfCanvas CreateCanvas()
        {
            return new CircleCan();
        }


        public override KindOfBrush CreateBrush()
        {
            return new CircleBrush();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override KindOfCanvas CreateCanvas()
        {
            return new SquereCan();
        }


        public override KindOfBrush CreateBrush()
        {
            return new SquereBrush();
        }
    }

    abstract class KindOfCanvas
    {
        public abstract void SetName();

    }

    abstract class KindOfBrush
    {
        public Pen p;
        public abstract void SetBrush();

    }

    class CircleCan : KindOfCanvas
    {
        public Form2 newForm;

        public override void SetName()
        {
            newForm.Text = "Circle";
           
        }
    }

    class CircleBrush : KindOfBrush
    {
       static Color currentColor = Color.Black;
        static int size = 5;
        Pen p = new Pen(currentColor, size);

        public override void SetBrush()
        {
            
            //throw new NotImplementedException();
        }
    }

    class SquereCan : KindOfCanvas
    {
        public Form3 newForm;


        public override void SetName()
        {
            newForm.Text = "Squere";

        }
        SquereBrush squereBrush = new SquereBrush();

         public void active( SquereCan squereCan)
        {
            

                squereCan.SetName();
                squereCan.newForm.Show();
            
        } 

    }

    class SquereBrush : KindOfBrush
    {
         static Color currentColor = Color.Black;

         static int size = 5;

        public override void SetBrush()
        {
            //throw new NotImplementedException();
        }
    }

    
}   

