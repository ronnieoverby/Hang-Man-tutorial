using System;
using System.Collections.Generic;
using System.IO;

namespace HangmanGame
{
    static class WordList
    {
        private static readonly Random Rng = new Random();

        private static readonly List<string> Words = new List<string>();

        public static string[] AllWords
        {
            get { return Words.ToArray(); }
        }

        static WordList()
        {
            var type = typeof(WordList);
            using (var resource = type.Assembly.GetManifestResourceStream(type, "Words.txt"))
            using (var reader = new StreamReader(resource))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Words.Add(line);
            }
        }

        public static string GetRandomWord()
        {
            return Words[Rng.Next(Words.Count)];
        }
    }
}