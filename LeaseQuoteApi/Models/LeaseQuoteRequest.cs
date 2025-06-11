namespace LeaseQuoteApi.Models

{
    public class LeaseQuoteRequest
    {
        public string CarModel { get; set; }

        public int DurationMonths { get; set; }
    }
}