namespace MarsRover
{
    interface IMovements
    {
        Position MoveNorth(Position position);
        Position MoveEast(Position position);
        Position MoveSouth(Position position);
        Position MoveWest(Position position);
        
       Direction RotateLeft(Direction orientation);
       Direction RotateRight(Direction orientation);
    }
}