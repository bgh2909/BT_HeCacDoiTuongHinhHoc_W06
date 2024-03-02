using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_HeCacDoiTuongHinhHoc_W06
{
    internal class Program
    {
        public class Shape
        {
            private string color = "green";
            private bool filled = true;

            public Shape() 
            { 
            
            }

            public Shape(string color, bool filled)
            {
                this.color = color;
                this.filled = filled;
            }

            public string GetColor()
            {
                return color;
            }

            public void SetColor(string color)
            {
                this.color = color;
            }

            public bool IsFilled()
            {
                return filled;
            }

            public void SetFilled(bool filled)
            {
                this.filled = filled;
            }

            public override string ToString()
            {
                return "A Shape with color of " + GetColor() + " and " + (IsFilled() ? "filled" : "not filled");
            }
        }

        public class Circle : Shape
        {
            private double radius = 1.0;

            public Circle() { }

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public Circle(double radius, string color, bool filled) : base(color, filled)
            {
                this.radius = radius;
            }

            public double GetRadius()
            {
                return radius;
            }

            public void SetRadius(double radius)
            {
                this.radius = radius;
            }

            public double GetArea()
            {
                return radius * radius * Math.PI;
            }

            public double GetPerimeter()
            {
                return 2 * radius * Math.PI;
            }

            public override string ToString()
            {
                return "A Circle with radius=" + GetRadius() + ", which is a subclass of " + base.ToString();
            }
        }

        public class Rectangle : Shape
        {
            private double width = 1.0;
            private double length = 1.0;

            public Rectangle() { }

            public Rectangle(double width, double length)
            {
                this.width = width;
                this.length = length;
            }

            public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
            {
                this.width = width;
                this.length = length;
            }

            public double GetWidth()
            {
                return width;
            }

            public virtual void SetWidth(double width)
            {
                this.width = width;
            }

            public double GetLength()
            {
                return length;
            }

            public virtual void SetLength(double length)
            {
                this.length = length;
            }

            public double GetArea()
            {
                return width * length;
            }

            public double GetPerimeter()
            {
                return 2 * (width + length);
            }

            public override string ToString()
            {
                return "A Rectangle with width=" + GetWidth() + " and length=" + GetLength() + ", which is a subclass of " + base.ToString();
            }
        }

        public class Square : Rectangle
        {
            public Square() { }

            public Square(double side) : base(side, side) { }

            public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

            public double GetSide()
            {
                return GetWidth();
            }

            public void SetSide(double side)
            {
                SetWidth(side);
                SetLength(side);
            }

            public override void SetWidth(double width)
            {
                SetSide(width);
            }

            public override void SetLength(double length)
            {
                SetSide(length);
            }

            public override string ToString()
            {
                return "A Square with side=" + GetSide() + ", which is a subclass of " + base.ToString();
            }
        }

        public class SquareTest
        {
            public static void Main(string[] args)
            {
                Square square = new Square();
                Console.WriteLine(square);

                square = new Square(2.3);
                Console.WriteLine(square);

                square = new Square(5.8, "yellow", true);
                Console.WriteLine(square);

                Console.ReadKey();
            }
        }
        
    }
}
