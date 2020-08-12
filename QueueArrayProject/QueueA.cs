using System;
using System.Xml;

namespace QueueArrayProject
{
    class QueueA
    {
        private int[] QueueArray;
        private int front=-1;
        private int rear = -1;

        public QueueA()
        {
            QueueArray = new int[10];
            front = -1;
            rear = -1;
        }

        public QueueA(int maxSize)
        {
            QueueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }

        public bool isEmpty()
        {
            return (front == -1 || front == rear+1);
        }

        public bool isFull()
        {
            return (rear == QueueArray.Length - 1);
        }

        public int Size()
        {
            if (isEmpty())
                return 0;
            else
                return rear - front + 1;
        }

        public void Insert(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            if (front == -1)
                front = 0;
            rear = rear + 1;
            QueueArray[rear] = x;
        }

        public int Delete()
        {
            int x;
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            x = QueueArray[front];
            front = front + 1;
            return x;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return QueueArray[front];
        }

        public void Display()
        {
            if (isEmpty())
                Console.WriteLine("Queue is Empty");
            Console.WriteLine("Queue is:");
            for(int i=front;i<=rear;i++)
            {
                Console.WriteLine(QueueArray[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
