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
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            lista.Add(3);
            lista.Add(-3);
            lista.Add(6);
            lista.Add(7);

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


            Dictionary<string, int> dic = new Dictionary<string, int>();

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
