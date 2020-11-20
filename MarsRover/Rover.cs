namespace MarsRover
{
    class Rover : Movements, IRover
    {
        private Position _currentPosition;
        private Direction _orientation;

        public Rover(Position curPosition, Direction orientation)
        {
            _currentPosition = curPosition;
            _orientation = orientation;
        }           
        public string Explore(string commands)
        {
            System.Console.WriteLine("Exploring...");
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        _orientation = RotateLeft(_orientation);
                        break;
                    case 'R':
                        _orientation = RotateRight(_orientation);
                        break;
                    case 'M':
                        Move(command);
                        break;
                }
                System.Console.WriteLine($"{_currentPosition.GetX()} {_currentPosition.GetY()} {_orientation}");
            }
            return $"{_currentPosition.GetX()} {_currentPosition.GetY()} {_orientation}";
        }

        public void Move(char command)
        {
            switch (_orientation)
            {
                case Direction.N: 
                    _currentPosition = MoveNorth(_currentPosition);
                    break;

                case Direction.E: 
                    _currentPosition = MoveEast(_currentPosition);
                    break;

                case Direction.S: 
                    _currentPosition = MoveSouth(_currentPosition);
                    break;

                case Direction.W: 
                    _currentPosition = MoveWest(_currentPosition);
                    break;
            }
        }        
    }
}
