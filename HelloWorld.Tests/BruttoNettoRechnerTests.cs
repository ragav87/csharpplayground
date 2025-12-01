using Xunit;
using HelloWorld.Services;

namespace HelloWorld.Tests
{
    public class BruttoNettoRechnerTests
    {
        [Theory]
        [InlineData(3000, 1, false, 1800)] // 20% tax, no church tax
        [InlineData(3000, 1, true, 1530)]  // 20% tax, 9% church tax
        [InlineData(3000, 3, false, 2100)] // 10% tax, no church tax
        [InlineData(3000, 3, true, 1830)]  // 10% tax, 9% church tax
        [InlineData(3000, 4, false, 1860)] // 18% tax, no church tax
        [InlineData(3000, 4, true, 1590)]  // 18% tax, 9% church tax
        [InlineData(3000, 5, false, 1500)] // 30% tax, no church tax
        [InlineData(3000, 5, true, 1230)]  // 30% tax, 9% church tax
        [InlineData(3000, 9, false, 1800)] // default tax, no church tax
        public void BerechneNetto_CoversAllBranches(double brutto, int steuerklasse, bool kirchensteuer, double expected)
        {
            double result = BruttoNettoRechner.BerechneNetto(brutto, steuerklasse, kirchensteuer);
            Assert.Equal(expected, result, 0);
        }
    }
}
