using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            str1 += "jj";
            Console.WriteLine(str1);

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("str1");
            sb1.Append("Hello");
            Console.WriteLine(sb1);

           
        }
    }
}
