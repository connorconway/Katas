namespace Greeter.NameTransformations
{
    public class Capitalise : INameTransformation
    {
        public string Apply(string input) => char.ToUpper(input[0]) + input.Substring(1);
    }
}