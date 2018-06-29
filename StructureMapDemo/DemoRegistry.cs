namespace StructureMapDemo
{
    using StructureMap;
    public class DemoRegistry : Registry
    {
        public DemoRegistry()
        {
            this.For<IGenericThing<string>>().Use<StringThing>();
            this.For<IGenericThing<int>>().Use<IntThing>();

            //this.Scan(
            //    _ =>
            //    {
            //        _.TheCallingAssembly();
            //        _.AddAllTypesOf<IThing>();
            //    });
        }
    }
}