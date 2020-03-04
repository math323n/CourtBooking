using System;
using System.Collections.Generic;
using System.Text;

namespace BookingEntities
{
    public class CourtObject
    {
        protected int id;
        protected int courtNumber;
        protected DateTime bookingTime;
        protected int booker;

        public CourtObject(int id, int courtNumber, DateTime bookingTime, int booker)
        {
            Id = id;
            CourtNumber = courtNumber;
            BookingTime = bookingTime;
            Booker = booker;
        }

        public virtual int Id
        {
            get
            {
                return id;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateId(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Id), validationResult.errorMessage);
                }
                if(value != id)
                {
                    id = value;
                }
            }
        }

        public virtual int CourtNumber
        {
            get
            {
                return courtNumber;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateCourtNumber(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(CourtNumber), validationResult.errorMessage);
                }
                if(value != courtNumber)
                {
                    courtNumber = value;
                }
            }
        }

        public virtual DateTime BookingTime
        {
            get
            {
                return bookingTime;
            }
            set
            {
                if(value != bookingTime)
                {
                    bookingTime = value;
                }
            }
        }

        public virtual int Booker
        {
            get
            {
                return booker;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateId(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(Booker), validationResult.errorMessage);
                }
                if(value != booker)
                {
                    booker = value;
                }
            }
        }

        public static (bool, string) ValidateId(int id)
        {
            if(id <= 0)
            {
                return (false, "\"Id\" must not be <= 0");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        public static (bool, string) ValidateCourtNumber(int court)
        {
            if(court <= 0)
            {
                return (false, "\"CourtNumber\" must not be <= 0");
            }
            else
            {
                return (true, string.Empty);
            }
        }

        public override string ToString()
        {
            return $"Id: {id}\ncourtNumber: {courtNumber}\n" +
                $"Bookingtime: {bookingTime.ToString("dd/MM/yy")}\nBooker: {booker}";
        }
    }
}
