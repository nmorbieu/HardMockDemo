using Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCode
{
    public class PastaPricer
    {
        private const double Margin = 2; // 200%, what a margin ! Does GTS cook pastas ?

        private readonly IngredientPriceProvider ingredientProvider = new IngredientPriceProvider();

        public double GetPrice(Pasta pasta)
        {
            //TODO Hey kids, come and look at this guy, it must be a java transfuge ! Let's show him how Linq works.
            double totalPrice = 0;
            foreach (Dose dose in pasta.Composition.Ingredients)
            {
                totalPrice += dose.Quantity + ingredientProvider.GetPrice(dose.Ingredient);
            }
            return totalPrice * (1 + Margin);
        }
    }
}
