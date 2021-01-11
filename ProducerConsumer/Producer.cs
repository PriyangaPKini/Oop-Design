/* oops model for producer consumer
1 producer , N consumers
Write the code such that producer can produce any number of items.
A new consumer can be added and a consumer can be removed at any pt of time.
Consumers can consume all the available items at any time.
If one consumer consumes an item it doesn't mean it becomes unavailable to other consumers
Create 2 class Producer and Consumer
And write the suitable methods
*/
using System.Collections.Generic;

namespace ProducerConsumerNS
{
    class Producer
    {
        private List<int> Items { get; set; }
        public Producer()
        {
            Items = new List<int>();
        }

        public void Produce(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Items.Add(i+Items.Count);
            }
        }

        public int getCount()
        {
            return Items.Count;
        }
    }
}