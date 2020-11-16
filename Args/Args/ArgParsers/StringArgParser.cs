namespace Args.ArgParsers
{
    public class StringArgParser : IArgParser<string>
    {
        public string Parse(string section) => section.Split(' ')[1];

        public bool CanParse(string section)
        {
            if (section.Split(' ').Length != 2)
                return false;

            var value = section.Split(' ')[1];
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}