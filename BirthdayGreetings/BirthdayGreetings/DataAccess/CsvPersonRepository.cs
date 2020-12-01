using System.Collections.Generic;
using System.IO;
using System.Linq;
using BirthdayGreetings.Core;

namespace BirthdayGreetings.DataAccess
{
    public class CsvPersonRepository : IPersonRepository
    {
        private readonly string _filePath;
        private const char PropertySeparator = ',';

        public CsvPersonRepository(string filePath) => _filePath = filePath;

        public IEnumerable<PersonDto> People()
        {
            return
                from line in File.ReadAllLines(_filePath).Skip(1)
                let property = line.Split(PropertySeparator)
                select new PersonDto
                {
                    FirstName = property[1],
                    LastName = property[0],
                    DateOfBirth = property[2],
                    Email = property[3]
                };
        }
    }
}