using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieTheaterNs
{
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
}