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

namespace CrackingCodingInterview
{
    public partial class Week1 : Form
    {
        public Week1()
        {
            InitializeComponent();
        }

        private string GetInputFromUser()
        {
            Console.Clear();
            var input = Console.ReadLine();
            return input;
        }

        private void IsStringUnique_Click(object sender, EventArgs e)
        {
            Console.Clear();
            var input = Console.ReadLine();
            var res = isUnique_Array(input);
            Console.WriteLine(String.Format("The Input {0} is {1}Unique", input, res ? "" : "NOT "));
        }

        private bool isUnique_Array(string str)
        {
            bool[] arr = new bool[128];
            foreach (char c in str)
            {
                int val = (int)c;
                if (arr[val])
                {
                    return false;
                }
                else
                {
                    arr[val] = true;
                }
            }
            return true;
        }

        private void Palindrome_Permutation_Click(object sender, EventArgs e)
        {
            string input = GetInputFromUser();
            var res = PalindromePermutation(input);
            Console.WriteLine(res);
        }

        private bool PalindromePermutation(string str)
        {
            Dictionary<string, bool> list = new Dictionary<string, bool>();
            foreach (char c in str)
            {
                if (list.ContainsKey(c.ToString()))
                {
                    var temp = list[c.ToString()];
                    list[c.ToString()] = !temp;
                }
                else
                {
                    list.Add(c.ToString(), false);
                }
            }
            int retCount = 0;
            foreach (var l in list)
            {
                if (l.Value == true)
                {
                    ++retCount;
                    if (retCount > 1)
                        return false;
                }
            }
            return true;
        }

        private void RotateMatrixToRight_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            PrintMatrix(arr);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Step One: After HorizontalSwap");
            var arr1 = HorizontalSwap(arr);
            Console.WriteLine();
            PrintMatrix(arr1);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Step Two: After DiagonalSwap");
            Console.WriteLine();
            var arr2 = DiagonalSwap(arr1);
            PrintMatrix(arr2);
        }

        private int[,] HorizontalSwap(int[,] arr)
        {
            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);

            int x = 0; int y = colLen - 1;

            while (x < (colLen/2))
            {
                for (int i = 0; i < colLen; i++)
                {
                    var temp = arr[x, i];
                    arr[x, i] = arr[y, i];
                    arr[y, i] = temp;
                }
                x++;
                y--;
            }
            return arr;
        }

        private int[,] DiagonalSwap(int[,] arr)
        {
            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);
            int count = 1;
            int x = 0; int y = colLen;

            while (count < colLen)
            {
                for (int i = count; i < colLen; i++)
                {
                    var temp = arr[x, i];
                    arr[x, i] = arr[i, x];
                    arr[i, x] = temp;
                }
                x++;
                count++;
            }
            return arr;
        }

        private void PrintMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void RemoveDuplicateFromLinkedList_Click(object sender, EventArgs e)
        {
            Node node = AddNodesToLinkedListWithDupes();
            var res = RemoveDupFromLL(node);
            PrintNodesFromFirst(res);
        }

        private Node RemoveDupFromLL(Node node)
        {
            Node Head = node;

            while (Head != null)
            { 
                Node fast = Head;
                while (fast != null && fast.next != null)
                {
                    if (Head.data.ToString() == fast.next.data.ToString()) // dup detected
                    {
                        fast.next = fast.next.next;
                    }
                    fast = fast.next;
                }
                Head = Head.next;
            }
            return node;
        }

        private Node AddNodesToLinkedListWithDupes()
        {
            Node node = new Node();
            node.data = 1;
            node.next = new Node();
            node.next.data = 2;
            node.next.next = new Node();
            node.next.next.data = 3;
            node.next.next.next = new Node();
            node.next.next.next.data = 3;
            node.next.next.next.next = new Node();
            node.next.next.next.next.data = 4;
            node.next.next.next.next.next = new Node();
            node.next.next.next.next.next.data = 4;

            return node;
        }

        private void PrintNodesFromFirst(Node node)
        {
            Node temp = node;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }


        private Node PartitionLL(Node node, int x)
        {
            Node first = node;
            Node last = node;

            while (node != null)
            {
                Node next = node.next;
                if (Convert.ToInt32(node.data) < x)
                {
                    node.next = first;
                    first = node;
                }
                else
                {
                    last.next = node;
                    last = node;
                }
                node = next;
            }
            last.next = null;
            return first;
        }

        private void PartitionOfLinkedList_Click(object sender, EventArgs e)
        {
            var node = AddNodesForPartition();
            var res = PartitionLL(node, 5);
            PrintNodesFromFirst(res);
        }

        private Node AddNodesForPartition()
        {
            Node node = new Node();
            node.data = 3;
            node.next = new Node();
            node.next.data = 5;
            node.next.next = new Node();
            node.next.next.data = 8;
            node.next.next.next = new Node();
            node.next.next.next.data = 5;
            node.next.next.next.next = new Node();
            node.next.next.next.next.data = 10;
            node.next.next.next.next.next = new Node();
            node.next.next.next.next.next.data = 2;
            node.next.next.next.next.next.next = new Node();
            node.next.next.next.next.next.next.data = 1;

            return node;
        }

        private void IntersectionOfTwoLinkedLists_Click(object sender, EventArgs e)
        {
            Node commonNode = new Node();
            commonNode.data = 9;
            commonNode.next = new Node();
            commonNode.next.data = 10;

            Node node1 = new Node();
            node1.data = 3;
            node1.next = new Node();
            node1.next.data = 5;
            node1.next.next = new Node();
            node1.next.next.data = 7;
            node1.next.next.next = new Node();
            node1.next.next.next.data = 8;
            node1.next.next.next.next = commonNode;

            Node node2 = new Node();
            node2.data = 2;
            node2.next = new Node();
            node2.next.data = 4;
            node2.next.next = commonNode;

            var res = GetIntersectionNode(node1, node2);

            Console.WriteLine($"Intersection of node us at {Convert.ToString(res.data)}");
        }

        private int GetLengthOfLinkedlist(Node node)
        {
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            return count;
        }

        private Node GetIntersectionNode(Node node1, Node node2)
        {
            if (node1 == null || node2 == null) return null;
            // Get Length Of Node 1 and 2
            int node1Len = GetLengthOfLinkedlist(node1);
            int node2Len = GetLengthOfLinkedlist(node2);

            int skipNodesLen = Math.Abs(node1Len - node2Len);
            bool incrementFirstNode = node1Len > node2Len ? true : false;
            if (incrementFirstNode)
            {
                int count = 0;
                while (node1 != null && count < skipNodesLen)
                {
                    count++;
                    node1 = node1.next;
                }
            }
            else
            {
                int count = 0;
                while (node2 != null && count < skipNodesLen)
                {
                    count++;
                    node2 = node2.next;
                }
            }

            while (node1 != null && node2 != null)
            {
                if (node1 == node2)
                {
                    return node1;
                }
                node1 = node1.next;
                node2 = node2.next;
            }
            return null;
        }
    }
}
