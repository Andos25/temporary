﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
