using System;
using System.Collections.Generic;
using System.Text;

namespace QueueArrayProject
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;

            QueueA quA = new QueueA(8);

            while(true)
            {
                Console.WriteLine("1.Insert an element in Queue");
                Console.WriteLine("2.Delete an element from Queue");
                Console.WriteLine("3.Display front element");
                Console.WriteLine("4.Display all elements of Queue");
                Console.WriteLine("5.Display Size of Queue");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;
                
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be inserted:");
                        x= Convert.ToInt32(Console.ReadLine());
                        quA.Insert(x);
                        break;
                    case 2:
                        Console.WriteLine("Deleted element is: " + quA.Delete());
                        break;
                    case 3:
                        Console.WriteLine("Front Element is: " + quA.Peek());
                        break;
                    case 4:
                        quA.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of Queue is: " + quA.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice:");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
