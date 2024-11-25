using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class Program
    {
        public static void m1()
        {
            for (int i = 0; i < 19; i++)
            {
                Console.WriteLine(i);
                //Thread.Sleep(1000);
            }
        }
        public static void m2()
        {
            for (int k = 20; k < 40; k++)
            {
                Console.WriteLine(k);
            }
        }
        public static void Main(String[] args)
        {
            ThreadStart ss = new ThreadStart(Program.m1);
            ThreadStart s3 = new ThreadStart(Program.m2);
            Thread th = new Thread(ss);
            Thread th1 = new Thread(s3);
            Thread t = Thread.CurrentThread;
            t.Name = "First Thread";
            Console.WriteLine("Thread Name : {0}", t.Name);
            Console.WriteLine("Thread Priority : {0}", t.Priority);
            Console.ReadKey();
            th.Start();
            th.Abort();
            
           
            th1.Start();
            
            //th1.Abort();



        }

    }
}

