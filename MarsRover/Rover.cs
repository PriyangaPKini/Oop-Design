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

        public void ChangeOrientation(char command)
        {
            if (command == 'L')
            {
                if (_orientation == Direction.N)
                {
                    _orientation = Direction.W;
                }
                else
                {
                    _orientation -= 1;
                }
            }
            else if (command == 'R')
            {
                if (_orientation == Direction.W)
                {
                    _orientation = Direction.N;
                }
                else
                {
                    _orientation += 1;
                }
            }
        }

        public string Explore(string commands)
        {
            System.Console.WriteLine("Exploring...");
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        ChangeOrientation(command);
                        break;
                    case 'R':
                        ChangeOrientation(command);
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
