using System;

namespace DesignPattern.Demo.Entities.Meal
{
    public class Bottle:IPacking
    {
        public virtual void Pack()
        {
            Console.WriteLine("Inside Bottle::Pack() method.");
        }
    }
}
