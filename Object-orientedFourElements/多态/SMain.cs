using System;
using System.Collections;
using System.Xml;

namespace Object_orientedFourElements.多态
{
    class SMain
    {
        static void main(string[] args)
//        static void Main(string[] args)
        {
            // 多态调用的方式一 //
            Stack stack = new Stack();
            var circle = new Circle(5);
            var rectangle = new Rectangle(4, 5);
            stack.Push(circle);
            stack.Push(rectangle);

            while (stack.Count != 0)
            {
                Shape s = (Shape) stack.Pop();
                Console.WriteLine($"Area = " + s.getArea());
            }

            // 多态调用方式二 //
            GetArea(circle);
            GetArea(rectangle);


            // 通过同一套代码实例化继承于同一父类的不同子类 //
            Shape shape = null;
            string className = args[0];
            Console.WriteLine($"Instantiate the class: {className}");

            try
            {
                switch (className)
                {
                    case "circle":
                        shape = (Shape) Activator.CreateInstance(typeof(Circle));
                        break;
                    case "rectangle":
                        shape = (Shape) Activator.CreateInstance(typeof(Rectangle));
                        break;
                    default:
                        Console.WriteLine("not find class.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // get the class object
            if (shape != null) Console.WriteLine($"the class object is {shape.GetType()}");
        }

        static void GetArea(Shape s)
        {
            Console.WriteLine($"getArea = {s.getArea()}");
        }
    }
}