namespace Args.ArgParsers
{
    public class BoolArgParser : IArgParser<bool>
    {
        public bool Parse(string section) => section.Split(' ').Length == 1;

        public bool CanParse(string section) => section.StartsWith("-") && section.Split(' ').Length == 1;
    }
}