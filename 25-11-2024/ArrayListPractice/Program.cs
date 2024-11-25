using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            ////Adding elements to ArrayList using Add() method
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add(101); //Adding Integer Value
            //arrayList1.Add("James"); //Adding String Value
            //arrayList1.Add(true); //Adding Boolean
            //arrayList1.Add(4.5); //Adding double

            ////Accessing individual elements from ArrayList using Indexer
            //int firstElement = (int)arrayList1[0]; //returns 101
            //string secondElement = (string)arrayList1[1]; //returns "James"
            //                                              //int secondElement = (int) arrayList1[1]; //Error: cannot cover string to int
            //Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");

            ////Using var keyword without explicit casting
            //var firsItem = arrayList1[0]; //returns 101
            //var secondItem = arrayList1[1]; //returns "James"
            //                                //var fifthElement = arrayList1[5]; //Error: Index out of range
            //Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");

            ////update elements
            //arrayList1[0] = "Smith";
            //arrayList1[1] = 1010;
            ////arrayList1[5] = 500; //Error: Index out of range

            //foreach (var item in arrayList1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.ReadKey();

            //Adding elements to ArrayList using Add() method
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add(101); //Adding Integer Value
            //arrayList1.Add("James"); //Adding String Value
            //arrayList1.Add(true); //Adding Boolean
            //arrayList1.Add(4.5); //Adding double

            ////Iterating through foreach loop
            //Console.WriteLine("Using ForEach Loop");
            //foreach (var item in arrayList1)
            //{
            //    Console.Write($"{item} ");
            //}

            ////Iterating through for loop
            //Console.WriteLine("\n\nUsing For Loop");
            //for (int i = 0; i < arrayList1.Count; i++)
            //{
            //    Console.Write($"{arrayList1[i]} ");
            //}
            //Console.ReadKey();

            //Creating a Collection using Array List
            ArrayList numberArray = new ArrayList();
            numberArray.Add(10);
            numberArray.Add(200);
            numberArray.Remove(20);

            //No CompileTime Error
            numberArray.Add("Pranaya");
            for (int i = 0; i < numberArray.Count; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            //            //We Get Runtime Error, when we access the 3rd Element
            foreach (var no in numberArray)
            {
                Console.WriteLine(no);
            }

            //            Console.ReadKey();

            //    }
        }
        }
}
   