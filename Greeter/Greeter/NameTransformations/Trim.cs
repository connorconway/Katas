namespace Greeter.NameTransformations
{
    public class Trim : INameTransformation
    {
        public string Apply(string input) => input.Trim();
    }
}