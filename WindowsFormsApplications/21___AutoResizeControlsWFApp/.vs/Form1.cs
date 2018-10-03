using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoResize
{
    public partial class Form1 : Form
    {
        private Rectangle textBox1OriginalSize;
        private Rectangle button1OriginalSize;
        private Rectangle button2OriginalSize;
        private Rectangle button3OriginalSize;
        private Rectangle button4OriginalSize;
        

        private Size mainFormOriginalSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainFormOriginalSize = this.Size;

            textBox1OriginalSize = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            button1OriginalSize = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2OriginalSize = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button3OriginalSize = new Rectangle(button3.Location.X, button3.Location.Y,button3.Width, button3.Height);
            button4OriginalSize = new Rectangle(button4.Location.X, button4.Location.Y,button4.Width, button4.Height);
            
        }
        private void resizeChildrenControls()
        {
            
            resizeControl(button1OriginalSize, button1);
            resizeControl(button2OriginalSize, button2);
            resizeControl(button3OriginalSize, button3);
            resizeControl(button4OriginalSize, button4);
            resizeControl(textBox1OriginalSize, textBox1);

        }

        private void resizeControl(Rectangle originalSizeControl, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(mainFormOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(mainFormOriginalSize.Height);
            int newX = (int)(originalSizeControl.X * xRatio);
            int newY = (int)(originalSizeControl.Y * yRatio);
            int newWidth = (int)(originalSizeControl.Width * xRatio);
            int newHeight = (int)(originalSizeControl.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}
