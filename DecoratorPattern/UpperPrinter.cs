using System;

namespace DecoratorPattern
{
    public class UpperPrinter : IPrinter
    {
        private readonly IPrinter _inner;

        public UpperPrinter(IPrinter inner)
        {
            _inner = inner;
        }
        
        public void Print(string text)
        {
            Console.WriteLine("UpperPrinter");
            _inner.Print(text.ToUpper());
        }
    }
}
