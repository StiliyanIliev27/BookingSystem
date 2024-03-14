namespace BookingSystem.Infrastructure.Common
{
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;
        IQueryable<T> AllReadOnly<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        EntityEntry Delete<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
    }
}
