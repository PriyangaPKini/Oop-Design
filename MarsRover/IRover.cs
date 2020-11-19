namespace MarsRover
{
    interface IRover
    {
       void Move(char command);
       void RotateLeft();
       void RotateRight();
       string Explore(string command);
    } 
}
