using DesignPattern.Demo.Creational;
using System;

namespace DesignPattern.Demo
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Pattern Category");
            Console.WriteLine("1. Creational");
            Console.WriteLine("2. Structural");
            Console.WriteLine("3. Behavioral");
            Console.Write("Choose Desired Option: ");
            int type;
            if (int.TryParse(Console.ReadLine(), out type) && (type == 1 || type == 2 || type == 3))
            {
                switch (type)
                {
                    case 1:
                        RunCreationDesignPattern();
                        break;
                }
            }
            Console.WriteLine("");
            Console.Write("Type Any Key to Exist...");
            Console.Read();
        }
        private static void RunCreationDesignPattern()
        {
            Console.WriteLine("Creational Design Pattern");
            Console.WriteLine("1. Factory");
            Console.WriteLine("2. Abstract Factory");
            Console.WriteLine("3. Singleton");
            Console.WriteLine("4. Builder");
            Console.WriteLine("5. Prototype");
            Console.Write("Choose Desired Option: ");
            int patternId;
            if (int.TryParse(Console.ReadLine(), out patternId) && (patternId == 1 || patternId == 2 || patternId == 3 || patternId == 4 || patternId == 5))
            {
                switch (patternId)
                {
                    case 1:
                        FactoryPattern.RunDemo();
                        break;
                    case 2:
                        AbstractFactoryPattern.RunDemo();
                        break;
                    case 3:
                        SingletonPattern.RunDemo();
                        break;
                    case 4:
                        BuilderPattern.RunDemo();
                        break;
                    case 5:
                        PrototypePattern.RunDemo();
                        break;
                }
            }
        }
    }

}
