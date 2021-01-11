namespace MovieTheaterNs
{
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