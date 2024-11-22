using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goodmorning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //How to get word “nice day” from the sentence “Good morning. Have a nice day”?


            string str1 = "Good morning. Have a nice day";


 
                string sentence = "Good have nice morning. Have a nice day";

                // Find the starting position of "nice"
                int startIndex = sentence.IndexOf("nice");

                // If "nice" is found, extract "nice day"
                if (startIndex != -1)
                {
                    string result = sentence.Substring(startIndex); // Extract from "nice" to the end
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("The word 'nice' was not found in the sentence.");
                }
         
        


        //string str1 = "Good Morning Alexa";
        //string str5 = "";
        //string str2 = str1.Replace( "Morning", "Evening");
        //Console.WriteLine(str2);
        //string[] str7 = str1.Split(' ');
        //foreach (string str3 in str7) {

        //    if (str3 == "Morning")
        //    {
        //        str5 += "Evening";

        //    }
        //    else
        //    {
        //        str5 += str3;
        //    }
        //    //Regural expression

        //}
        //Console.WriteLine(str5);


    }
}
}
