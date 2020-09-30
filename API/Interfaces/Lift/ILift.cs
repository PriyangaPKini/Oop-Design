namespace API
{
    interface ILift
    {
        public void Pickup(int to, int NumOfPassengers);

        public void Drop(int to, int NumOfPassengers);
    }
}