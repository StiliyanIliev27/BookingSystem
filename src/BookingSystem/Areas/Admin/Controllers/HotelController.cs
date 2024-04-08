using BookingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem.Areas.Admin.Controllers
{
    public class HotelController : AdminBaseController
    {
        private readonly IHotelService hotelService;

        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }
    }
}
