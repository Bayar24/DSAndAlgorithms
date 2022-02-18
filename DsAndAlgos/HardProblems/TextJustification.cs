using System;
using System.Collections.Generic;
using System.Text;

namespace HardProblems
{
    public class TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            int count = 0;
            IList<string> res = new List<string>();
            IList<string> list = new List<string>();
            foreach (string word in words)
            {
                //This is current list count
                if (count + word.Length + list.Count <= maxWidth)
                {
                    list.Add(word);
                    count += word.Length;
                }
                else
                {
                    if (list.Count > 1)
                        res.Add(Expand(list, count, maxWidth));
                    else
                        res.Add(ExpandLast(list, maxWidth));
                    list = new List<string>();
                    list.Add(word);
                    count = word.Length;
                }
            }
            if (list.Count > 0)
            {
                res.Add(ExpandLast(list, maxWidth));
            }
            return res;
        }
        //This is for last elements
        private string ExpandLast(IList<string> list, int maxWidth)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in list)
            {
                if (sb.Length > 0)
                    sb.Append(" ");
                sb.Append(s);
            }
            sb.Append(' ', maxWidth - sb.Length);
            return sb.ToString();
        }
        private string Expand(IList<string> list, int count, int maxWidth)
        {
            StringBuilder sb = new StringBuilder();
            int spaceCount = maxWidth - count;

            while (list.Count > 0)
            {
                sb.Append(list[0]); //add first element of list
                if (list.Count > 1)
                {
                    int per = spaceCount / (list.Count - 1);    // find equal space count
                    if (spaceCount % (list.Count - 1) > 0)      // if they're not equal
                        per++;                                  // Increase the number of space
                    sb.Append(' ', per);
                    spaceCount -= per;                          // Decrease by used spaces.
                }
                list.RemoveAt(0);
            }
            return sb.ToString();
        }

        public void TestFullJustify()
        {
            
            IList<string> list = FullJustify(new string[] { "This", "is", "an", "example", "of", "text", "justification." }, 16);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
