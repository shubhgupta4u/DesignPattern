namespace DesignPattern.Demo.Entities.Meal
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name { get; }

        public abstract float Price { get; }

        public IPacking Packing
        {
            get
            {
                return new Bottle();
            }
        }
    }
}
