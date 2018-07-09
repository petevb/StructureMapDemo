using Models;

namespace CustomerApp
{
    public class StringThing : IGenericThing<string>
    {
        public string Value => "A string";
    }

    public class IntThing : IGenericThing<int>
    {
        public int Value => 42;
    }
}