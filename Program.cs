using System;

namespace CRUX
{
    public class Program
    {
        static void Main(string[] args)
        {

            //PartialClass class can be defined in multiple folders this is used to segregate long codes into separate files.
            //At compile time a single file will be generated from multiple files
            PartialClass partial = new PartialClass();
            partial.Display();
            partial.Print();
            Console.ReadLine();
        }
    }

}