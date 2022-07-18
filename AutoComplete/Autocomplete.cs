using System;
using System.Collections.Generic;

namespace AutoComplete
{
    public class Autocomplete : Trie
    {

        private void FindAllChildWords(TrieNode n, List<String> results)
        {
            if (n.IsWord)
                results.Add(n.Prefix);
            foreach (var c in n.Children.Keys)
            {
                FindAllChildWords(n.Children[c], results);
            }
        }


        public List<string> GetMatches(string prefix)
        {
            List<String> results = new List<String>();

            // Iterate to the end of the prefix
            TrieNode curr = Root;
            foreach (char c in prefix.ToCharArray())
            {
                if (curr.Children.ContainsKey(c))
                {
                    curr = curr.Children[c];
                }
                else
                {
                    return results;
                }
            }

            FindAllChildWords(curr, results);
            return results;
        }
    }
}
