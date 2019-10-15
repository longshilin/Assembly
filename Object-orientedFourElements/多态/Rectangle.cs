namespace Object_orientedFourElements.多态
{
    public class Rectangle : Shape
    {
        private readonly double length;
        private readonly double width;

        public Rectangle()
        {
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double getArea()
        {
            area = length * width;
            return area;
        }
    }
}