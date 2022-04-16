using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeApplication
{
    internal class Triangle : Shape
    {
        public Point2d Point2 { get; set; } 
        public Point2d Point3 { get; set; }

        public override double Area()
        {
            double a = Math.Sqrt(Math.Pow(Point2.X - Origin.X,2) + Math.Pow(Point2.Y - Origin.Y,2)); 
            double b = Math.Sqrt(Math.Pow(Point3.X - Point2.X, 2) + Math.Pow(Point3.Y - Point2.Y, 2));
            double c = Math.Sqrt(Math.Pow(Origin.X - Point3.X,2)+ Math.Pow(Origin.Y - Point3.Y,2));
            double p = (a+b+c)/2;
            return Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)),4);
            
        }

        public override void Draw(Graphics graphic, Color color)
        {
            Pen pen = new Pen(color);
            graphic.DrawLine(pen,(int)Origin.X, (int)Origin.Y, (int)Point2.X, (int)Point2.Y);
            graphic.DrawLine(pen, (int)Point2.X, (int)Point2.Y, (int)Point3.X, (int)Point3.Y);
            graphic.DrawLine(pen, (int)Point3.X, (int)Point3.Y, (int)Origin.X, (int)Origin.Y);
        }

        public override void MoveTo(Point2d point)
        {
            double diferencex = point.X - Origin.X; 
            double diferencey = point.Y - Origin.Y;
            
            Origin.X = point.X; 
            Origin.Y = point.Y;
            Point2.X += diferencex;
            Point2.Y += diferencey;
            Point3.X += diferencex;
            Point3.Y += diferencey;
        }

        public override void Resize(double factor)
        {
            Point2.X *= factor;
            Point2.Y *= factor; 
            Point3.X *= factor; 
            Point3.Y *= factor;
        }
    }
}
