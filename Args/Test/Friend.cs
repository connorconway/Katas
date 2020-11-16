using System;

namespace Test
{
    public class Friend
    {
        private readonly string _firstName;
        private readonly string _lastName;

        public string FirstName
        {
            get => _firstName;
            init => _firstName = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Shouldn't be null or whitespace",
                    nameof(FirstName))
                : value;
        }
        public string LastName
        {
            get => _lastName;
            init => _lastName = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Shouldn't be null or whitespace",
                    nameof(LastName))
                : value;
        }
    }

}
