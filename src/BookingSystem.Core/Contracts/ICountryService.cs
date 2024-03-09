namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Models.Location;
    public interface ICountryService
    {
        Task<CountryDetailsViewModel> DetailsAsync(int countryId);
    }
}
