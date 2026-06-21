namespace FinancialForecasting.Models
{
    public class FinancialData
    {
        public double InitialValue { get; set; }
        public double GrowthRate { get; set; }

        public FinancialData(double initialValue, double growthRate)
        {
            InitialValue = initialValue;
            GrowthRate = growthRate;
        }
    }
}