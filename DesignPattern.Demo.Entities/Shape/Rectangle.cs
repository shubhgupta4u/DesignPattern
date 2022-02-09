using DesignPattern.Demo.Entities.Shape.Interface;
using System;

namespace DesignPattern.Demo.Entities.Shape
{
    public class Rectangle : IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
