using DesignPattern.Demo.Core.Creational;
using DesignPattern.Demo.Entities.Shape.Interface;

namespace DesignPattern.Demo.Creational
{
    static class FactoryPattern
    {
        private const string RECTANGLE_KEY = "RECTANGLE";
        private const string SQUARE_KEY = "SQUARE";

        public static void RunDemo()
        {
            ShapeFactory factoryInstance = new ShapeFactory();
            IShape shape1 = factoryInstance.GetShape(RECTANGLE_KEY);
            shape1.Draw();

            IShape shape2 = factoryInstance.GetShape(SQUARE_KEY);
            shape2.Draw();
        }
    }
}
