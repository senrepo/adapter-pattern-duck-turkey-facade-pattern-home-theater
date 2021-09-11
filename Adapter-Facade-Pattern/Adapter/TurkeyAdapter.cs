using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Pattern
{

    /* Scenario : Let say we are short on Duck objects, and we like to use some Turkey objects in their place.
     * Obvirously we can't use turkey objects outright because they have different interfaces
     * 
     */

    public class TurkeyAdapter : IDuck
    {
        ITurkey turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }


        public void Fly()
        {
            turkey.Fly();
        }

        public void Quack()
        {
            //turkey can fly only shorter distance, whereas Duck can fly longer distance, so to coverup the flying distance is matched by increasing the flying capability  5
            for (var i=0; i<5; i++)
            {
                turkey.Goblle();
            }
        }
    }
}
