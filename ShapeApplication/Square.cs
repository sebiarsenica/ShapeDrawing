using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    internal class Square : Shape
    {
        public double Height { get; set; }
        
        public override double Area()
        {
            return Height * Height;
        }

        public override void Draw(Graphics graphic, Color color)
        {
            graphic.DrawRectangle(new Pen(color), (int)Origin.X, (int)Origin.Y, (float)Height, (float)Height);
        }

        public override void MoveTo(Point2d point)
        {
            Origin.X = point.X; 
            Origin.Y = point.Y;
        }

        public override void Resize(double factor)
        {
            Height *= factor;
        }
    }
}
