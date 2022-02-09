using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Demo.Entities.Meal
{
    public interface IMeal
    {
        float GetCost();
        void DisplayOrder();
    }
}
