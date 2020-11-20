namespace MarsRover
{
    class Plateau
    {
        private static Position LowerLeft = new Position(0, 0);
        private static Position UpperRight;
        public Plateau()
        {
            
        }

        public Plateau(Position upperRight)
        {
            SetUpperRight(upperRight);            
        }
        public Position GetUpperRight()
        {
            return UpperRight;
        }

        public void SetUpperRight(Position value)
        {
            UpperRight = value;
        }

        public static bool isValid(Position position)
        {

            if(position.GetX() < 0 || position.GetX() > UpperRight.GetX() || position.GetY() < 0 || position.GetY() > UpperRight.GetY())
            {
                System.Console.WriteLine($"{position.GetX()},{position.GetY()}");
                System.Console.WriteLine($"{UpperRight.GetX()},{UpperRight.GetY()}");
                return false;
            }  
            return true;              
        }
    }
}