using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeApplication
{
    public class ShapeFactory
    {
        public static Shape CreateShape(ShapeType type, Dictionary<string, object> parameters)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return CreateCircle(parameters);
                case ShapeType.Rectangle: 
                    return CreateRectangle(parameters);
                case ShapeType.Line:
                    return CreateLine(parameters);
                case ShapeType.Triangle:
                    return CreateTriangle(parameters);
                case ShapeType.Square:
                    return CreateSquare(parameters);
                case ShapeType.Picture:
                    return CreatePicture(parameters);
            }
                            
            return null;
        }

        public static Shape CreateCircle(Dictionary<string, object> parameters)
        {
            if(parameters.ContainsKey("Radius") && parameters.ContainsKey("Origin"))
            {
                var radius = (double)parameters["Radius"];
                var origin = (Point2d)parameters["Origin"];

                return new Circle() { Radius = radius, Origin = origin, Name = $"circle_{Guid.NewGuid()}" };
            }

            return null;
        }

        public static Shape CreateRectangle(Dictionary<string, object> parameters)
        {
            if(parameters.ContainsKey("Origin")&& parameters.ContainsKey("Point"))
            {
                var origin = (Point2d)parameters["Origin"];
                var point = (Point2d)parameters["Point"];

                return new Rectangle() { Origin = origin, Point = point, Name = $"rectangle_{Guid.NewGuid()}" };
            }
            return null;
        }

        public static Shape CreateLine(Dictionary<string, object> parameters)
        {
            if (parameters.ContainsKey("Origin") && parameters.ContainsKey("Point"))
            {
                var origin = (Point2d)parameters["Origin"];
                var point = (Point2d)parameters["Point"];

                return new Line() { Origin = origin, Point = point, Name = $"line_{Guid.NewGuid()}" };
            }
            return null;
        }

        public static Shape CreateTriangle(Dictionary<string, object> parameters)
        {
            if(parameters.ContainsKey("Origin") && parameters.ContainsKey("Point2") && parameters.ContainsKey("Point3"))
            {
                var origin = (Point2d)parameters["Origin"];
                var point2 = (Point2d)parameters["Point2"];
                var point3 = (Point2d)parameters["Point3"];
                return new Triangle() { Origin = origin, Point2 = point2, Point3 = point3, Name = $"triangle_{Guid.NewGuid()}" };
            }
            return null; 
        }

        public static Shape CreateSquare(Dictionary<string,object> parameters)
        {
            if(parameters.ContainsKey("Origin")&& parameters.ContainsKey("Height"))
            {
                var origin = (Point2d)parameters["Origin"];
                var height = (double)parameters["Height"];
                return new Square() { Height = height, Origin = origin, Name = $"square_{Guid.NewGuid()}" };
            }
            return null;
        }

        public static Shape CreatePicture(Dictionary<string,object> parameters)
        {
            if(parameters.ContainsKey("Origin")&& parameters.ContainsKey("FilePath"))
            {
                var origin = (Point2d)parameters["Origin"];
                var filepath = (string)parameters["FilePath"];
                return new Picture() { Origin = origin, Filepath = filepath, Name = $"picture_{Guid.NewGuid()}" };
            }
            return null;
        }
    }
}
