using System;

namespace DecoratorPattern
{
    public class Printer : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Printer");
            Console.WriteLine(text);
        }
    }
}
