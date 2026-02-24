using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class BookingHelper
    {
        private static int Counter = 0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            if (numberOfTickets >= 5)
            {
                return numberOfTickets * pricePerTicket - (numberOfTickets * pricePerTicket) * 0.1;
            }
            else
                return numberOfTickets * pricePerTicket;
        }
        public static string GenerateBookingReference()
        {
            Counter++;
            return $"BK-{Counter}";

        }
    }

}
