using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Filewrite
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fp = @"C:\Users\preethu\FirstFile.txt"; // Added .txt extension
            
            using (FileStream ab = new FileStream(fp, FileMode.Truncate))
            using (StreamWriter bb = new StreamWriter(ab))
            {
                bb.WriteLine("Hii");
                bb.WriteLine("Ehat!");
            }
            Console.WriteLine("File is writed");

            //Write data to the file
            using (FileStream ab = new FileStream(fp, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(ab))
            {
                sw.WriteLine("Hello! from this side");
                sw.WriteLine("Hi Khushi!! How are you, dear?");
            }
            Console.WriteLine("The file has been created and data has been written.");

            //Read data from the file

            string data;
            using (FileStream fpp = new FileStream(fp, FileMode.Open, FileAccess.Read))
            using (StreamReader sr = new StreamReader(fpp))
            {
                data = sr.ReadToEnd();
            }
            Console.WriteLine("Content of the file:");
            Console.WriteLine(data);
        }
    }
    
}










    

