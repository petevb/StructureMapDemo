namespace CustomerApp
{
    using Models;
    using StructureMap;
    public class DemoRegistry : Registry
    {
        public DemoRegistry()
        {
            this.IncludeRegistry<LibraryRegistry>();
            this.For<IGenericThing<string>>().Use<StringThing>();
            this.For<IThing>().Use<StringThing>();
        }
    }
}