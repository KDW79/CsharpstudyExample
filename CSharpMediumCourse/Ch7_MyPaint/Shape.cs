using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_MyPaint
{
    abstract class Shape
    {
        public Point Location { get; set; } = new Point(0, 0); 
        public string Name { get; set; }
        public string Tag { get; set; }

        // 기본 그리기 기능
        //public abstract void Draw(Graphics g);

        // 고급 기능들
        public abstract void Clip(/*...*/);
        public abstract void Resize(/*...*/);
        //....
    }
}
