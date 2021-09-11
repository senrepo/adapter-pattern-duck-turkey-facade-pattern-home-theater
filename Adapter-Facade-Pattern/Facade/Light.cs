using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Dim()
        {
            Console.WriteLine("Light is dim");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }
}
