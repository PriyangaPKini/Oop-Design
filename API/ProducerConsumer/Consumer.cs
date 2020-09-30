// oops model for producer consumer where every consumer can consume from the list of queue
using System;

namespace ProducerConsumerNS
{
    class Consumer
    {
        public int Id { get; set; }
        public bool HasConsumed { get; set; }
        public void Consume()
        {
            if (HasConsumed == true)
                throw new Exception("Consumer had already consumed");
            else
                System.Console.WriteLine($"Consumer {Id} consumed");
                HasConsumed = true;
        }
    }
}