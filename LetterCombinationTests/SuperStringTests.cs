using System.Collections.Generic;
using LetterCombinationDomain;
using Xunit;

namespace LetterCombinationTests
{
    public class SuperStringTests
    {
        [Fact]
        public void GetCombinationLetters_ShouldReturn_EmptyList()
        {
            var str = string.Empty;
            
            var result = SuperString.GetCombinationLetters(str);

            Assert.Empty(result);
        }

        [Fact]
        public void GetCombinationLetters_ShouldReturn_SingleCombinationString()
        {
            var str = "2";
            var expectedResult = new List<string> {"a", "b", "c"};

            var result = SuperString.GetCombinationLetters(str);

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void GetCombinationLetters_ShouldReturn_DoubleCombinationString()
        {
            var str = "23";
            var expectedResult = new List<string>
            {
                "ad",
                "ae",
                "af",
                "bd",
                "be",
                "bf",
                "cd",
                "ce",
                "cf"
            };

            var result = SuperString.GetCombinationLetters(str);

            Assert.Equal(result, expectedResult);
        }
    }
}