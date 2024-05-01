namespace BookingSystem.Middlewares
{
    using BookingSystem.Core.Contracts;
    public class ExpiredReservationsMiddleware
    {
        private readonly RequestDelegate next;
        private readonly IServiceProvider serviceProvider;

        public ExpiredReservationsMiddleware(RequestDelegate next, IServiceProvider serviceProvider)
        {
            this.next = next;
            this.serviceProvider = serviceProvider;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await next(context);

            using(var scope = serviceProvider.CreateScope())
            {
                var reservationService = scope.ServiceProvider.GetRequiredService<IReservationService>();
                await reservationService.RemoveExpiredReservations();
            }
        }
    }
}
