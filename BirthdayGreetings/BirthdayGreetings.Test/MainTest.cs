using System.IO;
using BirthdayGreetings.DataAccess;
using NUnit.Framework;

namespace BirthdayGreetings.Test
{
    public class MainTest
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
        public void Main()
        {
            File.WriteAllText(_filePath, "last_name,first_name,date_of_birth,email\r\nDoe,John,1982/10/08,john.doe@foobar.com\r\nAnn,Mary,1975/09/11,mary.ann@foobar.com\r\n");
            _csvRepository = new CsvPersonRepository(_filePath);
         
        }
    }
}