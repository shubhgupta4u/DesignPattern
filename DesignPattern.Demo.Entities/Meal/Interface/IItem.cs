using System;

namespace DesignPattern.Demo.Entities.Meal
{
    public interface IItem
    {
        string Name { get; }
        float Price { get; }
        IPacking Packing { get; }
    }
}
