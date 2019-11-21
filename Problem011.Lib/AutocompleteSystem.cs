using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem011.Lib
{
    /*
     * Daily Coding Problem: Problem #11 [Medium]
This problem was asked by Twitter.

Implement an autocomplete system. That is, given a query string s and a set of all possible query strings, return all strings in the set that have s as a prefix.

For example, given the query string de and the set of strings [dog, deer, deal], return [deer, deal].

Hint: Try preprocessing the dictionary into a more efficient data structure to speed up queries.
     */
    public class AutocompleteSystem
    {
        private readonly List<string> _shortWordLookup = new List<string>();
        private readonly Dictionary<char, Dictionary<char, List<string>>> _lookup = new Dictionary<char, Dictionary<char, List<string>>>();

        public AutocompleteSystem(IEnumerable<string> dictionary)
        {
            foreach (var word in dictionary)
            {
                if (string.IsNullOrEmpty(word))
                {
                    continue;
                }

                if (word.Length == 1)
                {
                    _shortWordLookup.Add(word);
                    continue;
                }

                var c0 = word[0];
                var c1 = word[1];
                if (!_lookup.ContainsKey(c0))
                {
                    _lookup[c0] = new Dictionary<char, List<string>>();
                }
                if (!_lookup[c0].ContainsKey(c1))
                {
                    _lookup[c0][c1] = new List<string>();
                }
                _lookup[c0][c1].Add(word);
            }
        }

        public string[] Query(string prefix)
        {
            if (string.IsNullOrEmpty(prefix))
            {
                return new string[0];
            }

            if (prefix.Length == 1)
            {
                var result = new List<string>();
                if (_shortWordLookup.Contains(prefix))
                {
                    result.Add(prefix);
                }
                var c0 = prefix[0];
                if (_lookup.ContainsKey(c0))
                {
                    var buckets = _lookup[c0];
                    foreach (var v in buckets.Values)
                    {
                        result.AddRange(v);
                    }
                }
                return result.ToArray();
            }
            else
            {
                var c0 = prefix[0];
                var c1 = prefix[1];
                var bucket = _lookup[c0][c1];
                if (prefix.Length == 2)
                {
                    return bucket.ToArray();
                }
                return bucket.Where(s => s.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)).ToArray();
            }
        }
    }
}
