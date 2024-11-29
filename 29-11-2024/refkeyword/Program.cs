using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refkeyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "Greek";
            SetValue(ref str);
            Console.WriteLine(str);
        }
        
        static void SetValue(ref string str)
        {
            str = "Hello";

        }
    }
}
