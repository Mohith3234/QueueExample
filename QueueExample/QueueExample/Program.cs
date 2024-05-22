using System;
using System.Collections.Generic;
namespace QueueExample
{
   class Program
    {
        static void Main()
        {
            Queue<string> queue= new Queue<string>();
            //add element to queue
            queue.Enqueue("Task1");
            queue.Enqueue("Task2");
            queue.Enqueue("Task3");
            queue.Enqueue("Task4");
            queue.Enqueue("Task5");

            //remove element from queue
            string s=queue.Dequeue();
            Console.WriteLine("Remove element From Queue : "+s);
            
            //Retrive the Element from queue
            String s1=queue.Peek();
            Console.WriteLine("retrive front element from queue : " + s1);
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
           
            Console.ReadKey();
        }
    }
}
