namespace Models
{
    public interface IThing
    {
    }

    public interface IGenericThing<T> : IThing
    {
        T Value { get; }
    }

    public class BoolThing : IGenericThing<bool>
    {
        public bool Value => true;
    }
}