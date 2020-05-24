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
            var actual = start.Read("/scratch/beapen/cdm5-umls/CONCEPT.csv", 20);
            Console.WriteLine(actual.Count);
            for (int i = 0; i < 10; i++) // Loop through List with for
            {
                Console.WriteLine(actual[i].ConceptName);
            }
            Assert.NotEmpty(actual);
        }

    }
}
