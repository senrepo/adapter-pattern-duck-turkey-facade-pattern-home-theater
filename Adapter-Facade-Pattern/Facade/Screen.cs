using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class Screen
    {
        public void Open()
        {
            Console.WriteLine("Screen is Open");
        }

        public void Close()
        {
            Console.WriteLine("Screen is Close");
        }
    }
}
