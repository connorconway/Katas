namespace StringCalculator
{
    public static class StringExtension
    {
        public static string SubstringBetweenExclusive(this string input, char charFrom, char charTo)
        {
            var posFrom = input.IndexOf(charFrom);
            if (posFrom != -1)
            {
                var posTo = input.IndexOf(charTo, posFrom + 1);
                if (posTo != -1)
                    return input.Substring(posFrom + 1, posTo - posFrom - 1);
            }

            return string.Empty;
        }

        public static string RemoveStringBetweenInclusive(this string input, char charFrom, char charTo)
        {
            var start = input.IndexOf(charFrom);
            var end = input.IndexOf(charTo) + 1;
            return input.Remove(start, end - start);
        }
    }
}