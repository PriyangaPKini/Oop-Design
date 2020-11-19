namespace MarsRover
{
    class Plateau
    {
        public static Point LowerLeft = new Point(0, 0);
        public Plateau()
        {
            
        }

        public Plateau(Point upperRight)
        {
            UpperRight = upperRight;
            
        }       

        public Point UpperRight { get; set; }        
    }
}