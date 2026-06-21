namespace FinancialForecasting.Algorithms
{
    public class RecursiveForecast
    {
        public double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return PredictFutureValue(currentValue, growthRate, years - 1)
                   * (1 + growthRate);
        }
    }
}