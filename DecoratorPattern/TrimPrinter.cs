using System;

namespace DecoratorPattern
{
    public class TrimPrinter : IPrinter
    {
        private readonly IPrinter _inner;

        public TrimPrinter(IPrinter inner)
        {
            _inner = inner;
        }
        
        public void Print(string text)
        {
            Console.WriteLine("TrimPrinter");
            _inner.Print(text.Replace(" ", ""));
        }
    }
}
