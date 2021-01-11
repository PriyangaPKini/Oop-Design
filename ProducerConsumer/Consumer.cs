// oops model for producer consumer where every consumer can consume from the list of queue
using System;

namespace ProducerConsumerNS
{
    class Consumer
    {
        public int Id { get; set; }
        private int LastConsumed { get; set; }
        public void Consume(int index)
        {
            if (LastConsumed == index)
                // System.Console.WriteLine($"Consumer {Id} had already consumed all items");
                throw new InvalidOperationException($"Consumer {Id} had already consumed all items");
            else               
                LastConsumed = index;
                System.Console.WriteLine($"Consumer {Id} consumed {LastConsumed}");
        }
    }
}