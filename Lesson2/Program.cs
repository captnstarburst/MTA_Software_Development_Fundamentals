using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Example of Encapsulation

namespace LessonTwo
{
    class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }
    }

    class Rectangle : Polygon
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return Width * Length;
        }
    }
}
//dotnet new console to create project
//dotnet run in the terminal