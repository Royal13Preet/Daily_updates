using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threading
{
    public class Program
    {
        static void display()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }
            Thread.Sleep(10000);
            Console.WriteLine("the first display");
        }
        static void display2()
        {
            for(int i = 40;i < 110; i++) {
                {
                    Console.WriteLine(i);

                } }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Method Start");
            ThreadStart threadStart = new ThreadStart(display);
            ThreadStart threadEnd = new ThreadStart(display2);
            Thread obj = new Thread(threadStart);
            obj.Start();
            Thread obj2 = new Thread(threadEnd);
            
           
            obj2.Start();
            //obj.Join();
            //obj2.Join();
            Console.WriteLine("Method end");
            //display();
            //display2();

        }
    }
}
