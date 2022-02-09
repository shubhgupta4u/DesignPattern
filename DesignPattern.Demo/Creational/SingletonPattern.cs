using DesignPattern.Demo.Core.Creational;
using System.Threading.Tasks;
using System;

namespace DesignPattern.Demo.Creational
{
    static class SingletonPattern
    {
        public static void RunDemo()
        {
            Parallel.For(1, 10, (i) =>
            {
                Console.WriteLine(string.Format("Current loop is {0} and current counter value is {1}",i, SingletonObject.Instance.IncrementalCounter()));
            });
            
        }
    }
}
