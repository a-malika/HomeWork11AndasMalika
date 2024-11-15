using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Booking
    {
        public User User { get; set; }
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }
        public BookingStatus Status { get; set; }

        public Booking(User user, Hotel hotel, Room room, DateTime startDate, DateTime endDate, decimal totalAmount)
        {
            User = user;
            Hotel = hotel;
            Room = room;
            StartDate = startDate;
            EndDate = endDate;
            TotalAmount = totalAmount;
            Status = BookingStatus.Pending;
        }
    }

    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }

}
