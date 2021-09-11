using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("WildTurkey: Flying shorter distance");
        }

        public void Goblle()
        {
            Console.WriteLine("MallardDuck: goblle, goblle");
        }
    }
}
