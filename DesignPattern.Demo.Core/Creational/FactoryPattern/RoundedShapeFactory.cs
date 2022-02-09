using DesignPattern.Demo.Entities.Shape;
using DesignPattern.Demo.Entities.Shape.Interface;
using System;

namespace DesignPattern.Demo.Core.Creational
{
    public class RoundedShapeFactory : ShapeAbstractFactory
    {
        public int CornerRadius { get; private set; }

        public RoundedShapeFactory(int cornerRadius)
        {
            this.CornerRadius = cornerRadius;
        }
        //use getShape method to get object of type shape 
        public override IShape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new RoundedRectangle(this.CornerRadius);
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new RoundedSquare(this.CornerRadius);
            }

            return null;
        }
    }
}
