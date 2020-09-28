using System;
using System.Linq;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            LiftHandler handler = new LiftHandler();
            System.Console.Write("Enter the number of requests: ");
            var n = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Enter the requests. eg: 2 3 where 2 is source Floor, 3 is destination floor");
            while(n > 0)
            {
                var req = Console.ReadLine().Split().Select( p => Convert.ToInt32(p.Trim())).ToList();
                handler.RequestForHall(req[0], req[1]); 
                n--;   
            }             
            handler.ProcessRequest();                 
        }
    }
}
