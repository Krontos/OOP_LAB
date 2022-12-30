using System;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Лабораторна___7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
                Graphics graphics = pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.Black, 3f);
                int arr = (int)((4.5 - (-2)) / 0.5);
                PointF[] points = new PointF[arr + 1];
                int i = 0;
                float y;
                for (float x = -2F; x <= 4.5; x = x + 0.5F)
                {
                    y = ((float)Math.Pow(x, 2) + (2 * x)/ (float)(Math.Cos(5 * x) + 2));
                    points[i] = new PointF((float)x * 50, (float)(y * 50));
                    y++;
                    i++;
                }
                graphics.DrawLines(pen, points);
            
        }
    }

}