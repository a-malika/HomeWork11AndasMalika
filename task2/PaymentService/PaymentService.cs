using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class PaymentService : IPaymentService
    {
        public bool ProcessPayment(User user, Booking booking, PaymentMethod method)
        {
            Console.WriteLine($"Processing payment for {user.Name} using {method}");
            return true;
        }
    }
}
