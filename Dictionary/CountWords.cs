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
            var words = sentence.ToLower().Split(' ' , '.');
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            Check(words, RepeatedWordCount);
            return RepeatedWordCount;
        }

        private static void Check(string[] words, Dictionary<string, int> RepeatedWordCount)
        {
            for (int i = 0; i < words.Length; i++)
            {
                TryAdd(words, RepeatedWordCount, i);
            }
        }

        private static void TryAdd(string[] words, Dictionary<string, int> RepeatedWordCount, int i)
        {
            if (RepeatedWordCount.ContainsKey(words[i]))
            {
                Exists(words, RepeatedWordCount, i);
            }
            else
            {
                Add(words, RepeatedWordCount, i);
            }
        }

        private static void Add(string[] words, Dictionary<string, int> RepeatedWordCount, int i)
        {
            RepeatedWordCount.Add(words[i], 1);
        }

        private static void Exists(string[] words, Dictionary<string, int> RepeatedWordCount, int i)
        {
            int value = GetValue(words, RepeatedWordCount, i);
            value = value + 1;
        }

        private static int GetValue(string[] words, Dictionary<string, int> RepeatedWordCount, int i)
        {
            return RepeatedWordCount[words[i]];
        }
    }
}