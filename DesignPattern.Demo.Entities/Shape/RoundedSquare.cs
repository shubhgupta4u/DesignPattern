using DesignPattern.Demo.Entities.Shape.Interface;
using System;

namespace DesignPattern.Demo.Entities.Shape
{
    public class RoundedSquare: Square, IRoundedShape
    {
        public int CornerRadius { get; private set; }

        public RoundedSquare(int cornerRadius)
        {
            this.CornerRadius = cornerRadius;
        }

        public override void Draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
}
