using System;
using System.Collections.Generic;
using System.Linq;
using Args.ArgParsers;

namespace Args
{
    public class ArgParserFactory
    {
        public List<object> Parse(string[] args)
        {
            var boolArgParser = new BoolArgParser();
            var intArgParser = new IntArgParser();
            var stringArgParser = new StringArgParser();

            var results = new List<object>();

            foreach (var arg in args)
            {
                if (boolArgParser.CanParse(arg))
                    results.Add(boolArgParser.Parse(arg));
                else if (intArgParser.CanParse(arg))
                    results.Add(intArgParser.Parse(arg));
                else if (stringArgParser.CanParse(arg))
                    results.Add(stringArgParser.Parse(arg));
            }
            return results;
        }
    }
}