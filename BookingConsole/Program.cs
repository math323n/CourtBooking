using BookingEntities;
using BookingService;
using System;
using System.Collections.Generic;

namespace BookingConsole
{
    public class Program
    {
        public static CourtBookingService bookService = new CourtBookingService();

        static void Main()
        {
            GetSingle();
            Console.WriteLine();
            GetAll();
        }

        public static void GetSingle()
        {
            CourtObject testObject = bookService.GetSingleBooking(2);
            Console.WriteLine(testObject);
        }

        public static void GetAll()
        {
            List<CourtObject> courts = bookService.GetAllBookings();

            foreach(CourtObject court in courts)
            {
                Console.WriteLine(court + "\n");
            }
        }
    }
}