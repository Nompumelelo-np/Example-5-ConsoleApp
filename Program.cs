using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \nwrap to next line");
            Console.WriteLine("This will \" print out the quotation mark.");



            string firstName = "Nompumelelo";
            string lastName = "Hlongwane";
            //concatination
            Console.WriteLine(firstName + " " + lastName);

            //functions with strings
            Console.WriteLine(lastName.Length);
            //methods on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg. the contains, its case sensitive
            Console.WriteLine(lastName. Contains("Fu"));
            //access characters using index
            Console.WriteLine(firstName[0]);
            //index of will tell you iff the value is there and at what position
            Console.Write("index of a is ");
            Console.WriteLine(lastName.IndexOf("a"));
            //subtracting, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));
            //you can also give index, ie. how many chars u want to grab
            Console.WriteLine(firstName.Substring(1,2));
            Console.Read();


                                                                                                                                                                                                                              
        }
    }
}
