using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Dictionary
{
    public class CountWords
    {
        public CountWords()
        {
        }
        // use .select
        public Dictionary<string, int> CreateDictionary(string sentence)
        {
            sentence = Regex.Replace(sentence, @"\."," ");
            var words = sentence.ToLower().Split(" ");
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

        public Dictionary<string, int> Select(string sentence, int length)
        {
            // want to select all words with a length of 3 and add to dictionary
            sentence = Regex.Replace(sentence, @"\.", " ");
            var words = sentence.ToLower().Split(" ");
            Dictionary<string, int> Words = new Dictionary<string, int>();
            CheckCondition(length, words, Words);
            return Words;
        }

        private static void CheckCondition(int length, string[] words, Dictionary<string, int> Words)
        {
            foreach (var word in words.Where(word => word.Length > length))
            {
                TryAdd(word, Words);
            }
        }
    }
}