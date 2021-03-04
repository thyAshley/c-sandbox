using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverwriting
{
    public class Canvas
    {
        public static void DrawShape(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
    public class Position
    {

    }


    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing...");
        }
    }

    public class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle..");
        }
    }

    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shapeList = new List<Shape>();
            shapeList.Add(new Circle());
            shapeList.Add(new Rectangle());
            shapeList.Add(new Circle());
            Canvas.DrawShape(shapeList);


        }
    }
}
