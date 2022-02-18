using System;
using System.Collections.Generic;
using System.Text;

namespace HardProblems
{
    public class WordSearchII
    {
        public void TestFindWords()
        {
            char[][] board = new char[4][];
            board[0] = new char[] { 'o', 'a', 'a', 'n' };
            board[1] = new char[] { 'e', 't', 'a', 'e' };
            board[2] = new char[] { 'i', 'h', 'k', 'r' };
            board[3] = new char[] { 'i', 'f', 'l', 'v' };

            string[] words = new string[] { "oath", "pea", "eat", "rain" };

            IList<string> ss = FindWords(board, words);
            foreach (string s in ss)
            {
                Console.WriteLine(s);
            }

        }
        public IList<string> FindWords(char[][] board, string[] words)
        {
            IList<string> res = new List<string>();
            HashSet<string> hs = new HashSet<string>();
            Trie trie = new Trie();

            foreach (string word in words)
            {
                trie.Add(word);
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (trie.Find(board[i][j]))
                    {
                        List<string> list = new List<string>();
                        StringBuilder sb = new StringBuilder();
                        int[,] visited = new int[board.Length, board[0].Length];
                        Dfs(board, trie, i, j, sb, list, visited);
                        if (list.Count == 0)
                            continue;
                        foreach (string s in list)
                        {
                            if (!hs.Contains(s))
                            {
                                res.Add(s);
                                hs.Add(s);
                            }
                        }
                    }
                }
            }
            return res;
        }
        private void Dfs(char[][] board, Trie trie, int i, int j, StringBuilder sb, List<string> list, int[,] visited)
        {
            sb.Append(board[i][j]);
            visited[i, j] = 1;
            int res = trie.Find(sb.ToString());
            if (res == 2)
                list.Add(sb.ToString());
            if (res != 0)
            {
                if (i > 0 && visited[i - 1, j] == 0)
                {
                    Dfs(board, trie, i - 1, j, sb, list, visited);
                }
                if (j > 0 && visited[i, j - 1] == 0)
                {
                    Dfs(board, trie, i, j - 1, sb, list, visited);
                }

                if (i < board.Length - 1 && visited[i + 1, j] == 0)
                {
                    Dfs(board, trie, i + 1, j, sb, list, visited);
                }
                if (j < board[0].Length - 1 && visited[i, j + 1] == 0)
                {
                    Dfs(board, trie, i, j + 1, sb, list, visited);
                }
            }
            sb.Remove(sb.Length - 1, 1);
            visited[i, j] = 0;
        }

    }

    public class Trie
    {
        public TrieNode root;
        public Trie()
        {
            root = new TrieNode(false);
        }
        public void Add(string word)
        {
            TrieNode tmp = root;
            foreach (char c in word)
            {
                if (tmp.children[c - 'a'] == null)
                    tmp.children[c - 'a'] = new TrieNode(false);
                tmp = tmp.children[c - 'a'];
            }
            tmp.isWord = true;
        }
        public bool Find(char c)
        {
            return root.children[c - 'a'] != null;
        }
        public int Find(string word)
        {
            TrieNode tmp = root;
            TrieNode prev = null;
            char child = ' ';
            foreach (char c in word)
            {
                if (tmp.children[c - 'a'] == null)
                    return 0;
                prev = tmp;
                child = c;
                tmp = tmp.children[c - 'a'];
            }
            if (tmp.isWord == true)
            {
                bool b = false;
                foreach (TrieNode node in tmp.children)
                {
                    if (node != null)
                        b = true;
                }
                if (!b)
                    prev.children[child - 'a'] = null;
                return 2;
            }
            else
                return 1;
        }
    }
    public class TrieNode
    {
        public bool isWord = false;
        public TrieNode[] children;
        public TrieNode(bool isword)
        {
            this.isWord = isword;
            children = new TrieNode[26];
        }
    }
}
