using System;

namespace DesignPatterns.单例模式.Test
{
    public class Counter
    {
        private int counter;
        private static Counter instance = null;

        protected Counter()
        {
        }

        public static Counter getInstance()
        {
            if (instance == null)
            {
                instance = new Counter();
                Console.WriteLine("New Instance created");
            }

            return instance;
        }

        public void IncrementCounter()
        {
            counter++;
        }

        public int getCounter()
        {
            return counter;
        }
    }
}