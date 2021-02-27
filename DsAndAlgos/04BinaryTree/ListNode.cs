using System;
using System.Collections.Generic;
using System.Text;

namespace _04BinaryTree
{
    class TreeNode
    {
        public int Val { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int val)
        {
            this.Val = val;
            this.Left = null;
            this.Right = null;
        }
    }
    class BinaryTree
    {
        private TreeNode root;

        public bool IsNull()
        {
            return root == null;
        }

        public void Insert(int val)
        {
            TreeNode tmpNode = FindFirstBlank(root);
            if (tmpNode == null)
            {
                root = new TreeNode(val);
            }
            else
            {
                if (tmpNode.Left == null)
                    tmpNode.Left = new TreeNode(val);
                else if (tmpNode.Right == null)
                    tmpNode.Right = new TreeNode(val);
            }
        }
        public TreeNode Search(int val)
        {
            return root;
        }
        private TreeNode FindFirstBlank(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            else
            {
                Queue<TreeNode> q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Count > 0)
                {
                    int k = q.Count;
                    for (int i = 0; i < k; i++)
                    {
                        TreeNode tmp = q.Dequeue();
                        if (tmp.Left != null)
                        {
                            q.Enqueue(tmp.Left);
                        }
                        else
                        {
                            return tmp;
                        }
                        if (tmp.Right != null)
                            q.Enqueue(tmp);
                        else
                            return tmp;
                    }
                }
            }
            return null;
        }
    }
}
