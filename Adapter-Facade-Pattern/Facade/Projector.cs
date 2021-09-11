using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is On");
        }
        public void Off()
        {
            Console.WriteLine("Projector is Off");
        }
    }
}
