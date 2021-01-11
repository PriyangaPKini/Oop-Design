namespace HotelManagementNS
{
    public enum CustomerType
    {
        Regular, Rewardee
    }
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Zipcode { get; set; }
        public int Rating { get; set; }
        public CustomerType Customer { get; set; }
        public bool IsWeekend { get; set; }
    }
}