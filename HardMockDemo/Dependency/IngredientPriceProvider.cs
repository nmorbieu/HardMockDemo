using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dependency
{
    public class IngredientPriceProvider
    {
        private const int Eternity = 1000;

        public double GetPrice(string ingredient)
        {
            //Aouch ! Full integration tests will be very slow...
            Thread.Sleep(Eternity);
            // and very instable !
            var seed = DateTime.Now.Minute + ingredient.GetHashCode();
            var random = new Random(DateTime.Now.Minute);
            return random.NextDouble();
        }
    }
}
