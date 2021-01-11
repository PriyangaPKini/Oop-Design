using System.Collections.Generic;

namespace HotelManagementNS
{
    class HotelManagement
    {
        public static void Main()
        {
            Hotel hotel = new Hotel();
            hotel.Branches.Add(new Branch(){Name="x", Location="abc", Zipcode = 12345, Rating = 3});
            hotel.Branches.Add(new Branch(){Name="y", Location="bcd", Zipcode = 12347, Rating = 5});
            hotel.Branches.Add(new Branch(){Name="z", Location="cde", Zipcode = 12349, Rating = 4});
            hotel.ShowDetails(CustomerType.Rewardee,new List<bool>(){true,true,true});
        }
    }
}