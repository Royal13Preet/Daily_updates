using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outandref
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int g;
            sum(out g);
            Console.WriteLine("The some of ; {0}", g);
        }
        
        public static void sum(out int g)
        {
            g = 20;
            g += g;
        }


        
    }
}

      


