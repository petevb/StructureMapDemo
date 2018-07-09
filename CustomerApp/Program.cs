using System;

namespace CustomerApp
{
    using System.Linq;
    using Models;
    using StructureMap;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(new DemoRegistry());

            var stringThing = container.GetInstance<IGenericThing<string>>();
            Console.WriteLine($"String value: {stringThing.Value}");

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
