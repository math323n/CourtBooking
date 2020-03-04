using BookingEntities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace BookingService
{
    public class CourtBookingService
    {
        readonly string url = @"https://api.aspitcloud.dk/bookings";
        protected string json;

        public virtual CourtObject GetSingleBooking(int id)
        {

            using(WebClient client = new WebClient())
            {
                json = new WebClient().DownloadString($"{url}/{id}");
            }

            CourtObject court = JsonConvert.DeserializeObject<CourtObject>(json);

            return court;
        }

        public virtual List<CourtObject> GetAllBookings()
        {
            List<CourtObject> bookings;
            string resultTask;


            using(WebClient client = new WebClient())
            {
                resultTask = new WebClient().DownloadString(url);

            }
            bookings = JsonConvert.DeserializeObject<List<CourtObject>>(resultTask);

            return bookings;
        }
    }
}