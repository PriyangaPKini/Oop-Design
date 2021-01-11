using System.Collections.Generic;

namespace MovieTheaterNs
{
    class BookingRequest
    {
        public int ShowId { get; set; }
        public List<string> Seats { get; set; }
    }
}