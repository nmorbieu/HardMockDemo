using Dependency;
using LegacyCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Sorry to use bad tools, but I don't have an internet connection => no nuget
    [TestClass]
    public class IntegrationTests
    {
        private Pasta Spaghetti 
        {
            get 
            {
                var spaghettiComposition = new PastaComposition(
                new Dose[]
                {
                    new Dose("Flour", 1000),
                    new Dose("Water", 100),
                    new Dose("Salt", 1)
                });
                return new Pasta("Spaghetti", spaghettiComposition);
            }
        }

        [TestMethod]
        public void Spaghetti_pricing()
        {
            var pastaPricer = new PastaPricer();

            var spaghettiPrice = pastaPricer.GetPrice(Spaghetti);

            Assert.AreEqual(3304.20d, spaghettiPrice, 1);
        }
    }
}
