using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST binarysearch = new BST();
            binarysearch.Add(20);
            binarysearch.Add(60);
            binarysearch.Add(32);
            binarysearch.Add(70);
            binarysearch.Add(56);
            binarysearch.Add(17);
            binarysearch.Add(40);
            binarysearch.Add(12);
            binarysearch.Add(22);
            Console.WriteLine("Binary Search Tree is created");
            Console.WriteLine("Please enter a number to search in the tree");
            Console.ReadLine();

            binarysearch.Search(binarysearch.root, 24);
            Console.ReadLine();
        }
    }
}
