using System;
using System.Collections.Generic;

namespace AutoComplete
{
    public class TrieNodes
    {
        public string Prefix { get; set; }
        public Dictionary<char, TrieNodes> Children { get; set; }

        public bool IsWord;

        public TrieNodes(String prefix)
        {
            this.Prefix = prefix;
            this.Children = new Dictionary<char, TrieNodes>();
        }
    }
}
