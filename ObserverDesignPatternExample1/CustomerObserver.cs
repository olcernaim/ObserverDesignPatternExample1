using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatternExample1
{
    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Customer Observer");
        }
    }
}
