using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BST
    {
        public Node root;
        

        public BST()
        {
            root = null;
        }

        public void Add(int dataToAdd)
        {
            Node toAdd = new Node(dataToAdd);

            if(root == null)
            {
                root = toAdd;
            }
            else if( root != null)
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (dataToAdd <= current.data)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = toAdd;
                            break;
                        }

                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = toAdd;
                            break;
                        }
                    }
                }
            }
        }

        public void Search(Node node, int primary)
        {
            
            if(node == null)
            {
                Console.WriteLine("Sorry no node was found!");
            }
            else if(node.data == primary)
            {
                Console.WriteLine("Node found!");
            }
            else if (primary < node.data)
            {
                Search(node.left, primary);
            }
            else
            {
                Search(node.right, primary);
            }
        }
    }
}
