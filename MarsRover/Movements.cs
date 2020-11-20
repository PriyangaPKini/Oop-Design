using System;

namespace MarsRover
{
    class Movements : IMovements
    {
        public Position MoveNorth(Position position)
        {
            var newPosition = position;
            newPosition.IncrementY();
            if(!Plateau.isValid(newPosition))
            {
                throw new InvalidOperationException();
            }            
            return newPosition;            
        }

        public Position MoveEast(Position position)
        {
            var newPosition = position;
            newPosition.IncrementX();
            if(!Plateau.isValid(newPosition))
            {
                throw new InvalidOperationException();                
            }
            return newPosition;            
        }

        public Position MoveSouth(Position position)
        {
            var newPosition = position;
            newPosition.DecrementY();
            if(!Plateau.isValid(newPosition))
            {
                throw new InvalidOperationException();                
            }
            return newPosition;
            
        }

        public Position MoveWest(Position position)
        {
            var newPosition = position;
            newPosition.DecrementX();
            if(!Plateau.isValid(newPosition))
            {
                throw new InvalidOperationException();
            }
            return newPosition;            
        }

        public Direction RotateRight(Direction orientation)
        {    
            var neworientationValue = (((int)orientation) + 1) % 4;
            Direction newOrientation  = (Direction)(neworientationValue % 4);
            return newOrientation;
        }

        public Direction RotateLeft(Direction orientation)
        {
            var neworientationValue = (((int)orientation) - 1) % 4;
            neworientationValue = neworientationValue < 0 ? 4 + neworientationValue: neworientationValue;
            Direction newOrientation  = (Direction)neworientationValue; 
            return newOrientation;
        }
    }
}