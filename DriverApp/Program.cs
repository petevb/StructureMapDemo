using System;

namespace DriverApp
{
    using System.Linq;
    using Models;
    using StructureMap;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(new OtherRegistry());
            var intThing = container.GetInstance<IGenericThing<int>>();

            Console.WriteLine($"Int value: {intThing.Value}");

            var allThings = container.GetAllInstances<IThing>().ToList();
            Console.WriteLine($"Got {allThings.Count} things");
            foreach (var thing in allThings)
            {
                Console.WriteLine(thing.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
