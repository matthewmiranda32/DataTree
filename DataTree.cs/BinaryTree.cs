using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTree.cs
{
    public class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            root = null;
        }
        public void Traverse()
        {
            Traverse(root, 0);
            Console.WriteLine();
        }

        public void Traverse(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            Traverse(node.right, level + 1);
            Console.WriteLine();

            for (int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
            Console.Write(node.data);

            Traverse(node.left, level + 1);
            
        }

        public void InstantiateTree()
        {
            root = new Node(28);
            root.left = new Node(38);
            root.right = new Node(42);
            root.left.left = new Node(35);
            root.left.right = new Node(107);
            root.right.left = new Node(67);
            root.right.right = new Node(97);
        }
    }
}
