using System;
using System.Collections.Generic;

namespace AutoComplete
{
    public class TrieNode
    {
        public string Prefix { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }

        public bool IsWord;

        public TrieNode(String prefix)
        {
            this.Prefix = prefix;
            this.Children = new Dictionary<char, TrieNode>();
        }
    }
}
