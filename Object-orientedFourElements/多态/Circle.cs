using System;

namespace Object_orientedFourElements.多态
{
    public class Circle : Shape
    {
        private readonly double radius;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            area = Math.PI * Math.Sqrt(radius);
            return area;
        }
    }
}