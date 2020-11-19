namespace MarsRover
{
    interface IRover
    {
       void Move(char command);
       void ChangeOrientation(char command);
       string Explore(string command);
    } 
}
