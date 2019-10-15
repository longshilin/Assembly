using System;
using System.Collections;

namespace DesignPatterns.适配器模式
{
    /// <summary>
    /// 迭代器提供了一个标准的机制来遍历集合（比如列表）。该机制提供的功能要保证集合中的每个条目都必须至少被访问一次。迭代器模式隐藏了信息，保证了集合的内部结构是秘密的。迭代器模式也规定可以创建多个迭代器，迭代器之间不会相互妨碍。Java语言自身实现了迭代器。以下的代码创建了一个列表，并且插入一组字符串：
    /// </summary>
    public class Iterator
    {
        public static void Main(string[] args)
        {
            // 实例化ArrayList
            ArrayList names = new ArrayList();
            names.Add(new string("Joe"));
            names.Add(new string("Mary"));
            names.Add(new string("Bob"));
            names.Add(new string("Sue"));

            // 迭代名称
            Console.WriteLine("Names:");
            iterate(names);
        }

        private static void iterate(ArrayList arl)
        {
            foreach (var item in arl)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}