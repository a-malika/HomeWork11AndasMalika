using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class BookingService : IBookingService
    {
        private List<Booking> bookings = new List<Booking>();
        public Booking BookRoom(User user, Hotel hotel, Room room, DateTime startDate, DateTime endDate)
        {
            if (!CheckAvailability(hotel, room, startDate, endDate))
                throw new Exception("Room is not available.");

            var booking = new Booking(user, hotel, room, startDate, endDate, room.Price);
            bookings.Add(booking);
            return booking;
        }
        public bool CheckAvailability(Hotel hotel, Room room, DateTime startDate, DateTime endDate)
        {
            return !bookings.Any(b => b.Hotel == hotel &&
                                      b.Room == room &&
                                      b.StartDate < endDate &&
                                      b.EndDate > startDate);
        }
    }
}
