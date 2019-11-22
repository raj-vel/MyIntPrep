using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPrepProj.Classes
{
    class AVLTree
    {
        public AVLNode root;

        public AVLTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void MakeEmpty()
        {
            root = null;
        }

        private int GetHeight(AVLNode node)
        {
            if (node == null)
                return -1;
            else
                return node.height;
        }

        private int GetMax(int left, int right)
        {
            if (left > right)
                return left;
            else
                return right;
        }

        private int GetBalance(AVLNode node)
        {
            if (node == null)
                return 0;

            return GetHeight(node.left) - GetHeight(node.right);

        }

        private AVLNode RotateLeft(AVLNode node1)
        {
            if(node1 != null)
            {
                AVLNode node2 = node1.left;
                node1.left = node2.right;
                node2.right = node1;

                node1.height = GetMax(GetHeight(node1.left), GetHeight(node1.right)) + 1;
                node2.height = GetMax(GetHeight(node2.left), GetHeight(node2.right)) + 1;

                return node2;
            }
            return node1;
        }

        private AVLNode RotateRight(AVLNode node1)
        {
            if(node1 != null)
            {
                AVLNode node2 = node1.right;
                node1.right = node2.left;
                node2.left = node1;

                node1.height = GetMax(GetHeight(node1.left), GetHeight(node1.right)) + 1;
                node2.height = GetMax(GetHeight(node2.left), GetHeight(node2.right)) + 1;

                return node2;
            }
            return node1;
        }

        private AVLNode DoubleRotateWithLeft(AVLNode node1)
        {
            node1.left = RotateRight(node1.left);
            return RotateLeft(node1);
        }
        private AVLNode DoubleRotateWithRight(AVLNode node2)
        {
            node2.right = RotateLeft(node2.right);
            return RotateRight(node2);
        }
        

        public AVLNode Insert(AVLNode node, int val)
        {
            // Perform Insersion
            if (node == null)
                return new AVLNode(val);
            else if (val < node.data)
            {
                node.left = Insert(node.left, val);
                if (GetHeight(node.left) - GetHeight(node.right) == 2)
                {
                    if (val < node.left.data)
                        node = RotateLeft(node);
                    else
                        node = DoubleRotateWithLeft(node);
                }
            }
            else if (val > node.data)
            {
                node.right = Insert(node.right, val);
                if (GetHeight(node.right) - GetHeight(node.left) == 2)
                {
                    if (val > node.right.data)
                        node = RotateRight(node);
                    else
                        node = DoubleRotateWithRight(node);
                }
            }

            else
                ; // Do nothing, so no duplicates gets inserted    
            // Update height of Binay Tree
            node.height = GetMax(GetHeight(node.left), GetHeight(node.right)) + 1;
            return node;
        }
    }
}
