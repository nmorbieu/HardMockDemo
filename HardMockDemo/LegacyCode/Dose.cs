using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dependency;

namespace LegacyCode
{
    public class Dose
    {
        public readonly string Ingredient;

        public readonly int Quantity;

        public Dose(string ingredient, int quantity)
        {
            Ingredient = ingredient;
            Quantity = quantity;
        }
    }
}
