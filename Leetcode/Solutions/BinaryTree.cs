using System;
using System.Collections.Generic;
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }

            void f(TreeNode node)
            {
                if (node == null)
                {
                    return;
                }
                res.Add(node.val);
                f(node.left);
                f(node.right);
            }
            f(root);
            return res;
        }

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
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if(root == null)
            {
                return new List<int>();
            }
            Stack<TreeNode> rootNodes = new Stack<TreeNode>(),
                nodes = new Stack<TreeNode>();

            rootNodes.Push(root);
            while(rootNodes.Count != 0)
            {
                TreeNode currNode = rootNodes.Pop();
                nodes.Push(currNode);

                if(currNode.left != null)
                {
                    rootNodes.Push(currNode.left);
                }
                if (currNode.right != null)
                {
                    rootNodes.Push(currNode.right);
                }
            }
            IList<int> result = new List<int>();
            while(nodes.Count != 0)
            {
                result.Add(nodes.Pop().val);
            }
            return result;
        }
    }
}
