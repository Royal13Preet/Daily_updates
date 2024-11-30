using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Parameterthread
{
    public class Program
    {
        public static void display(object x)
        {
            int num = (int)x;
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine(i);
            }
            
        }
        static void Main(string[] args)
        {
            Thread obj = new Thread(display);
            obj.Start(90);

            

        }
    }
}
