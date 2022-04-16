using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeApplication
{
    public class GraphicTool
    {
        public List<Shape> Shapes { get; private set; }

        public GraphicTool()
        {
            Shapes = new List<Shape>();
        }

        //add
        public void Add(ShapeType type, Dictionary<string, object> parameters)
        {
            var newShape = ShapeFactory.CreateShape(type, parameters);
           
            if(newShape != null)
            {
                Shapes.Add(newShape);
            }
        }

        //remove
        public void Remove(Shape shape)
        {
            Shapes.Remove(shape);
        }

        //drawAll
        public void DrawAll(Graphics graphic,Color color)
        {
            foreach(var shape in Shapes)
            {
                shape.Draw(graphic,color);
            }
        }


        //Draw single
        public void Draw(Graphics graphic, Shape shape,Color color)
        {
            if (shape == null) return;
            shape.Draw(graphic,color);
        }

        

        //Save on disk
        public void SaveOnDisk()
        {
            
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            string filepath = Path.Combine(path, "shapes.json");

            StringBuilder sb = new StringBuilder(); 
            foreach(var shape in Shapes)
            {
                sb.AppendLine(JsonConvert.SerializeObject(shape));
            }


                File.WriteAllText(filepath, sb.ToString()); 
        }

        //Load from disk
        public void LoadFromDisk()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            string filepath = Path.Combine(path, "shapes.json");
            
              
            try
            {
                foreach(string line in File.ReadLines(filepath))
                {
                    if (line.Contains("rectangle"))
                    {
                        var content = JsonConvert.DeserializeObject<Rectangle>(line);
                        Shapes.Add(content);
                    }
                    else
                        if (line.Contains("circle"))
                    {
                        var content = JsonConvert.DeserializeObject<Circle>(line);
                        Shapes.Add(content);
                    }
                    else
                        if (line.Contains("line"))
                    {
                        var content = JsonConvert.DeserializeObject<Line>(line);
                        Shapes.Add(content);
                    }
                    else
                        if (line.Contains("square"))
                    {
                        var content = JsonConvert.DeserializeObject<Square>(line);
                        Shapes.Add(content);
                    }
                    else
                        if (line.Contains("triangle"))
                    {
                        var content = JsonConvert.DeserializeObject<Triangle>(line);
                        Shapes.Add(content);
                    }
                    if (line.Contains("picture"))
                    {
                        var content = JsonConvert.DeserializeObject<Picture>(line);
                        Shapes.Add(content);
                    }
                }
            }
            catch (Exception)
            {

                return; 
            }
            
        }
    }
}
