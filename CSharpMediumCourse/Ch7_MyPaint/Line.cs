using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_MyPaint
{
    class Line : Shape, IDrawable
    {
        public int Length { get; set; } = 50;

        public void Draw(Graphics g)
        {
            //Point pt = Cursor.Position;
            //g.DrawLine(Pens.Black, Location.X, Location.Y, pt.X, pt.Y);

            Point pt2 = new Point(Location.X + Length, Location.Y + Length);
            g.DrawLine(Pens.Blue, Location, pt2);

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
