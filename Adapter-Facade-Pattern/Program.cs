using System;

namespace Adapter_Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Adapter Pattern
             * Scenario: We have an existing software application that we need to work with new vendor class for an external API, but the new vendor designed their interfaces differently than the last vendor.
             * 
             * Two types of Adapters
             *  a) Object Adapters (Composition)
             *  b) Class Adapters (Multiple Inheritance, C# and most other languatges doesn't support)
             *
             * Some similarity to Decorater pattern
             *  a) Decorater pattern responsibility is to add some new responsibilities or behaviours
             *  b) Adapter responsibility is to connect one interface object to another interface object
             */

            Console.WriteLine("Adapter Pattern..");
            Console.WriteLine("Mallard Duck:");
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Fly();
            mallardDuck.Quack();
            Console.WriteLine("");

            Console.WriteLine("Wild Turkey:");
            WildTurkey wildTurkey = new WildTurkey();
            wildTurkey.Fly();
            wildTurkey.Goblle();
            Console.WriteLine("");


            Console.WriteLine("Turkey Apater for Duck:");
            TurkeyAdapter turkeyAdapter = new TurkeyAdapter(wildTurkey);
            turkeyAdapter.Fly();
            turkeyAdapter.Quack();



            /* Facade Pattern
             *  a) Facade simplifies the interface, and decouples the client from subsystem of components.
             *  b) Facade and adapters may wrap multiple classes. but facade intent to simplify while adapter is to convert the interface to something different.
             * 
             * Facade pattern provide the simple interface method by hiding all complex code inside.
             * Facade pattern just hide the subsystem logic, it doesn't abstract and hence all subsystem class are accessible when we need.
             */

            Console.WriteLine("");
            Console.WriteLine("Facade Pattern...");
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade();
            homeTheaterFacade.WatchMovie();

            Console.ReadLine();
        }
    }
}
