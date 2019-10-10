using System;
using System.Collections;
using System.Collections.Generic;

namespace Object_orientedFourElements.多态
{
    class SMain
    {
//        static void main(string[] args)
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            var circle = new Circle(5);
            var rectangle = new Rectangle(4, 5);
            stack.Push(circle);
            stack.Push(rectangle);

            while (stack.Count != 0)
            {
                Shape shape = (Shape) stack.Pop();
                Console.WriteLine($"Area = " + shape.getArea());
            }
        }
    }
}