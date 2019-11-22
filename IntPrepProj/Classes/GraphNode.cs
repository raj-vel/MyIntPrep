using System;
using System.Collections.Generic;

namespace IntPrepProj.Classes
{
    class GraphNode
    {
        public int val;
        //GraphNode next;
        public List<GraphNode> neighbors;
        bool visited;

        public GraphNode(int x)
        {
            val = x;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int x, List<GraphNode> n)
        {
            val = x;
            neighbors = n;
        }

        public String toString()
        {
            return "value: " + this.val;
        }
    }
}
