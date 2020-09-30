using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTheaterNs
{
    class Theater
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<Show> Shows { get; set; }
    }
    class Show
    {
        public int Id { get; set; }
        public Dictionary<string, bool> Seats = new Dictionary<string, bool>(){{"A1",true},{"A2", true},{"A3", true},
        {"A4", true},{"A5", true},{"B1", true},{"B2", true},{"B3", true},{"B4", true},{"B5", true}};

        public bool IsSeatAvailable(string seat)
        {
            return Seats[seat];
        }

        public void MarkAsBooked(string seat)
        {
            Seats[seat] = false;
        }

        public List<string> AvailableSeats()
        {
            return (from kvp in Seats where kvp.Value == true select kvp.Key).ToList();
        }

    }

    class BookingRequest
    {
        public int ShowId { get; set; }
        public List<string> Seats { get; set; }
    }

    class Booking
    {
        public Theater theater = new Theater();
        public bool ProcessRequest(BookingRequest request)
        {
            var show = theater.Shows[request.ShowId];
            foreach (var seat in request.Seats)
            {
                if(show.IsSeatAvailable(seat))
                {
                    show.MarkAsBooked(seat);
                }
                else
                {
                    System.Console.WriteLine($"{seat} is not available. Try another seat");
                    return false;
                }
            }
            System.Console.WriteLine("Sucessfully booked");
            foreach (var seat in show.AvailableSeats())
            {
                System.Console.Write(seat+" ");
            }
            System.Console.WriteLine("");
            return true;
        }
    }
}