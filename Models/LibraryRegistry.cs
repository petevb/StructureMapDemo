namespace Models
{
    using StructureMap;

    public class LibraryRegistry : Registry
    {
        public LibraryRegistry()
        {
            this.For<IGenericThing<bool>>().Use<BoolThing>();
            this.For<IThing>().Use<BoolThing>();
        }
    }
}