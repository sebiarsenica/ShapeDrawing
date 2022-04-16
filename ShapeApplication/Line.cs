using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    internal class Line : Shape
    {
        public Point2d Point { get; set; }

        public override double Area()
        {
            return Math.Round(Math.Sqrt(Math.Pow(Point.X - Origin.X, 2) + Math.Pow(Point.Y - Origin.Y, 2)),4);
        }

        public override void Draw(Graphics graphic, Color color)
        {
          graphic.DrawLine(new Pen(color),(float)Origin.X,(float)Origin.Y,(float)Point.X,(float)Point.Y);
        }

        public override void MoveTo(Point2d point)
        {
            double diferencex = point.X - Origin.X;
            double diferencey = point.Y - Origin.Y;

            Origin.X = point.X;
            Origin.Y = point.Y;
            Point.X += diferencex;
            Point.Y += diferencey;
        }

        public override void Resize(double factor)
        {
            Point.X *= factor; 
            Point.Y *= factor;
        }
    }
}
