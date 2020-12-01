using System.Collections.Generic;
using System.IO;
using BirthdayGreetings.Core;
using BirthdayGreetings.DataAccess;
using FluentAssertions;
using NUnit.Framework;

namespace BirthdayGreetings.Test.DataAccess
{
    [TestFixture]
    public class CsvPersonRepositoryTest
    {
        private CsvPersonRepository _csvRepository;
        private string _testDirectory;
        private string _filePath;

        [SetUp]
        public void SetUp()
        {
            _testDirectory = Path.Combine(TestContext.CurrentContext.TestDirectory, "RepositoryTest");
            Directory.CreateDirectory(_testDirectory);
            _filePath = Path.Combine(_testDirectory, "friends.txt");
        }

        [TearDown]
        public void TearDown()
        {
            if (Directory.Exists(_testDirectory))
                Directory.Delete(_testDirectory, true);
        }

        [Test]
        public void People()
        {
            File.WriteAllText(_filePath, "last_name,first_name,date_of_birth,email\r\nDoe,John,1982/10/08,john.doe@foobar.com\r\nAnn,Mary,1975/09/11,mary.ann@foobar.com\r\n");
            _csvRepository = new CsvPersonRepository(_filePath);

            var expectedPeople = new List<PersonDto>
            {
                new PersonDto
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = "1982/10/08",
                    Email = "john.doe@foobar.com"
                }, 
                new PersonDto
                {
                    FirstName = "Mary",
                    LastName = "Ann",
                    DateOfBirth = "1975/09/11",
                    Email = "mary.ann@foobar.com"
                }};

            expectedPeople.Should().BeEquivalentTo(_csvRepository.People());
        }
    }
}
