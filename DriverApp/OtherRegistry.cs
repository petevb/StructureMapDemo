namespace DriverApp
{
    using Models;
    using StructureMap;

    public class OtherRegistry : Registry
    {
        public OtherRegistry()
        {
            this.IncludeRegistry<LibraryRegistry>();
            this.For<IGenericThing<int>>().Use<IntThing>();

            ////this.For<IGenericThing<int>>().Use<IntThing>();

            this.Scan(
                _ =>
                {
                    _.TheCallingAssembly();
                    _.AddAllTypesOf<IThing>();
                });
        }
    }
}