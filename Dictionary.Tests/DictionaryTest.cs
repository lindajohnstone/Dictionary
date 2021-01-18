using System;
using System.Collections.Generic;
using Xunit;

namespace Dictionary.Tests
{
    public class DictionaryTests
    {
        [Fact]
        public void Should_Test_Words_Plus_Frequency_Added_To_Dictionary()
        {
            // arrange
            var words = new CountWords();
            var sentence = "The quick brown fox jumped over the lazy dog.";
            var expected = new Dictionary<string, int>() {["the"] = 2};
            // act
            var result = words.CreateDictionary(sentence);
            // assert
            Assert.Equal(2, result["the"]);
        
        }
        [Fact]
        public void Should_Test_Period_Not_Added_To_Dictionary()
        {
            // arrange
            var words = new CountWords();
            var sentence = "The quick brown fox jumped over the lazy dog.";
            var expected = new Dictionary<string, int>();
            expected.Add("dog", 1);
            // act
            var result = words.CreateDictionary(sentence);
            // assert
            Assert.Equal(1, result["dog"]);

        }
    }
}
