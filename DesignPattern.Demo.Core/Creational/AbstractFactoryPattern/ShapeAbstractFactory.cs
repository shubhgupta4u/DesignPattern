using DesignPattern.Demo.Entities.Shape.Interface;
using System;

namespace DesignPattern.Demo.Core.Creational
{
    /// <summary>
    /// Abstract factory is a combination of Astract factory class and factory producer class
    /// </summary>
    public abstract class ShapeAbstractFactory
    {
        public abstract IShape GetShape(String shapeType);
    }
}
