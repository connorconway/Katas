namespace Args.ArgParsers
{
    public class IntArgParser : IArgParser<int>
    {
        public int Parse(string section)
        {
            var value = section.Split(' ')[1];
            int.TryParse(value, out var result);
            return result;
        }

        public bool CanParse(string section)
        {
            if (section.Split(' ').Length != 2)
                return false;

            var value = section.Split(' ')[1];
            return int.TryParse(value, out _);
        }
    }
}