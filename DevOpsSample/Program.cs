using System;

namespace DevOpsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            NewMethod();
        }

        private static void NewMethod()
        {
            if (true)
            {
                var i = 10;
            }
        }
    }
}
