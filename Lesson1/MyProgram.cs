using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    /* 
        namespaces are used to organize classes 
        they uniquely identify classes
        namespaces and class name are combined for the fully qualified class name
        each fully qualified name should be unique
    */

    class Program
    {
        /*
            classes are organized in namespaces
            best practice is to have one class per file
        */
        static void Main(string[] args)
        {
            // Semi colons are not optional in C#
            Console.WriteLine("This is my first program in C#");
            Console.WriteLine("One of many to come");
            Console.WriteLine("Please press the enter key: ");
            Console.ReadLine();
        }
    }
}

//dotnet run in the terminal