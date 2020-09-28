using System.Collections.Generic;

namespace API
{
    interface ILiftHandler
    {
        public void ProcessRequest();
        public void RequestForHall(int srcFloor, int destFloor);
        
    }
}