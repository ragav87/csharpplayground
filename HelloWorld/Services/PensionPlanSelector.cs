namespace HelloWorld.Services
{
    public class PensionPlanSelector
    {
        public static string SelectPlan(int age)
        {
            if (age < 18)
                return "Not eligible for a pension plan.";
            else if (age < 30)
                return "Young Saver Plan";
            else if (age < 50)
                return "Standard Pension Plan";
            else if (age < 65)
                return "Advanced Pension Plan";
            else
                return "Senior Pension Plan";
        }
    }
}
