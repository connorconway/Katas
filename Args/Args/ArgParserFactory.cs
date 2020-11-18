using System;
using System.Collections.Generic;

namespace Args
{
    public class ArgParserFactory
    {
        private readonly ArgSchema _schema;

        public ArgParserFactory(ArgSchema schema) => _schema = schema;

        public List<object> Parse(string[] args)
        {
            var results = new List<object>();
            foreach (var arg in args)
            {
                if (string.IsNullOrEmpty(arg)) continue;
                var charArg = arg[1];
                if (_schema.HasBoolArg(charArg))
                {
                    var parser = _schema.BoolArgParser(charArg);
                    if (!parser.CanParse(arg))
                        throw new ArgumentException("Type different from schema");
                    results.Add(parser.Parse(arg));
                }
                else if (_schema.HasIntArg(charArg))
                {
                    var parser = _schema.IntArgParser(charArg);
                    if (!parser.CanParse(arg))
                        throw new ArgumentException("Type different from schema");
                    results.Add(parser.Parse(arg));
                }
                else if (_schema.HasStringArg(charArg))
                {
                    var parser = _schema.StringArgParser(charArg);
                    if (!parser.CanParse(arg))
                        throw new ArgumentException("Type different from schema");
                    results.Add(parser.Parse(arg));
                }
                else
                {
                    throw new ArgumentException("Argument is not defined in the schema");
                }

            }
            return results;
        }
    }
}