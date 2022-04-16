using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    public abstract class Shape
    {
        public Point2d Origin { get; set; }
        public string Name { get; set; }

        public abstract void Draw(Graphics graphic,Color color);
        public abstract void Resize(double factor);
        public abstract void MoveTo(Point2d point);
        public abstract double Area();
    }
}
