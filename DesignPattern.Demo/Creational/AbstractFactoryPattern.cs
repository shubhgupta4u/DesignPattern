using DesignPattern.Demo.Core.Creational;
using DesignPattern.Demo.Core.Creational.AbstractFactory;
using DesignPattern.Demo.Entities.Shape.Interface;

namespace DesignPattern.Demo.Creational
{
    static class AbstractFactoryPattern
    {
        private const string RECTANGLE_KEY = "RECTANGLE";
        private const string SQUARE_KEY = "SQUARE";
        public static void RunDemo()
        {
            ShapeAbstractFactory factoryInstance = FactoryProducer.GetFactory(0);
            
            IShape shape1 = factoryInstance.GetShape(RECTANGLE_KEY);
            shape1.Draw();

            IShape shape2 = factoryInstance.GetShape(SQUARE_KEY);
            shape2.Draw();

            ShapeAbstractFactory factoryInstance2 = FactoryProducer.GetFactory(10);

            IShape shape3 = factoryInstance2.GetShape(RECTANGLE_KEY);
            shape3.Draw();

            IShape shape4 = factoryInstance2.GetShape(SQUARE_KEY);
            shape4.Draw();
        }
    }
}
