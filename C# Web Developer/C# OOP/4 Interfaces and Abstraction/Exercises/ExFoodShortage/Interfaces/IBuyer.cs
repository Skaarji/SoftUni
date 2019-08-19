using System;
using System.Collections.Generic;
using System.Text;

namespace ExFoodShortage.Interfaces
{
    interface IBuyer
    {
        int Food { get; }
        string Name { get; }

        void BuyFood();
    }
}
