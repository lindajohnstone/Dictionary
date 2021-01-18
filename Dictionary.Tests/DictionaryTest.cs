using System;
using System.Collections.Generic;
using Xunit;

namespace Dictionary.Tests
{
    public class DictionaryTests
    {
        [Fact]
        public void Should_Test_Words_PlusFrequency_Added_To_Dictionary()
        {
            // arrange
            var words = new CountWords();
            var sentence = "The quick brown fox jumped over the lazy dog.";
            var expected = new Dictionary<string, int>();
            expected.Add("the", 2);
            // act
            var result = words.CreateDictionary(sentence);
            // assert
            Assert.Equal(expected.ContainsKey("the"), result.ContainsKey("the"));
            Assert.Equal(expected.ContainsValue(2), result.ContainsValue(2));
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
            Assert.Equal(expected.ContainsKey("dog"), result.ContainsKey("dog"));
            Assert.Equal(expected.ContainsValue(1), result.ContainsValue(1));
        }
    }
}
