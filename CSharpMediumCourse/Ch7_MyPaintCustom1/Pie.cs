using Ch7_MyPaint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_MyPaintCustom1
{
    public class Pie : IDrawable
    {
        public Rectangle Rect { get; }
        public float StartAngle { get; }
        public float SweepAngle { get; }

        public Pie(int x, int y, int width, int height, float startAngle = 0, float sweepAngle = 0)
        {
            this.Rect = new Rectangle(x, y, width, height);
            this.StartAngle = startAngle;
            this.SweepAngle = sweepAngle;
               
        }

        public void Draw(Graphics g)
        {
            g.FillPie(Brushes.DarkGreen, Rect, StartAngle, SweepAngle);
        }

    }
}
