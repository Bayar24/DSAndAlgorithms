using System;
using System.Collections.Generic;
using System.Text;

namespace _05BST
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
    class BST
    {
        private TreeNode root;

        public bool IsNull()
        {
            return root == null;
        }



        public void Insert(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return;
            }

            TreeNode node = root;

            while (node != null)
            {
                if (node.Val > value)
                {
                    if (node.Left == null)
                    {
                        node.Left = new TreeNode(value);
                        break;
                    }
                    else
                        node = node.Left;
                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new TreeNode(value);
                        break;
                    }
                    else
                        node = node.Right;
                }
            }
        }


        public void Remove(int value)
        {
            Remove(root, value);
        }

        private TreeNode Remove(TreeNode node, int value)
        {

            if (node.Val == value)
            {
                if (node.Left != null && node.Right != null)
                {
                    TreeNode bst = this.RightLeft(node);
                    node.Val = bst.Val;
                    node.Right = this.Remove(node.Right, bst.Val);
                }
                else if (node.Left != null)
                {
                    node.Val = node.Left.Val;
                    node.Right = node.Left.Right;
                    node.Left = node.Left.Left;
                }
                else if (node.Right != null)
                {
                    node.Val = node.Right.Val;
                    node.Left = node.Right.Left;
                    node.Right = node.Right.Right;

                }
                else
                    return null;

            }
            else if (node.Val > value)
            {
                node.Left = Remove(node.Left, value);
            }
            else
                node.Right = Remove(node.Right, value);

            return node;
        }

        private TreeNode RightLeft(TreeNode node)
        {
            node = node.Right;
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public void Print()
        {
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            while (nodes.Count>0)
            {
                Console.WriteLine();
                int count = nodes.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode tmp = nodes.Dequeue();
                    Console.Write(" " + tmp.Val);
                    if (tmp.Left != null)
                    {
                        nodes.Enqueue(tmp.Left);
                    }
                    if (tmp.Right != null)
                    {
                        nodes.Enqueue(tmp.Right);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
