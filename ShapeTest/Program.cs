using ShapeApplication;
using System;
using System.Collections.Generic;

namespace ShapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicTool tool = new GraphicTool();

            tool.Add(ShapeType.Circle, new Dictionary<string, object>() 
            {
                { "radius", 20.5 },
                { "origin", new Point2d { X = 50, Y = 100 } }
            });

            tool.DrawAll(); //...
        }
    }
}
