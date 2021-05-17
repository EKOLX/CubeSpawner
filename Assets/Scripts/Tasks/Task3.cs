interface ISomeInterface
{
    void Call();
}

struct SomeStruct : ISomeInterface
{
    public void Call() { }
}

class SomeClass
{
    public void Run()
    {
        var someStruct = new SomeStruct();
        SomeMethod(someStruct);
    }

    public void SomeMethod(ISomeInterface @interface)
    {
        @interface.Call();
    }

    public static void SomeMethod(SomeStruct @struct)
    {
        @struct.Call();
    }
}
