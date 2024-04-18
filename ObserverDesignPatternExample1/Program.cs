using System;

namespace ObserverDesignPatternExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Attach(new CustomerObserver());
            product.Attach(new CustomerObserver());
            product.Attach(new CustomerObserver());

            product.ChangeStock();
            //Console.WriteLine("Hello World!");
        }
    }
}
