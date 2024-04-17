using BookingSystem.Core.Contracts;
using BookingSystem.Core.Models.User;
using BookingSystem.Core.Services;
using BookingSystem.Infrastructure.Common;
using BookingSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Tests.UnitTests
{
    [TestFixture]
    public class UserServiceTests
    {
        private BookingSystemDbContext dbContext;

        private IEnumerable<ApplicationUser> users;

        private IRepository repository;
        private IUserService service;

        #region Users
        private ApplicationUser FirstUser { get; set; }
        private ApplicationUser SecondUser { get; set; }

        #endregion

        [SetUp]
        public void Setup()
        {
            #region Users

            FirstUser = new ApplicationUser()
            {
                Id = "firstUserId",
                UserName = "firstUser@mail.com",
                NormalizedUserName = "FIRSTUSER@MAIL.COM",
                Email = "firstUser@mail.com",
                NormalizedEmail = "FIRSTUSER@MAIL.COM",
                FirstName = "Stiliyan",
                LastName = "Iliev"
            };

            SecondUser = new ApplicationUser()
            {
                Id = "secondUserId",
                UserName = "secondUser@mail.com",
                NormalizedUserName = "SECONDUSER@MAIL.COM",
                Email = "secondUser@mail.com",
                NormalizedEmail = "SECONDUSER@MAIL.COM",
                FirstName = "Bogdan",
                LastName = "Slavchev"
            };

            users = new List<ApplicationUser>()
            {
                FirstUser, SecondUser
            };

            #endregion

            var dbContextOptions = new DbContextOptionsBuilder<BookingSystemDbContext>()
                            .UseInMemoryDatabase("BookingSystemInMemoryDb" + Guid.NewGuid().ToString())
                            .Options;

            dbContext = new BookingSystemDbContext(dbContextOptions);

            dbContext.AddRangeAsync(users);
            dbContext.SaveChangesAsync();

            repository = new Repository(dbContext);
            service = new UserService(repository);
        }

        [TearDown]
        public async Task Teardown()
        {
            await dbContext.Database.EnsureDeletedAsync();
            await dbContext.DisposeAsync();
        }

        [Test]
        public async Task Test_AllAsync_ShouldWorkProperly()
        {
            var result = await service.AllAsync();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));

            Assert.That(result.First().Id, Is.EqualTo("firstUserId"));
            Assert.That(result.First().FullName, Is.EqualTo("Stiliyan Iliev"));
            Assert.That(result.First().Email, Is.EqualTo("firstUser@mail.com"));
           
            Assert.That(result.Skip(1).First().Id, Is.EqualTo("secondUserId"));
            Assert.That(result.Skip(1).First().FullName, Is.EqualTo("Bogdan Slavchev"));
            Assert.That(result.Skip(1).First().Email, Is.EqualTo("secondUser@mail.com"));
        }
    }  
}
