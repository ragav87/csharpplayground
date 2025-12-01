using Xunit;
using HelloWorld.Services;

namespace HelloWorld.Tests
{
    public class PensionPlanSelectorTests
    {
        [Theory]
        [InlineData(10, "Not eligible for a pension plan.")]
        [InlineData(25, "Young Saver Plan")]
        [InlineData(40, "Standard Pension Plan")]
        public void SelectPlan_CoversSixtyPercent(int age, string expected)
        {
            string result = PensionPlanSelector.SelectPlan(age);
            Assert.Equal(expected, result);
        }
    }
}
