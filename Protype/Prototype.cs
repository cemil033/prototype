using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    abstract public class Shape : ICloneable
    {
        public Shape()
        {

        }
        protected Shape(Shape source)
        {            
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string? Color { get; set; }

        public abstract object Clone();
    }
    public class Regtangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Regtangle(Regtangle source)
        {
            source.Width = Width;
            source.Height = Height;
            source.Color = Color;
            source.X = X;
            source.Y = Y;
        }
        public override object Clone()
        {
            return new Regtangle(this);
        }
    }
    public class Circle : Shape
    {
       public int Radius { get; set; }
        public Circle(Circle source)
        {
            source.Radius = Radius;
            source.Color = Color;
            source.X = X;
            source.Y = Y;
        }
        public override object Clone()
        {
            return new Circle(this);
        }
    }
    public class Prototype
    {
    }
}
