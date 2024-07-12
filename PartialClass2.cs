using System;

namespace CRUX
{
    partial class PartialClass
    {
        //we can declare constructor only once
        //constructors with different parameters can be declared in different files
        public PartialClass()
        {
            Console.WriteLine("constructor declared in partial class 2");
        }

        public void Print()
        {
            Console.WriteLine("Partial class 2");
        }
    }
}
