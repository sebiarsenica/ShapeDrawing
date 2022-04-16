using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    internal class Rectangle : Shape
    {
        public Point2d Point { get; set; }

        public override double Area()
        {
            return Point.X * Point.Y;
        }

        public override void Draw(Graphics graphic, Color color)
        {
            
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle((int)Origin.X,(int)Origin.Y,(int)Point.X,(int)Point.Y);
            graphic.DrawRectangle(new Pen(color), rect);
            
            
        }

        public override void MoveTo(Point2d point)
        {
           Origin.X = point.X; 
           Origin.Y = point.Y;
        }

        public override void Resize(double factor)
        {
            Point.X *=factor;
            Point.Y *=factor;
        }
    }
}
