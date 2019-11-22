using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPrepProj.Classes
{
    class AVLNode
    {
        public AVLNode left, right;
        public int height;
        public int data;

        public AVLNode()
        {
            left = null;
            right = null;
            data = 0;
            height = 0;
        }

        public AVLNode(int n)
        {
            left = null;
            right = null;
            data = n;
            height = 0;
        }
    }
}
