using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorsss
{
    public class Program
    {
            public int Number;
            public static string StaticField;

            // Default Constructor
            public Program()
            {
                Number = 0;
                Console.WriteLine("Default Constructor Called");
            }

            // Parameterized Constructor
            public Program(int num)
            {
                Number = num;
                Console.WriteLine($"Parameterized Constructor Called with Number: {num}");
            }

            // Copy Constructor
            public Program(Program other)
            {
                Number = other.Number;
                Console.WriteLine("Copy Constructor Called");
            }

            // Static Constructor
            static Program()
            {
                StaticField = "Static Initialized";
                Console.WriteLine("Static Constructor Called");
          
            }

            // Private Constructor
            private Program(string message)
            {
                Console.WriteLine($"Private Constructor Called: {message}");
            }

            public static void Main()
            {
                // Default Constructor
            //    Program obj1 = new Program();

            //// Parameterized Constructor
            //Program obj2 = new Program(42);

            //// Copy Constructor
            //Program obj3 = new Program(obj2);

                // Static Constructor (Called automatically once)
                Console.WriteLine($"Static Field Value: {Program.StaticField}");
            }
        }

    }

