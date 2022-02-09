using DesignPattern.Demo.Core.Creational;
using DesignPattern.Demo.Entities.Meal;

namespace DesignPattern.Demo.Creational
{
    static class BuilderPattern
    {
        public static void RunDemo()
        {
            MealBuilder builderInstance = new MealBuilder();
            Meal meal1 = builderInstance.PrepareNonVegMeal();
            meal1.DisplayOrder();
            Meal meal2 = builderInstance.PrepareVegMeal();
            meal2.DisplayOrder();
        }
    }
}
