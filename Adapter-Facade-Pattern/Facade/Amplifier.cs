using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }

        public void SetSurrendingSound()
        {
            Console.WriteLine("Amplifier is set the surrounding sound");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is off");
        }
    }
}
