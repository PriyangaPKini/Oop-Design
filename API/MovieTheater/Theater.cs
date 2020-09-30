using System.Collections.Generic;

namespace MovieTheaterNs
{
    class Theater
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<Show> Shows { get; set; }
    }
}