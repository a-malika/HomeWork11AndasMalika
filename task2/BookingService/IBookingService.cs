using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public interface IBookingService
    {
        Booking BookRoom(User user, Hotel hotel, Room room, DateTime startDate, DateTime endDate);
        bool CheckAvailability(Hotel hotel, Room room, DateTime startDate, DateTime endDate);
    }
}
