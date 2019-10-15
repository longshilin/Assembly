namespace DesignPatterns.单例模式
{
    public class ClassicSingleton
    {
        private static ClassicSingleton instance = null;

        protected ClassicSingleton()
        {
            // 只是为了防止实例化
        }

        public static ClassicSingleton getInstance()
        {
            if (instance == null)
            {
                instance = new ClassicSingleton();
            }

            return instance;
        }
    }
}