namespace DesignPattern.Demo.Entities.Meal
{
    public abstract class Burger : IItem
    {
        public abstract string Name { get; }

        public abstract float Price { get; }

        public IPacking Packing
        {
            get
            {
                return new Wrapper();
            }
        }
    }
}
