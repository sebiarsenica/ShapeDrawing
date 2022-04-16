using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2),4);
        }

        public override void Draw(Graphics graphic, Color color)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle((int)Origin.X,(int)Origin.Y,(int)Radius,(int)Radius);
            graphic.DrawEllipse(new Pen(color), rect);
        }

        public override void MoveTo(Point2d point)
        {
            Origin.X = point.X;
            Origin.Y = point.Y;
        }

        public override void Resize(double factor)
        {
            Radius *= factor;
        }
    }
}
