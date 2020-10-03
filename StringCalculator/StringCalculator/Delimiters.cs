using System;
using System.Collections.Generic;

namespace StringCalculator
{
    public static class Delimiters
    {
        private static readonly List<string> DefaultDelimiters = new List<string> { ",", "\n"};
        private const string AdditionalDelimiterPrefix = "//";
        private const char AnyLengthDelimiterStart = '[';
        private const char AnyLengthDelimiterEnd = ']';
        private const int DelimiterPosition = 2;
        private const char NewLineCharacter = '\n';

        public static string[] SplitString(string inputString)
        {
            inputString = FilterOutAdditionalDelimiters(inputString);
            return inputString.Split(DefaultDelimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        private static string FilterOutAdditionalDelimiters(string inputString)
        {
            if (!inputString.StartsWith(AdditionalDelimiterPrefix)) return inputString;

            if (inputString[DelimiterPosition].Equals(AnyLengthDelimiterStart))
            {
                DefaultDelimiters.Add(inputString.SubstringBetweenExclusive(AnyLengthDelimiterStart, AnyLengthDelimiterEnd));
                inputString = inputString.RemoveStringBetweenInclusive(AnyLengthDelimiterStart, AnyLengthDelimiterEnd);
                inputString = FilterOutAdditionalDelimiters(inputString);
            }
            else
                DefaultDelimiters.Add(char.ToString(inputString[DelimiterPosition]));

            return inputString.Substring(inputString.IndexOf(NewLineCharacter));
        }
    }
}