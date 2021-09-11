using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("MallardDuck: Flying");
        }

        public void Quack()
        {
            Console.WriteLine("MallardDuck: Quack Quack");
        }
    }
}
