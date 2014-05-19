using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyCode
{
    public class Pasta
    {
        public readonly string Name;

        public readonly PastaComposition Composition;

        public Pasta(string name, PastaComposition composition)
        {
            Name = name;
            Composition = composition;
        }
    }
}
