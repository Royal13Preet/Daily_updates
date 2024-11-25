using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPracrtice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };


            Console.WriteLine("Original Array Elements :");
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + " ");
            }
            Console.WriteLine();
           
            //Array.Sort(Numbers);

            //Console.WriteLine("\nArray Elements After Sorting :");
            //foreach (int i in Numbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            ////Reversing the array elements by using the Reverse method of Array Class
            //Array.Reverse(Numbers);
            ////Printing the Array Elements in Reverse Order
            //Console.WriteLine("\nArray Elements in the Reverse Order :");
            //foreach (int i in Numbers)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();


            //int[] NewNumbers = new int[10];

            //Array.Copy(Numbers, NewNumbers, 6);

            ////Printing the Array Elements using for Each Loop
            //Console.WriteLine("\nNew Array Elements :");
            //foreach (int i in NewNumbers)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine($"\nNew Array Length using Length Property :{NewNumbers.Length}");
            //Console.WriteLine($"New Array Length using GetLength Method :{NewNumbers.GetLength(0)}");
            //Console.ReadKey();

            //var Numbers = new[] { 10, 0, 30, 40, 50 };
           
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Console.Write(Numbers[i] + " ");
            //    }
            //    Console.ReadKey();
            
        }
    }
}
 