using DesignPattern.Demo.Entities.Shape.Interface;
using System;

namespace DesignPattern.Demo.Entities.Shape
{
    public class Square : IShape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
