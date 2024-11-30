using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lockexample
{
    public class Program
    {
        public void display()
        {
            lock (this)
            {
                Console.Write("[c# is the");
                Thread.Sleep(10000);
                Console.WriteLine("object oriented launguage");
            }
        }
   
        static void Main(string[] args)
        {
            Program obj5 = new Program();
            Thread obj = new Thread(obj5.display);
            Thread obj1 = new Thread(obj5.display);
            Thread obj3 = new Thread(obj5.display);
            obj.Start();
            obj1.Start();
            obj3.Start ();

        }
    }
}
