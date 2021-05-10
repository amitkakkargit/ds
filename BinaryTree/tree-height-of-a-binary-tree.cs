using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
        }
    }
    class tree_height_of_a_binary_tree
    {
        public static int height(Node root)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (root.left != null)
            {
                leftHeight = 1 + height(root.left);
            }

            if (root.right != null)
            {
                rightHeight = 1 + height(root.right);
            }

            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }
    }
}
