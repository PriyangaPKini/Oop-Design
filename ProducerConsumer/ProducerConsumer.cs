// oops model for producer consumer where every consumer can consume from the list of queue
using System.Collections.Generic;

namespace ProducerConsumerNS
{
    class ProducerConsumer
    {
        public static void Main()
        {
            List<Consumer> consumers = new List<Consumer>();
            Producer producer = new Producer();
            producer.Produce(10);

            for (int i = 0; i < 5; i++)
            {
                consumers.Add(new Consumer(){Id=i+1});
            }

            consumers[0].Consume(producer.getCount());
            consumers[1].Consume(producer.getCount());
            producer.Produce(4);
            consumers[0].Consume(producer.getCount());
            consumers[1].Consume(producer.getCount());
            consumers[1].Consume(producer.getCount());
            
            // Id of consumer to remove = 4
            var id = 4;
            var consumer = new Consumer(){Id=id};
            consumers.Remove(consumer);       

        }
    }
}