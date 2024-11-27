using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errorclearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{

            //        int[] arr = { 5, 6, 3, 5 };
            //        for (int i = 0; i <= arr.Length; i++) // Out of bounds for i = 4
            //        {
            //            Console.WriteLine(arr[i]);
            //        }


            //}
            //catch (IndexOutOfRangeException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    string str = null;
            //    Console.WriteLine(str.Length);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    string data;
            //    string fp = @"C:/pree";
            //    FileStream aa = new FileStream(fp, FileMode.Open);
            //    using (StreamReader st = new StreamReader(aa))
            //    {
            //        data = st.ReadToEnd();

            //    }

            //    Console.WriteLine(data);
            //}
            //catch (FileNotFoundException e) {
            //    Console.WriteLine(e.Message);
            //}
            object obj = "Hello";
            int num = (int)obj;
            //try
            //{
            //    object obj = "Hello";
            //    int num = (int)obj; // Causes InvalidCastException
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}







        }


    }
}





