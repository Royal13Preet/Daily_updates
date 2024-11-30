using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace prioritythred
{
    public class Program
    {
        static long count1, count2;
        public static void Increment1()
        {
            while (true) {
                count1 += 1; 
            }
        }

        


        public static void Increment2() 
        {
            while (true) { 
                count2 += 1;
            }
        }
        static void Main(string[] args)
        {
            
            Thread thread = new Thread(Increment1);
            Thread thread2 = new Thread(Increment2);
            thread.Start();
            thread2.Start();
            thread.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Lowest;

            Console.WriteLine("The Main method start");
            Thread.Sleep(10000);
            Console.WriteLine("The Main method wokeup");

            
            
            thread.Abort();
            thread2.Abort();

            thread.Join();
            thread.Join();

           

            Console.WriteLine("the count 1: " + count1);
            Console.WriteLine("the count 2: " + count2);
        }
    }
}
