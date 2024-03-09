namespace BookingSystem.Core.Models.Location
{
    public class CityDetailsViewlModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Population { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string? Details { get; set; }
        public string CountryName { get; set; } = null!;
        public int CountryId { get; set; }  
        public string ImageUrl { get; set; } = null!;
    }
}
