using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTree.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is the tree of Life, the Universe and Everything.");
            BinaryTree binarytree = new BinaryTree();
            binarytree.InstantiateTree();
            binarytree.Traverse();
            Console.WriteLine();
        }
    }
}
