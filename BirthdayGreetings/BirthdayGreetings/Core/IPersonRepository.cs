using System.Collections.Generic;

namespace BirthdayGreetings.Core
{
    public interface IPersonRepository
    {
        IEnumerable<PersonDto> People();
    }
}