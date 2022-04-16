using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    internal class Picture : Shape
    {
        public string Filepath { get; set; }

        private Image img;
        private double Width , Height;

        public override double Area()
        {
            return Width* Height;
        }

        public override void Draw(Graphics graphic, Color color)
        {
            if (img == null)
            {
                img = Image.FromFile(Filepath);
                Width = img.Width;
                Height = img.Height;
            }
            graphic.DrawImage(img, (float)Origin.X,(float)Origin.Y,(float)Width,(float)Height);
        }

        public override void MoveTo(Point2d point)
        {
            Origin.X = point.X; 
            Origin.Y = point.Y;
        }

        public override void Resize(double factor)
        {
            Width *= factor;
            Height *= factor;
        }
    }
}
