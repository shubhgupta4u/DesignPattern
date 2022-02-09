namespace DesignPattern.Demo.Core.Creational.AbstractFactory
{
    public static class FactoryProducer
    {
        public static ShapeAbstractFactory GetFactory(int cornerRadius)
        {
            if (cornerRadius > 0)
            {
                return new RoundedShapeFactory(cornerRadius);
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
