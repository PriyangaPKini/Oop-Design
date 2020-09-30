using System.Collections.Generic;
using System;
namespace API
{
    class LiftHandler : ILiftHandler
    {
        private Lift _lift;

        public LiftHandler()
        {
            _lift = Lift.GetLift();
        }

        public void RequestForHall(int from, int to)
        {
            if (from == to || from < 0 || to < 0 || from > Lift._maxFloor || to > Lift._maxFloor) throw new ArgumentException();
            _lift.request[to] = 1;
            _lift.fromTo[from].Add(to);
        }

        public void ProcessRequest()
        {
            for (int i = Lift._minFloor; i < Lift._maxFloor; i++)
            {
                if (_lift.request[i] == 0) continue;
                System.Console.WriteLine(string.Format("Floor {0}", i));
                System.Console.Write("Enter the number of passengers stepped out :");
                var passengers = Convert.ToInt32(System.Console.ReadLine());
                _lift.Drop(i, passengers);
                System.Console.Write("Enter the number of passengers stepped in :");
                passengers = Convert.ToInt32(System.Console.ReadLine());
                _lift.Pickup(i, passengers);
            }            
            if(_lift.Count > 0)
                System.Console.Write($"{_lift.Count} passengers stepped out at floor 0");
        }
    }
}