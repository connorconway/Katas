namespace Greeter.GreetingFactory
{
    public static class GreetingFactoryExtension
    {
        public static IGreetingFactory Then(this IGreetingFactory first, IGreetingFactory second) => 
            new CompositeGreetingFactory(first, second);
    }
}