namespace DesignPatterns.迭代器模式
{
    /// <summary>
    /// 适配器模式可以为现有类创建不同的接口。适配器模式提供了一个包装类。换句话说，你创建了一个新类，使用新的更理想化的接口包含（包装）了现有类的功能。包装类的一个简单例子是Java类Integer。Integer类包装了一个整数值。你可能想为什么要这样做，请记住在面向对象的系统中，任何事物都是对象。在Java中，原生类型（比如int、float等）不是对象。当需要对这些原生对象执行操作（比如转换）时，你需要把它们作为对象来对待。你创建一个包装对象并“包装”这个原生类型
    /// </summary>
    public class SMain
    {
        public static void main(string[] args)
//        public static void Main(string[] args)
        {
            MyMailTool myMailTool = new MyMailTool();

            myMailTool.getMail();
        }
    }
}