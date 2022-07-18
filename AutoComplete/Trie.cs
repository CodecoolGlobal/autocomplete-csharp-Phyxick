using System;

namespace AutoComplete;

public class Trie
{
    public TrieNode Root;

    public Trie()
    {
        Root = new TrieNode("\0");
    }

    public void Insert(string word)
    {
        var curr = Root;
        for (var i = 0; i < word.Length; i++)
        {
            if (!curr.Children.ContainsKey(word[i])) curr.Children.Add(word[i], new TrieNode(word.Substring(0, i + 1)));
            curr = curr.Children[word[i]];
            if (i == word.Length - 1)
                curr.IsWord = true;
        }
    }

    public bool Remove(string word)
    {
        var curr = Root;
        var rootStartingLength = curr.Children.Count;
        for (var i = 0; i < word.Length; i++)
        {
            if (curr.Children.ContainsKey(word[i]))
                curr.Children.Remove(word[i]);
        }

        if (rootStartingLength == curr.Children.Count)
            return false;
        else
        {
            return true;
        }
    }
}