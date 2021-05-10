using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree
{
    class binary_search_swap_nodes_algo
    {
        public class Node
        {
            public int? data;
            public int depth;
            public Node left;
            public Node right;
            public Node(int? data, int depth)
            {
                this.data = data;
                this.depth = depth;
            }
        }
        static void swapNodes(int[][] indexes, int[] queries)
        {
            Node root = new Node(1, 1);
            Queue<Node> nodes = new Queue<Node>();
            nodes.Enqueue(root);
            //Create Tree Start
            foreach (var col in indexes)
            {
                var current = nodes.Dequeue();
                if (col[0] == -1)
                {
                    current.left = null;
                }
                else
                {
                    current.left = new Node(col[0], current.depth + 1);
                }
                if (col[1] == -1)
                {
                    current.right = null;
                }
                else
                {
                    current.right = new Node(col[1], current.depth + 1);
                }
                if (current.left != null && current.left.data != -1)
                    nodes.Enqueue(current.left);
                if (current.right != null && current.right.data != -1)
                    nodes.Enqueue(current.right);
            }
            //Create Tree End

            foreach (var query in queries)
            {
                ///Swap Nodes
                var newRoot = swapNodes(root, query);
                //Print by Inorder Traversal
                InOrderTraversal(newRoot);
                Console.WriteLine();
                //newRoot will be current root for next queries to come.
                root = newRoot;
            }
        }
        public static Node swapNodes(Node root, int query)
        {
            Queue<Node> swapQueue = new Queue<Node>();
            swapQueue.Enqueue(root);
            while (swapQueue.Count > 0)
            {
                var currentNode = swapQueue.Dequeue();
                //I had the confusion here earlier, but cleared out later that we need to swap all nodes with multiple of same depth. 
                //Eg: query=2 then swap depth which have multiple of 2
                if (currentNode.depth % query == 0)
                {
                    var temp = currentNode.left;
                    currentNode.left = currentNode.right;
                    currentNode.right = temp;
                }
                if (currentNode.left != null)
                {
                    swapQueue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    swapQueue.Enqueue(currentNode.right);
                }
            }
            return root;
        }
        public static void InOrderTraversal(Node root)
        {
            if (root.left != null)
            {
                InOrderTraversal(root.left);
            }
            //Don't forget to append space " ", test cases will not run :)
            Console.Write(root.data + " ");
            if (root.right != null)
            {
                InOrderTraversal(root.right);
            }
        }
    }
}
