using System;
using Xunit;
using omopcdmlib.Utils;
using omopcdmlib.Models;

namespace omopcdmlib.testing
{
    public class CreateVocabTest
    {
        [Fact]
        public void TestingReadCsv()
        {
            var start = new OmopReadCsv<Concept>();
            var actual = start.Read("/scratch/beapen/cdm5-umls/CONCEPT.csv");
            Assert.NotEmpty(actual);
        }

    }
}
