using System;

namespace DesignPattern.Demo.Entities.Meal
{
    public class Wrapper : IPacking
    {
        public virtual void Pack()
        {
            Console.WriteLine("Inside Bottle::Pack() method.");
        }
    }
}
