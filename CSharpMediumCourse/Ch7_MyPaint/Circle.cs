using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_MyPaint
{
    internal class Circle : Shape, IDrawable
    {
        public int Radius { get; set; } = 50;

        //public Circle(Point loc)
        //{
        //    Location = loc;
        //}

        public void Draw(Graphics g)
        {
            Point pt = Cursor.Position;
            g.DrawEllipse(Pens.Black, Location.X, Location.Y, 2 * Radius, 2 * Radius);
        }

        public override void Clip()
        {
            throw new System.NotImplementedException();
        }

        public override void Resize()
        {
            throw new System.NotImplementedException();
        }
    }
}
