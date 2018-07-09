using Models;

namespace DriverApp
{
    public class IntThing : IGenericThing<int>
    {
        public int Value => 42;
    }
}