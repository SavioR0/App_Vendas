using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace teste.ca
{
    class Program
    {
        static void Main()
        {
            List<int> lista = new List<int>
            {
                3,
                -3,
                6,
                7
            };

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);


            queue.Dequeue();
            queue.Dequeue();

            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            stack.Pop();



            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------------");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

        }
    }
}
