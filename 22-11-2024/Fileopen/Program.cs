using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileopen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fp = @"C:\Users\preethu\Word.txt";
            FileStream ab = new FileStream(fp, FileMode.Create);
            ab.Close();
            Console.WriteLine("Hello world!!");
        }
    }
}
