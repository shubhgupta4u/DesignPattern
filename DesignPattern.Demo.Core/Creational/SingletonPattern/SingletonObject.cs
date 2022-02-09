namespace DesignPattern.Demo.Core.Creational
{
    public class SingletonObject
    {
        private static SingletonObject _instance;
        private static readonly object _padlock = new object();
        private int counter = 0;

        private SingletonObject()
        {

        }

        public static SingletonObject Instance
        {
            get
            {
                if (SingletonObject._instance == null)
                {
                    lock (_padlock)
                    {
                        if (SingletonObject._instance == null)
                        {
                            SingletonObject._instance = new SingletonObject();
                        }
                    }
                }
                return _instance;
            }
        }
        public int IncrementalCounter()
        {
            lock (_padlock)
            {
                this.counter += 1;
                return this.counter;
            }               
        }
    }
}
