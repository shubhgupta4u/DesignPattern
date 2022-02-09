using DesignPattern.Demo.Entities.Shape.Interface;
using System;

namespace DesignPattern.Demo.Entities.Shape
{
    public class RoundedRectangle: Rectangle,IRoundedShape
    {
        public int CornerRadius { get; private set; }

        public RoundedRectangle(int cornerRadius)
        {
            this.CornerRadius = cornerRadius;
        }

        public override void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
}
