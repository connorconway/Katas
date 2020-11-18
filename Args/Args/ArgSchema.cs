using System.Collections.Generic;
using Args.ArgParsers;

namespace Args
{
    public class ArgSchema
    {
        private readonly Dictionary<char, IArgParser<int>> _ints = new Dictionary<char, IArgParser<int>>();
        private readonly Dictionary<char, IArgParser<string>> _strings = new Dictionary<char, IArgParser<string>>();
        private readonly Dictionary<char, IArgParser<bool>> _bools = new Dictionary<char, IArgParser<bool>>();

        public ArgSchema Add<T>(char key)
        {
            var t = typeof(T);
            if (t == typeof(bool))
                _bools.Add(key, new BoolArgParser());
            if (t == typeof(string))
                _strings.Add(key, new StringArgParser());
            if (t == typeof(int))
                _ints.Add(key, new IntArgParser());

            return this;
        }

        public bool HasBoolArg(char arg) => _bools.ContainsKey(arg);

        public bool HasStringArg(char arg) => _strings.ContainsKey(arg);

        public bool HasIntArg(char arg) => _ints.ContainsKey(arg);

        public IArgParser<bool> BoolArgParser(char arg)
        {
            _bools.TryGetValue(arg, out var boolArgParser);
            return boolArgParser;
        }

        public IArgParser<string> StringArgParser(char arg)
        {
            _strings.TryGetValue(arg, out var stringArgParser);
            return stringArgParser;
        }

        public IArgParser<int> IntArgParser(char arg)
        {
            _ints.TryGetValue(arg, out var intArgParser);
            return intArgParser;
        }
    }
}