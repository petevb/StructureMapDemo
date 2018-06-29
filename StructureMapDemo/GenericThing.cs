namespace StructureMapDemo
{
    public interface IThing
    {
    }

    public interface IGenericThing<T> : IThing
    {
        T Value { get; }
    }

    public class StringThing : IGenericThing<string>
    {
        public string Value => "A string";
    }

    public class IntThing : IGenericThing<int>
    {
        public int Value => 42;
    }
}