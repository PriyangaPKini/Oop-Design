namespace MarsRover
{
    class Rover : IRover
    {
        public Rover(Point curPosition, Direction orientation)
        {
            _currentPosition = curPosition;
            _orientation = orientation;
        }

        private Point _currentPosition;
        private Direction _orientation;

        public void RotateRight()
        {
            if (_orientation != Direction.W)
            {
                _orientation += 1;
                return;
            }
            _orientation = Direction.N;
        }

        public void RotateLeft()
        {
            if (_orientation != Direction.N)
            {
                _orientation -= 1;
                return;
            }
            _orientation = Direction.W;
        }

        public string Explore(string commands)
        {
            System.Console.WriteLine("Exploring...");
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    case 'M':
                        Move(command);
                        break;
                }
            }
            return $"{_currentPosition.X} {_currentPosition.Y} {_orientation}";
        }

        public void Move(char command)
        {
            switch (_orientation)
            {
                case Direction.N:
                    _currentPosition.Y += 1;
                    break;

                case Direction.E:
                    _currentPosition.X += 1;
                    break;

                case Direction.S:
                    _currentPosition.Y -= 1;
                    break;

                case Direction.W:
                    _currentPosition.X -= 1;
                    break;
            }
        }
    }
}
