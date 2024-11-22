using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //String name = "Dr.Gupta";
            //Console.WriteLine("Good Morning" + name);

            //Char a = 'A';
            //string b = "a";
            //Console.WriteLine(Convert.ToInt32(a));
            //Console.WriteLine(Convert.ToInt32(Convert.ToChar(b)));
            //Console.ReadLine();

            //int a = 5;
            //int b = 10;
            //int c;
            //Console.WriteLine(c = ++a + b++);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //const int a = 5;
            //const int b = 6;
            //for(int i = 1; i<=5; i++)
            //{
            //    a = a * i;
            //    b = b * i;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadLine();

            //int a = 5;
            //int b = 10;
            //int c;
            //Console.WriteLine(c = a-- - ++b);
            //Console.WriteLine(b);

            //int a, b;
            //a = (b = 10) + 5;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //string Name = "He is playing in a ground.";
            //char[] characters = Name.ToCharArray();
            //StringBuilder sb = new StringBuilder();
            //for(int i=Name.Length-1; i>=0; i--)
            //{
            //    sb.Append(characters[i]);
            //}
            //Console.Write(sb.ToString());

            //int i;
            //for(i = 0; i<5; i++)
            //{
            //    int j = 0;
            //    j += i;
            //    Console.WriteLine(j);
            //}
            //Console.WriteLine(i);
            //Console.ReadLine();

            //static int m;
            //int n;
            //void fun(int x, ref int y, out int z, int[] a)
            //{
            //    int j = 10;
            //}

            //int i = 546;
            //object o = i;
            //int n = (int)o;
            //o = 70;
            //Console.WriteLine(n);
            //Console.WriteLine(o);

            //int i;
            //for(i=0; i<5; i++)
            //{

            //}
            //Console.WriteLine(i);
            //Console.ReadLine();

            //int a = 76;
            //char b;
            //b = (char)a;
            //Console.WriteLine(b);

            //int num1 = 20000;
            //int num2 = 50000;
            //long total;
            //total = num1 + num2;
            //Console.WriteLine(total);
            //Console.ReadLine();

            //int a = 22;
            //long b = 44;
            //double c = 1.406;
            //b = a;
            //c = a;
            //a = b;
            //b = c;

            float sum;
            int i;
            sum = 0.0F;
            for(i =1; i <=10; i++)
            {
                sum = sum + 1 / (float)i;
            }
            Console.WriteLine(sum);

        }
    }
}
