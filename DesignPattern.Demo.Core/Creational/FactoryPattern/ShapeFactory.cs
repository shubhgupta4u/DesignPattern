using DesignPattern.Demo.Entities.Shape;
using DesignPattern.Demo.Entities.Shape.Interface;
using System;

namespace DesignPattern.Demo.Core.Creational
{
    public class ShapeFactory: ShapeAbstractFactory
    {
        //use getShape method to get object of type shape 
        public override IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
