using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace WordWrap
{
    public class Wrapper
    {
        public static string Wrap(string words, int columnToSplit)
        {
            if (columnToSplit == 0)
                throw new ArgumentException("Must split on a valid column number");

            if (words.Length > columnToSplit)
            {
                var k = 0;
                var output = words
                    .ToLookup(c => Math.Floor((decimal) (k++ / columnToSplit)))
                    .Select(e => new string(e.ToArray()));

                var stringbuilder = new StringBuilder();
                foreach (var part in output)
                {
                    if (part.EndsWith(" "))
                    {
                        var updated = part.Replace(" ", Environment.NewLine);
                        stringbuilder.Append(updated);
                    }
                    else
                    {
                        stringbuilder.Append(part + Environment.NewLine);
                    }
                }

                return stringbuilder.ToString();

            }
            return words;
        }
    }
}
