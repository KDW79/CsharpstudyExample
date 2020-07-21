using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Ch7_MyPaint
{
    public partial class Form1 : Form
    {
        private List<IDrawable> drawings = new List<IDrawable>();
        int idx = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var s in drawings)
            {
                s.Draw(e.Graphics);
            }
        }

        private void Custom1_Draw()
        {
            Point loc = pictureBox1.PointToClient(MousePosition);

            Assembly custom = Assembly.LoadFrom(@"C:\Users\5326562\Source\Repos\KDW79\CsharpstudyExample\CSharpMediumCourse\Ch7_MyPaintCustom1\bin\Debug\Ch7_MyPaintCustom1.dll");
            Type pie = custom.GetType("Ch7_MyPaintCustom1.Pie");
            IDrawable obj = (IDrawable)Activator.CreateInstance(pie, loc.X, loc.Y, 100, 100, 150, 280);
            obj.Draw(pictureBox1.CreateGraphics());

            drawings.Add(obj);

        }

        private void Line_Draw()
        {
            Point loc = pictureBox1.PointToClient(MousePosition);

            Type line = typeof(Line);
            PropertyInfo locProperty = line.GetProperty("Location");
            IDrawable obj = (IDrawable)Activator.CreateInstance(line);
            locProperty.SetValue(obj, loc, null);
            obj.Draw(pictureBox1.CreateGraphics());

            drawings.Add(obj);
        }

        private void Rect_Draw()
        {
            Point loc = pictureBox1.PointToClient(MousePosition);

            Type rect = typeof(Rect);
            PropertyInfo locProperty = rect.GetProperty("Location");
            IDrawable obj = (IDrawable)Activator.CreateInstance(rect);
            locProperty.SetValue(obj, loc, null);
            obj.Draw(pictureBox1.CreateGraphics());

            drawings.Add(obj);
        }

        private void Circle_Draw()
        {
            Point loc = pictureBox1.PointToClient(MousePosition);

            Type circle = typeof(Circle);
            PropertyInfo locProperty = circle.GetProperty("Location");
            IDrawable obj = (IDrawable)Activator.CreateInstance(circle);
            locProperty.SetValue(obj, loc, null);
            obj.Draw(pictureBox1.CreateGraphics());

            drawings.Add(obj);
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            idx = 1;
        }

        private void buttonDrawRect_Click(object sender, EventArgs e)
        {
            idx = 2;
        }

        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            idx = 3;
        }

        private void buttonDrawCustom1_Click(object sender, EventArgs e)
        {
            idx = 4;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (idx == 1)
                Line_Draw();
            else if (idx == 2)
                Rect_Draw();
            else if (idx == 3)
                Circle_Draw();
            else if (idx == 4)
                Custom1_Draw();
        }

    }
}
