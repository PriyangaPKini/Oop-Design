using System.Collections.Generic;
using System;

namespace API
{
    public enum Directions { None, Up, Down }

    class Lift : ILift
    {
        public const int _maxFloor = 10;
        public const int _minFloor = 0;
        private int _capacity = 20;
        public int Count { get; set; }
        public Directions Direction { get; set; }

        public Floor CurrentFloor { get; set; }

        public List<int>[] fromTo = new List<int>[_maxFloor];
        public int[] request = new int[_maxFloor];
        private Lift()
        {
            for (int i = 0; i < _maxFloor; i++)
            {                
                fromTo[i] = new List<int>();
            }
        }
        public void Pickup(int to, int NumOfPassengers)
        {
            var availableSpace = _capacity - Count;
            if (NumOfPassengers > availableSpace)
            {
                throw new InvalidOperationException("Lift capacity exceeded");
                // System.Console.WriteLine("Lift capacity exceeded.");                
                // return ;
            }
            Count += NumOfPassengers;
            foreach (var req in fromTo)
            {
                req.Remove(to);
            }
        }

        public void Drop(int to, int NumOfPassengers)
        {
            if (Count < NumOfPassengers)
            {
                throw new ArgumentException();
                // System.Console.WriteLine("Invalid Argument");
                // return ;
            }
            Count -= NumOfPassengers;
            foreach (var req in fromTo)
            {
                req.Remove(to);
            }
            request[to] = 0;
        }

        public static Lift GetLift()
        {
            return Nested.Instance;
        }

        class Nested
        {
            internal static Lift Instance = new Lift();
            static Nested()
            {

            }
        }
    }
}