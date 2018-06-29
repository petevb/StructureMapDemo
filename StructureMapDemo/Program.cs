using System;

namespace StructureMapDemo
{
    using System.Linq;

    using StructureMap;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(new DemoRegistry());

            var stringThing = container.GetInstance<IGenericThing<string>>();
            var intThing = container.GetInstance<IGenericThing<int>>();
            Console.WriteLine($"String value: {stringThing.Value}");
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
