namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.User;
    using BookingSystem.Infrastructure.Common;
    using Microsoft.EntityFrameworkCore;

    public class UserService : IUserService
    {
        private readonly IRepository repository;

        public UserService(IRepository repository)
        {
            this.repository = repository;    
        }
        public async Task<IEnumerable<UserViewModel>> AllAsync()
        {
            return await repository.AllReadOnly<ApplicationUser>()
                .Select(u => new UserViewModel()
                {
                    Id = u.Id,
                    FullName = $"{u.FirstName} {u.LastName}",
                    Email = u.UserName
                })
                .ToListAsync();
        }
    }
}
