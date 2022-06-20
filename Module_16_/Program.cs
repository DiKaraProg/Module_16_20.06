using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module_16_
{
    internal class Program
    {
        public static string o = "hi";
        public async static  void Print1()
        {
            var thread = Thread.CurrentThread;
            
            
               
                Console.WriteLine($"{thread.Name} - Start");
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Thread call number -{i} - {thread.Name}");
                    await Task.Delay(200);
                }
                Console.WriteLine($"{thread.Name} - Stop");
            
           
        }
        public async static  void Print2()
        {
            var thread = Thread.CurrentThread;
           
                
                Console.WriteLine($"{thread.Name} - Start");
                for (int i = 0; i < 50; i++)
                {

                    Console.WriteLine($"Thread call number -{i} {thread.Name}");
                    await Task.Delay(100);
                }
                Console.WriteLine($"{thread.Name} - Stop ");
            
        }

        static void Main(string[] args)
        {
            var main = Thread.CurrentThread;
            main.Name = "Main thread";

            Console.WriteLine($"{main.Name}- Start");
            
            Thread t1 = new Thread(Print1);
            t1.Name = "Thread-1";
            Thread t2 = new Thread(Print2);
            t2.Name = "Thread-2";
            t1.Start();
            t2.Start();
            Console.WriteLine($"{main.Name} - Stop");
            Console.ReadLine();
        }
    }
}
