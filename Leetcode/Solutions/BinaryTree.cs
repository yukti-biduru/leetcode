using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class BinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        // Root Left Right
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }

            // if Node value is not null, add node's val
            void f(TreeNode node)
            {
                if (node == null)
                {
                    return;
                }
                res.Add(node.val);

                // recursion of function over left side
                f(node.left);
                // recursion of function over left side
                f(node.right);
            }
            f(root);
            return res;
        }


        // Left Root Right
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            TreeNode currNode = root;

            // list the left nodes  
            while (currNode != null || nodes.Count != 0)
            {
                while (currNode != null)
                {
                    nodes.Push(currNode);
                    currNode = currNode.left;
                }

                // for each left node print the node and its right child
                if (nodes.Count != 0)
                {
                    currNode = nodes.Pop();
                    result.Add(currNode.val);
                    currNode = currNode.right;
                }
            }
            return result;
        }
        // Traverse the left tree first and then the right then the root 
        public IList<int> PostorderTraversal1(TreeNode root)
        {
            if (root == null)
                return new List<int>();
            Stack<TreeNode> rootNodes = new Stack<TreeNode>(), nodes = new Stack<TreeNode>();
            rootNodes.Push(root);
            while (rootNodes.Count != 0)
            {
                TreeNode curr = rootNodes.Pop();
                nodes.Push(curr);

                if (curr.left != null)
                {
                    rootNodes.Push(curr.left);
                }
                if (curr.right != null)
                {
                    rootNodes.Push(curr.right);
                }
            }
            IList<int> res = new List<int>();
            while (nodes.Count !=0)
            {
                res.Add(nodes.Pop().val);
            }

            return res;
        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            Stack<TreeNode> rootNodes = new Stack<TreeNode>(),
                nodes = new Stack<TreeNode>();

            rootNodes.Push(root);
            while (rootNodes.Count != 0)
            {
                TreeNode currNode = rootNodes.Pop();
                nodes.Push(currNode);

                if (currNode.left != null)
                {
                    rootNodes.Push(currNode.left);
                }
                if (currNode.right != null)
                {
                    rootNodes.Push(currNode.right);
                }
            }
            IList<int> result = new List<int>();
            while (nodes.Count != 0)
            {
                result.Add(nodes.Pop().val);
            }
            return result;
        }
    }
}
