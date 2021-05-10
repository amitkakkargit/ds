using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{

    public class binary_tree_traversals
    {
        /// <summary>
        ///          8        
        ///        /   \
        ///       6     10
        ///     /  \    / \ 
        ///    5    7  9   15
        ///  /
        /// 3
        /// </summary>
        /// <returns></returns>
        public Node MakeTree()
        {
            Node root = new Node(8);
            root.left = new Node(6);
            root.right = new Node(10);
            root.left.left = new Node(5);
            root.left.right = new Node(7);
            root.left.left.left = new Node(3);
            root.right.left = new Node(9);
            root.right.right = new Node(15);
            return root;
        }
        /// <summary>
        /// left -> root -> right ->
        /// 3,5,6,7,8,9,10,15
        /// </summary>
        /// <param name="root"></param>
        public void InOrderTraversal(Node root)
        {
            if (root.left != null)
            {
                InOrderTraversal(root.left);
            }
            Console.Write(string.Concat(root.data, ","));
            if (root.right != null)
            {
                InOrderTraversal(root.right);
            }
        }

        /// <summary>
        /// root -> left -> right
        /// 8,6,5,3,7,10,9,15
        /// </summary>
        /// <param name="root"></param>
        public void PreOrderTraversal(Node root)
        {
            Console.Write(string.Concat(root.data, ","));
            if (root.left != null)
            {
                PreOrderTraversal(root.left);
            }
            if (root.right != null)
            {
                PreOrderTraversal(root.right);
            }
        }

        /// <summary>
        /// left -> right -> root
        /// 3,5,7,6,9,15,10,8
        /// </summary>
        /// <param name="root"></param>
        public void PostOrderTraversal(Node root)
        {
            if (root.left != null)
            {
                PostOrderTraversal(root.left);
            }
            if (root.right != null)
            {
                PostOrderTraversal(root.right);
            }
            Console.Write(string.Concat(root.data, ","));
        }
    }
}
