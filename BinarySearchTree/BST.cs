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
            Node toAdd = new Node((int)dataToAdd);

            if(root == null)
            {
                root = toAdd;
                return;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (dataToAdd < current.data)
                    {
                        if(current == null)
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
    }
}
