using System;

namespace Study.DesignPatterns
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (instance is null)
                    instance = new Singleton();

                return instance;
            }
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
