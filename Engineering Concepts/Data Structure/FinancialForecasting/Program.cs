using FinancialForecasting.Models;
using FinancialForecasting.Algorithms;

namespace FinancialForecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinancialData data = new FinancialData(10000, 0.10);

            RecursiveForecast forecast = new RecursiveForecast();

            double futureValue =
                forecast.PredictFutureValue(
                    data.InitialValue,
                    data.GrowthRate,
                    5);

            Console.WriteLine($"Predicted value after 5 years: {futureValue:F2}");
        }
    }
}