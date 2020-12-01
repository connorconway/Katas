using System.Collections.Generic;
using BirthdayGreetings.Core;

namespace BirthdayGreetings.DataAccess
{
    public class SqlPersonRepository : IPersonRepository
    {
        public IEnumerable<PersonDto> People()
        {
            throw new System.NotImplementedException("This would return the people from a database in the real world");
        }
    }
}