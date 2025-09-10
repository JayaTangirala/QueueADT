using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QueueADT
{
    internal class IntegerQueue
    {
        private int[] queue;
        private int rear, front, maxSize;

        public IntegerQueue(int n)
        {
            maxSize = n;
            queue = new int[maxSize]; //allocate space to array of size n
            front = rear = -1;        // No elements in the queue initially.
        }
        public bool isEmpty()
        {
            if (front == -1 || front > rear)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            if (rear == maxSize - 1)
                return true;
            else
                return false;
        }
        public void enqueue(int element)
        {
            // Verifies whether queue is full. 
            // If full, prints queue overflow message. 
            // Otherwise, inserts element at fron of the queue

            if (isFull())
                Console.WriteLine("Queue Overflow");
            else
            {
                if (front == -1)
                    front = 0;
                rear = rear + 1;
                queue[rear] = element;

            }
        }
        public int dequeue()
        {
            // Verifies whether queue is empty. 
            // If empty, prints queue underflow message. 
            // Otherwise, removes element at front and returns it.

            if (isEmpty())
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }
            else
            {
                int element = queue[front];
                front = front + 1;
                return element;
            }
        }
        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Queue is Empty!");
            else
            {               
                for (int i = front; i <= rear; i++)
                    Console.Write(queue[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
