namespace BookingSystem.Infrastructure.Common
{
    using BookingSystem.Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;

    public class Repository : IRepository
    {
        private readonly BookingSystemDbContext context;

        public Repository(BookingSystemDbContext context)
        {
            this.context = context;
        }

        private DbSet<T> DbSet<T>() where T : class => context.Set<T>();
      
        public IQueryable<T> All<T>() where T : class => DbSet<T>();

        public IQueryable<T> AllReadOnly<T>() where T : class => DbSet<T>().AsNoTracking();
    }
}
