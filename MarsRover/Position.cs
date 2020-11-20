namespace MarsRover
{
    class Position : IPosition
    {
        private int _x;
        private int _y;       

        public Position(int x,int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX()
        {
            return _x;
        }
        

        public int GetY()
        {
            return _y;
        }

        public void IncrementY()        
        {
            _y += 1;
        }
        public void IncrementX()
        {
            _x += 1;
        }

        public void DecrementY()
        {
            _y -= 1;
        }
        public void DecrementX()
        {
            _x -= 1;
        }
    }
}