using System;
using System.Diagnostics;
using System.Threading;
namespace checkingthebest
{
    public class Program
    {
        public static void Display()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        
        static void Disp()
        {
            for (int i = 0; i < 120; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();            
            Console.WriteLine("calling first method");
            Display();
            Console.WriteLine("Calling the static method:");
            Disp();

            Stopwatch sw2 = new Stopwatch();
            Thread thread = new Thread(Disp);
            Thread thre1 = new Thread(Display);
            sw2.Start();
            thread.Start();
            thre1.Start();

            thre1.Join();
            thread.Join();
          


            Console.WriteLine("the main thread: " + sw.ElapsedMilliseconds);
            Console.WriteLine("the multithread: " + sw2.ElapsedMilliseconds);
            
   

        }
    }
}
