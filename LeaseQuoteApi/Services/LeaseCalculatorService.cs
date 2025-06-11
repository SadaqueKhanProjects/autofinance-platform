using System.Xml.Schema;
using LeaseQuoteApi.Models;

public class LeaseCalculatorService
{
    private readonly Dictionary<string, double> _baseMonthlyRates = new()
    {
        {"Golf", 300},
        {"Tiguan", 400},
        {"Passat", 350}
    };

    public LeaseQuoteResponse CalculateQuote(LeaseQuoteRequest request)
    {
        double baseRate = _baseMonthlyRates.GetValueOrDefault(request.CarModel, 0);

        var monthly = baseRate;
        var total = monthly * request.DurationMonths;

        return new LeaseQuoteResponse
        {
            MonthlyPayment = monthly,
            TotalCost = total
        };
    }
}