namespace Args.ArgParsers
{
    public interface IArgParser<out T>
    {
        T Parse(string section);
        bool CanParse(string section);
    }
}