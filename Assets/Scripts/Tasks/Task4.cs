public struct ApiSetup<T> { }

class Api
{
    public ApiSetup<T> For<T>(T obj)
    {
        return new ApiSetup<T>();
    }
}

interface ISomeInterfaceA { }

interface ISomeInterfaceB { }

public class ObjectA : ISomeInterfaceA { }

public class ObjectB : ISomeInterfaceB { }

class SomeClass2
{
    public void Setup()
    {
        Api apiObject = new Api();

        apiObject.For(new ObjectA()).SetupObjectA();
        apiObject.For(new ObjectB()).SetupObjectB();
    }
}

static class Extensions
{
    public static void SetupObjectA<T>(this ApiSetup<T> apiSetup) where T : ObjectA
    {

    }

    public static void SetupObjectB<T>(this ApiSetup<T> apiSetup) where T : ObjectB
    {

    }
}
