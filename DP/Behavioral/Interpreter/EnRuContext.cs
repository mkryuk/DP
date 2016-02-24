using System;
using System.Collections.Generic;

namespace DP.Behavioral.Interpreter
{
    /// <summary>
    /// Concrete context
    /// </summary>
    public class EnRuContext : Context
    {
        public Dictionary<string, string> Vocabulary { get; private set; } = new Dictionary<string, string>();

        public EnRuContext()
        {
            Vocabulary.Add("this", "это");
            Vocabulary.Add("is", "есть");
            Vocabulary.Add("a", "какое-то");
            Vocabulary.Add("simple", "простое");
            Vocabulary.Add("sentence", "предложение");
        }

        public override string Translate(string word)
        {
            return Vocabulary.ContainsKey(word) ? Vocabulary[word] : null;
        }
    }
}