namespace BookingSystem.Core.Contracts
{
    using BookingSystem.Core.Models.User;
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> AllAsync();
    }
}
