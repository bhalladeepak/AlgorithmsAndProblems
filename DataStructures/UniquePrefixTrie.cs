using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class UniquePrefixTrie
    {
        /*
         * https://www.geeksforgeeks.org/find-all-shortest-unique-prefixes-to-represent-each-word-in-a-given-list/
         * Given an array of words, find all shortest unique prefixes to represent each word in the given array. Assume that no word is prefix of another. 
         * 
         * Examples
         * Input: arr[] = {"zebra", "dog", "duck", "dove"}
            Output: dog, dov, du, z
            Explanation: dog => dog
                         dove = dov 
                         duck = du
                         z   => zebra 

            Input: arr[] =  {"geeksgeeks", "geeksquiz", "geeksforgeeks"};
            Output: geeksf, geeksg, geeksq}
         */
        static readonly int MAX = 256;

        // Maximum length of an input word
        static readonly int MAX_WORD_LEN = 500;

        // Trie Node.
        public class TrieNode
        {
            public TrieNode[] child = new TrieNode[MAX];
            public int freq; // To store frequency
            public TrieNode()
            {
                freq = 1;
                for (int i = 0; i < MAX; i++)
                    child[i] = null;
            }
        }
        static TrieNode root;

        // Method to insert a new string into Trie
        static void insert(String str)
        {
            // Length of the URL
            int len = str.Length;
            TrieNode pCrawl = root;

            // Traversing over the length of given str.
            for (int level = 0; level < len; level++)
            {
                // Get index of child node from 
                // current character in str.
                int index = str[level];

                // Create a new child if not exist already
                if (pCrawl.child[index] == null)
                    pCrawl.child[index] = new TrieNode();
                else
                    (pCrawl.child[index].freq)++;

                // Move to the child
                pCrawl = pCrawl.child[index];
            }
        }

        // This function prints unique prefix for every word stored
        // in Trie. Prefixes one by one are stored in prefix[].
        // 'ind' is current index of prefix[]
        static void findPrefixesUtil(TrieNode root, char[] prefix, int ind)
        {
            // Corner case
            if (root == null)
                return;

            // Base case
            if (root.freq == 1)
            {
                prefix[ind] = '\0';
                int i = 0;
                while (prefix[i] != '\0')
                    Console.Write(prefix[i++]);
                Console.Write(" ");
                return;
            }

            for (int i = 0; i < MAX; i++)
            {
                if (root.child[i] != null)
                {
                    prefix[ind] = (char)i;
                    findPrefixesUtil(root.child[i], prefix, ind + 1);
                }
            }
        }

        // Function to print all prefixes that uniquely
        // represent all words in arr[0..n-1]
        static void findPrefixes(String[] arr, int n)
        {
            // Construct a Trie of all words
            root = new TrieNode();
            root.freq = 0;
            for (int i = 0; i < n; i++)
                insert(arr[i]);

            // Create an array to store all prefixes
            char[] prefix = new char[MAX_WORD_LEN];

            // Print all prefixes using Trie Traversal
            findPrefixesUtil(root, prefix, 0);
        }

        // Driver code
        public static void Demo()
        {
            String[] arr = { "zebra", "dog", "duck", "dove" };
            int n = arr.Length;
            findPrefixes(arr, n);
        }
    }
}
