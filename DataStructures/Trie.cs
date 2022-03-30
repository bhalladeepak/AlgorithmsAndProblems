using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{


    /*
     * Trie is an efficient information reTrieval data structure. Using Trie, search complexities can be brought to optimal limit (key length). 
     * If we store keys in binary search tree, a well balanced BST will need time proportional to M * log N, where M is maximum string length and N is number of keys in tree. 
     * Using Trie, we can search the key in O(M) time. However the penalty is on Trie storage requirements
     * https://www.geeksforgeeks.org/trie-insert-and-search/
     * 
     * 
     * 
     */
    public class Trie
    {

        // Alphabet size (# of symbols)
        static readonly int ALPHABET_SIZE = 26;

        // trie node
        class TrieNode
        {
            public TrieNode[] children = new TrieNode[ALPHABET_SIZE];

            // isEndOfWord is true if the node represents
            // end of a word
            public bool isEndOfWord;

            public TrieNode()
            {
                isEndOfWord = false;
                for (int i = 0; i < ALPHABET_SIZE; i++)
                    children[i] = null;
            }
        };

        static TrieNode root;

        // If not present, inserts key into trie
        // If the key is prefix of trie node,
        // just marks leaf node
        static void insert(String key)
        {
            int level;
            int length = key.Length;
            int index;

            TrieNode pCrawl = root;

            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.children[index] == null)
                    pCrawl.children[index] = new TrieNode();

                pCrawl = pCrawl.children[index];
            }

            // mark last node as leaf
            pCrawl.isEndOfWord = true;
        }

        // Returns true if key
        // presents in trie, else false
        static bool search(String key)
        {
            int level;
            int length = key.Length;
            int index;
            TrieNode pCrawl = root;

            for (level = 0; level < length; level++)
            {
                index = key[level] - 'a';

                if (pCrawl.children[index] == null)
                    return false;

                pCrawl = pCrawl.children[index];
            }

            return (pCrawl.isEndOfWord);
        }

        // Driver
        public static void Demo()
        {
            // Input keys (use only 'a'
            // through 'z' and lower case)
            String[] keys = {"the", "a", "there", "answer",
                        "any", "by", "bye", "their"};

            String[] output = { "Not present in trie", "Present in trie" };


            root = new TrieNode();

            // Construct trie
            int i;
            for (i = 0; i < keys.Length; i++)
                insert(keys[i]);

            // Search for different keys
            if (search("the") == true)
                Console.WriteLine("the --- " + output[1]);
            else Console.WriteLine("the --- " + output[0]);

            if (search("these") == true)
                Console.WriteLine("these --- " + output[1]);
            else Console.WriteLine("these --- " + output[0]);

            if (search("their") == true)
                Console.WriteLine("their --- " + output[1]);
            else Console.WriteLine("their --- " + output[0]);

            if (search("thaw") == true)
                Console.WriteLine("thaw --- " + output[1]);
            else Console.WriteLine("thaw --- " + output[0]);

        }
    }
}
