using System;
using Xunit;
using omopcdmlib.Models;

namespace omopcdmlib.testing
{
    public class ConceptTest
    {
        [Fact]
        public void TestingConcept()
        {
            var start = new Concept();
            var actual = start.GetNameForTest;
            Assert.Equal("Concept", actual);
        }

    }
}
