using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class Dvd
    {
        public void On()
        {
            Console.WriteLine("Dvd is on");
        }

        public void Play()
        {
            Console.WriteLine("Dvd is playing");
        }

        public void Off()
        {
            Console.WriteLine("Dvd is off");
        }
    }
}
