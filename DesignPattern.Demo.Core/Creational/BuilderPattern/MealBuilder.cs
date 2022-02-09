using DesignPattern.Demo.Entities.Meal;

namespace DesignPattern.Demo.Core.Creational
{
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal meal = new Meal();
            meal.Add(new AlooTikkiBurger());
            meal.Add(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.Add(new ChickenBurger());
            meal.Add(new Pepsi());
            return meal;
        }
    }
}
