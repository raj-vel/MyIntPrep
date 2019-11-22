using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPrepProj.Classes
{
    class BinaryTree
    {
    }

    public class BTNode
    {
        public int data;
        public BTNode left, right;

        public BTNode(int item)
        {
            data = item;
            left = right = null;
        }

        public BTNode()
        {
            data = -1;
            left = right = null;
        }
    }
}
