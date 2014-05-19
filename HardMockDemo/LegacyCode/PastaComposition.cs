using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCode
{
    public class PastaComposition
    {
        public readonly IReadOnlyCollection<Dose> Ingredients;

        public PastaComposition(IEnumerable<Dose> ingredients)
        {
            Ingredients = ingredients.ToList().AsReadOnly();
        }
    }
}
