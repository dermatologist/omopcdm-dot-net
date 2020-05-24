using System;
using Xunit;
using omopcdmlib.Utils;
using omopcdmlib.Models;

// https://lukewickstead.wordpress.com/2013/01/16/xunit-cheat-sheet/
namespace omopcdmlib.testing
{
    public class CreateVocabTest
    {
        [Fact]
        public void TestingReadCsv()
        {
            var start = new ReadCdmFile<Concept>();
            var actual = start.Read("/scratch/beapen/cdm5-umls/CONCEPT.csv");
            Console.WriteLine(actual.Count);
            Assert.NotEmpty(actual);
        }

    }
}
