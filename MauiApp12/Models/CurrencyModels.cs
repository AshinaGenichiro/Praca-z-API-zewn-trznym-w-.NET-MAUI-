namespace MauiApp12.Models;

public class CurrencyModels 
{
    public class NbpRateResponse
    {
        public string Table { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public List<ExchangeRate> Rates { get; set; }
    }

   
    public class ExchangeRate
    {
        public string No { get; set; }
        public string EffectiveDate { get; set; }
        public double Mid { get; set; }
    }
}