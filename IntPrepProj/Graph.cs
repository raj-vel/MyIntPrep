using IntPrepProj.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntPrepProj
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void AdjacencyListImplementation_Click(object sender, EventArgs e)
        {
            // Adding Vertex
            GraphAdjacencyList<int> adjacencyList1 = new GraphAdjacencyList<int>(5);
            GraphAdjacencyList<int> adjacencyList2 = new GraphAdjacencyList<int>(10);
            GraphAdjacencyList<int> adjacencyList3 = new GraphAdjacencyList<int>(15);

            // Adding Edge
            adjacencyList1.AddEdge(5, 10);
            adjacencyList1.AddEdge(5, 15);

            var neighbours = adjacencyList1.GetAllNeighbours(5);
            neighbours.ForEach(Console.WriteLine);
        }

        private void DFS_CloneUndirectedGraph_Click(object sender, EventArgs e)
        {
            // {0, 1, 2#1, 2#2, 2}

            GraphNode node0 = new GraphNode(0);
            GraphNode node1 = new GraphNode(1);
            GraphNode node2 = new GraphNode(2);

            List<GraphNode> list0 = new List<GraphNode>();
            list0.Add(node1);
            list0.Add(node2);
            node0.neighbors = list0;

            node1.neighbors = new List<GraphNode>();
            node1.neighbors.Add(node2);

            node2.neighbors = new List<GraphNode>();
            node2.neighbors.Add(node2);

            var nodesCompleted = new Dictionary<int, GraphNode>();
            GraphNode newClone = CloneUndirectedGraph_DFS(node0,  nodesCompleted);
            nodesCompleted = new Dictionary<int, GraphNode>();
            GraphNode newClone2 = CloneUndirectedGraph_DFS(node1, nodesCompleted);
            nodesCompleted = new Dictionary<int, GraphNode>();
            GraphNode newClone3 = CloneUndirectedGraph_DFS(node2, nodesCompleted);
        }

        private GraphNode CloneUndirectedGraph_DFS(GraphNode node, Dictionary<int, GraphNode> nodesCompleted)
        {
            if (node == null)
                return null;

            if (nodesCompleted.ContainsKey(node.val))
                return nodesCompleted[node.val];

            GraphNode newNode = new GraphNode(node.val);
            nodesCompleted.Add(node.val, newNode);

            foreach(GraphNode neighbor in node.neighbors)
            {
                newNode.neighbors.Add(CloneUndirectedGraph_DFS(neighbor, nodesCompleted));
            }
            return newNode;
        }

        private void BFS_CloneUndirectedGraph_Click(object sender, EventArgs e)
        {
            // {0, 1, 2#1, 2#2, 2}

            GraphNode node0 = new GraphNode(0);
            GraphNode node1 = new GraphNode(1);
            GraphNode node2 = new GraphNode(2);

            List<GraphNode> list0 = new List<GraphNode>();
            list0.Add(node1);
            list0.Add(node2);
            node0.neighbors = list0;

            node1.neighbors = new List<GraphNode>();
            node1.neighbors.Add(node2);

            node2.neighbors = new List<GraphNode>();
            node2.neighbors.Add(node2);

            var nodesCompleted = new Dictionary<int, GraphNode>();
            GraphNode newClone = CloneUndirectedGraph_BFS(node0);
            nodesCompleted = new Dictionary<int, GraphNode>();
            GraphNode newClone2 = CloneUndirectedGraph_BFS(node1);
            nodesCompleted = new Dictionary<int, GraphNode>();
            GraphNode newClone3 = CloneUndirectedGraph_BFS(node2 );
        }

        private GraphNode CloneUndirectedGraph_BFS(GraphNode node)
        {
            if (node == null)
                return null;

            Dictionary<GraphNode, GraphNode> dict = new Dictionary<GraphNode, GraphNode>();
            Queue<GraphNode> queue = new Queue<GraphNode>();

            queue.Enqueue(node);
            var newNode = new GraphNode(node.val);
            while(queue.Count > 0)
            {
                var curr = queue.Dequeue();
                foreach(var neighbor in curr.neighbors)
                {
                    if(dict.ContainsKey(neighbor))
                    {
                        dict[curr].neighbors.Add(dict[neighbor]);
                    }
                    else
                    {
                        var newNeighbor = new GraphNode(neighbor.val);
                        dict.Add(neighbor, newNeighbor);
                        dict[curr].neighbors.Add(newNeighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return newNode;
        }
    }
}
