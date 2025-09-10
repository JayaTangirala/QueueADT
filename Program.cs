namespace QueueADT
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, Queues");
            IntegerQueue q=new IntegerQueue(6);
            q.print();
            q.enqueue(56); q.print();
            q.enqueue(42); q.print();
            q.enqueue(87); q.print();
            q.enqueue(21); q.print();
            q.enqueue(98); q.print();
            q.enqueue(30); q.print();
            q.enqueue(11);
            int element=q.dequeue();
            if(element!=-1)     
                Console.WriteLine(element + " is removed"); q.print();
            element = q.dequeue();
            if (element != -1)
                Console.WriteLine(element + " is removed"); q.print();
            element = q.dequeue();
            if (element != -1)
                Console.WriteLine(element + " is removed"); q.print();
            element = q.dequeue();
            if (element != -1)
                Console.WriteLine(element + " is removed"); q.print();
            element = q.dequeue();
            if (element != -1)
                Console.WriteLine(element + " is removed"); q.print();
            element = q.dequeue();
            if (element != -1)
                Console.WriteLine(element + " is removed"); q.print();
            element = q.dequeue();
            if (element != -1)
                Console.WriteLine(element + " is removed"); q.print();
            q.enqueue(11);
        }
    }
}