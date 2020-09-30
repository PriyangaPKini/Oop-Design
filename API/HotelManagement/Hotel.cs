using System;
using System.Collections.Generic;

namespace HotelManagementNS
{
    class Hotel
    {
        public Hotel()
        {
            Branches = new List<Branch>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Branch> Branches { get; set; }
        private int _price { get; set; }
        private Branch _cheapestHotel { get; set; }
        public int getPrice(string name, CustomerType ct, bool isWeekend)

        {
            switch (name)
            {
                case "x":
                    if (ct == CustomerType.Regular && isWeekend == false)
                    {
                        _price = 100;
                    }
                    else if (ct == CustomerType.Regular && isWeekend == true)
                    {
                        _price = 120;
                    }
                    else if (ct == CustomerType.Rewardee && isWeekend == false)
                    {
                        _price = 90;
                    }
                    else if (ct == CustomerType.Rewardee && isWeekend == true)
                    {
                        _price = 60;
                    }
                    break;
                case "y":
                    if (ct == CustomerType.Regular && isWeekend == false)
                    {
                        _price = 130;
                    }
                    else if (ct == CustomerType.Regular && isWeekend == true)
                    {
                        _price = 150;
                    }
                    else if (ct == CustomerType.Rewardee && isWeekend == false)
                    {
                        _price = 100;
                    }
                    else if (ct == CustomerType.Rewardee && isWeekend == true)
                    {
                        _price = 95;
                    }
                    break;
                case "z":
                    if (ct == CustomerType.Regular && isWeekend == false)
                    {
                        _price = 195;
                    }
                    else if (ct == CustomerType.Regular && isWeekend == true)
                    {
                        _price = 150;
                    }
                    else if (ct == CustomerType.Rewardee && isWeekend == false)
                    {
                        _price = 120;
                    }
                    else if (ct == CustomerType.Rewardee && isWeekend == true)
                    {
                        _price = 90;
                    }
                    break;
            }
            return _price;
        }

        public void CalculatePrice(CustomerType ct, List<bool> days)
        {
            int numOfDays = days.Count;
            int priceOfX = 0;
            int priceOfY = 0;
            int priceOfZ = 0;
            for (int i = 0; i < numOfDays; i++)
            {
                priceOfX += getPrice("x", ct, days[i]);
                priceOfY += getPrice("y", ct, days[i]);
                priceOfZ += getPrice("z", ct, days[i]);
            }
            if (priceOfX == priceOfY && priceOfY == priceOfZ)
            {
                _price = priceOfY;
                _cheapestHotel = Branches[1];
            }
            else
            {
                _price = Math.Min(Math.Min(priceOfX, priceOfY), priceOfZ);
                if(_price == priceOfX)
                   _cheapestHotel = Branches[0];
                else if(_price == priceOfY)
                   _cheapestHotel = Branches[1];
                else if(_price == priceOfZ)
                   _cheapestHotel = Branches[2];
            }
            System.Console.WriteLine($"{priceOfX}, {priceOfY}, {priceOfZ}");
        }

        public void ShowDetails(CustomerType ct, List<bool> days)
        {
           CalculatePrice(ct, days);
           System.Console.WriteLine($"Name : { _cheapestHotel.Name}");
           System.Console.WriteLine($"Location : {_cheapestHotel.Location}");
           System.Console.WriteLine($"Zipcode : {_cheapestHotel.Zipcode}");
           System.Console.WriteLine($"Rating : {_cheapestHotel.Rating}");
           System.Console.WriteLine($"Price : ${_price}");
        }        
    }
}