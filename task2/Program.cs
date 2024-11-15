using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHotelService hotelService = new HotelService();
            IBookingService bookingService = new BookingService();
            IPaymentService paymentService = new PaymentService();
            INotificationService notificationService = new NotificationService();
            IUserManagementService userManagementService = new UserManagementService();

            Console.WriteLine("Welcome to Hotel Booking System!");
            var user = userManagementService.Register("John Doe", "john@example.com", "password");

            var hotels = hotelService.SearchHotels("Paris");
            foreach (var hotel in hotels)
            {
                Console.WriteLine($"Hotel: {hotel.Name}");
            }

            var booking = bookingService.BookRoom(user, hotels.First(), hotels.First().Rooms.First(), DateTime.Now, DateTime.Now.AddDays(3));
            paymentService.ProcessPayment(user, booking, PaymentMethod.CreditCard);
            notificationService.SendNotification(user, "Booking confirmed!");

            Console.WriteLine("Booking successful!");
        }
    }

}
