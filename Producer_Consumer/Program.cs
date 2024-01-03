using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 40);




            Print();








            //var queue = new ConcurrentQueue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);


            //bool successPeek = queue.TryPeek(out int peekRes);
            //bool SuccessDequeue = queue.TryDequeue(out int  dequeueRes);

            //Console.WriteLine(successPeek);
            //Console.WriteLine(SuccessDequeue);

            //Enumerate<int>(queue);





            Console.ReadKey();

        }

        static async Task Print()
        {
            await Task.Run(() => Console.WriteLine("Await"));

            Console.WriteLine("Print Method");
        }
        public static void Enumerate<T>(IEnumerable<T> queue)
        {
            Console.WriteLine();
            Console.WriteLine("Elements quantity: " + queue.Count());
            Console.WriteLine("Elements: ");

            foreach(var item in queue)
            {
                Console.Write(item+ ", ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 80));
        }
    }
}
