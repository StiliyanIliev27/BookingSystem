namespace BookingSystem.Core.Models.Location
{
    public class CountryDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Capital { get; set; } = null!;
        public string Population { get; set; } = null!;
        public string ContinentName { get; set; } = null!;
        public string Details { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public string FlagImageUrl { get; set; } = null!;
        public string Language { get; set; } = null!;
    }
}
