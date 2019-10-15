using System;

namespace DesignPatterns.单例模式.Test
{
    /// <summary>
    /// 当用类创建对象时始终只有一个对象实例。例如，假设一个网站中有一个计数器对象来记录网站的点击次数，你当然不想每次页面被点击时都实例化一个计数器对象。你需要在第一次点击时实例化一个计数器对象，之后一直使用这个对象来进行计数。
    /// </summary>
    public class SMain
    {
        public static void main(string[] args)
//        public static void Main(string[] args)
        {
            var instance = Counter.getInstance();
            instance.IncrementCounter();
            Console.WriteLine($"Counter: {instance.getCounter()}");

            instance.IncrementCounter();

            var counter = Counter.getInstance();
            Console.WriteLine($"Counter: {counter.getCounter()}");
        }
    }
}