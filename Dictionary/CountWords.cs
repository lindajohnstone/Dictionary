using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class CountWords
    {
        public CountWords()
        {
        }

        public Dictionary<string, int> CreateDictionary(string sentence)
        {
            sentence = sentence.Replace('.', ' ');
            var words = sentence.ToLower().Split(' ');
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            Check(words, RepeatedWordCount);
            return RepeatedWordCount;
        }

        private static void Check(string[] words, Dictionary<string, int> RepeatedWordCount)
        {
            foreach (var word in words)
            {
                TryAdd(word, RepeatedWordCount);
            }
        }

        private static void TryAdd(string word, Dictionary<string, int> RepeatedWordCount)
        {
            var count = RepeatedWordCount.GetValueOrDefault(word, 0);
            RepeatedWordCount[word] = count + 1;
        }
    }
}