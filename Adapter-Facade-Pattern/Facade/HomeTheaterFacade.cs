using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{
    public class HomeTheaterFacade
    {
        private Light light;
        private Screen screen;
        private Projector projector;
        private Amplifier amplifier;
        private Dvd dvd;

        public HomeTheaterFacade()
        {
            light = new Light();
            screen = new Screen();
            projector = new Projector();
            amplifier = new Amplifier();
            dvd = new Dvd();
        }

        public void WatchMovie()
        {
            light.Dim();
            screen.Open();
            projector.On();
            amplifier.On();
            dvd.On();
            dvd.Play();
        }
    }
}
