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
    public partial class LinkedLists : Form
    {
        public LinkedLists()
        {
            InitializeComponent();
        }

        Node node = null;
        
        private void Remove_Duplicates_Click(object sender, EventArgs e)
        {
            AddData();
            Node current = node;
            
            while(current != null)
            {
                Node fastPointer = current;
                while (fastPointer.next != null)
                {
                    if (current.data.ToString() == fastPointer.next.data.ToString())
                    {
                        fastPointer.next = fastPointer.next.next;
                    }
                    else
                    {
                        fastPointer = fastPointer.next;
                    }
                }
                current = current.next;
            }
            PrintNodesFromFirst();
        }

        private void AddData()
        {
            node = new Node();
            ConstructLinkedList();
            InsertAtFirst(4);
            //PrintNodesFromFirst();
            InsertAtLast(4);
            //PrintNodesFromFirst();
            InsertNodeInMiddle(4, 4);
            //PrintNodesFromFirst();
        }

        private void ConstructLinkedList()
        {
            Node head = node;
            int i = 0;
            while (i <= 5)
            {
                
                node.data = 5 - i;
                if(5 - i <= 0)
                {
                    node.next = null;
                }
                else
                {
                    node.next = new Node();
                }
                node = node.next;
                i += 1;
            }

            node = head;
        }

        private void InsertAtFirst(object value)
        {
            Node firstNode = new Node();
            firstNode.data = value;
            firstNode.next = node;
            node = firstNode;
        }

        private void InsertAtLast(object value)
        {
            
            Node newNode = new Node();
            newNode.data = value;
            newNode.next = null;
            if(node == null)
            {
                node = new Node();
                node.data = value;
                node.next = null;
            }
            else
            {
                Node head = node;
                while (head.next != null)
                {
                    head = head.next;
                }
                head.next = newNode;
            }
        }

        private void InsertNodeInMiddle(object value, int index)
        {
            Node head = node;
            int i = 0;
            Node newNode = new Node();
            newNode.data = value;

            while(head.next != null)
            {
                if(i == index)
                {
                    var temp = head.next;
                    newNode.next = temp;
                    head.next = newNode;
                }
                head = head.next;
                i += 1;
            }
        }

        private void PrintNodesFromFirst()
        {
            Node temp = node;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        private void SwapNodesOfLinkedList_Click(object sender, EventArgs e)
        {
            AddData();
            Node current = node;
            SwapNodes(4, 5, current);
        }

        private void SwapNodes(int x, int y, Node head)
        {
            // search

            Node p = head;
            Node prev = null;

            while (p != null && Convert.ToInt32(p.data) != x)
            {
                prev = p;
                p = p.next;
            }
            Node prevX = prev;
            Node pX = p;

            while (p != null && Convert.ToInt32(p.data) != y)
            {
                prev = p;
                p = p.next;
            }
            Node prevY = prev;
            Node pY = p;

            // SWAP

            Node tempY = pY.next;

            pY.next = pX.next;
            pX.next = tempY;

            if (prevX == null)
            {
                head = pY;
                prevY.next = pX;
            }

            if (prevY == null)
            {
                pX = head;
                prevX.next = prevY;
            }

            if (prevX != null && prevY != null)
            {
                prevX.next = pY;
                prevY.next = pX;
            }

        }

        private void SortedRemoveDupe_Click(object sender, EventArgs e)
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
            node.next.next.next.next.next = null;

            var res = RemoveDupe(node);
            var q = res;
        }

        private Node RemoveDupe(Node node)
        {
            if (node == null || node.next == null) { return node; }

            Node p = node.next;
            Node q = node;

            Node head = node;

            while (p != null)
            {
                if (p.data.ToString() == q.data.ToString())
                {
                    q.next = p.next;
                    p = p.next;
                }

                p = p.next;
                q = q.next;
            }

            return head;
        }

        private void CheckIfPalindrome_Click(object sender, EventArgs e)
        {
            Node node = new Node();
            node.data = 1;
            node.next = new Node();
            node.next.data = 2;
            node.next.next = new Node();
            node.next.next.data = 2;
            node.next.next.next = new Node();
            node.next.next.next.data = 1;
            node.next.next.next.next = null;
            //node.next.next.next.next.data = 1;
            //node.next.next.next.next.next = null;

            var res = IsPalindrome(node);
            Console.WriteLine(res);
        }

        private bool IsPalindrome(Node node)
        {
            Node fast = node;
            Node slow = node;
            Node head = node;

            Stack<string> stack = new Stack<string>();

            fast = fast.next.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            if (fast != null && fast.next == null)
            {
                slow = slow.next;
            }
            fast = head;
            while (slow.next != null)
            {
                stack.Push(slow.next.data.ToString());
                slow = slow.next;
            }

            while (stack.Count > 0)
            {
                if (fast.data.ToString() != stack.Pop())
                    return false;

                fast = fast.next;
            }

            return true;
        }

        private Node FormLinkedListNodes()
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
            node.next.next.next.next.next = null;
            return node;
        }
        private void DeleteNodeAtFirst_Click(object sender, EventArgs e)
        {
            var head = FormLinkedListNodes();
            var res = DeleteFirstNode(head);
        }

        private Node DeleteFirstNode(Node node)
        {
            Node toDlete = node;
            node = node.next;
            toDlete = null; //Deleting the node

            return node;
        }

        private Node<int> FormLinkedListNodesOfInt()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 2;
            node.next.next = new Node<int>();
            node.next.next.data = 3;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 4;
            node.next.next.next.next = null;
            return node;
        }
        private Node<int> FormLinkedListNodesOfInt2()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 2;
            node.next.next = null;
            return node;
        }

        private void MergeTwoSortedLinkedLists_Click(object sender, EventArgs e)
        {
            Node<int> l1 = FormLinkedListNodesOfInt();
            Node<int> l2 = FormLinkedListNodesOfInt2();
            var result = MergeTwoSortedLinkedLists_New(l1, l2);
            var x = result;
        }

        public Node<int> MergeTwoLists(Node<int> l1, Node<int> l2)
        {
            if (l1 == null && l2 == null)
                return null;
            else if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;

            Node<int> res = new Node<int>(-1);
            Node<int> res1 = res;

            while (l1 != null && l2 != null)
            {
                if (l1.data < l2.data)
                {
                    res.data = l1.data;
                    l1 = l1.next;
                }
                else
                {
                    res.data = l2.data;
                    l2= l2.next;
                }
                if(l1 != null || l2 != null)
                    res.next = new Node<int>(-1);
                res = res.next;
            }

            while (l1 != null)
            {
                res.data = l1.data;
                l1 = l1.next;
                if(l1 != null)
                    res.next = new Node<int>(-1);
                res = res.next;
            }

            while (l2 != null)
            {
                res.data = l2.data;
                l2 = l2.next;
                if (l2 != null)
                    res.next = new Node<int>(-1);
                res = res.next;
            }

            return res1;
        }

        private Node<int> MergeTwoSortedLinkedLists_New(Node<int> n1, Node<int> n2, Node<int> sorting)
        {
            if (n1 == null)
                return n2;

            if (n2 == null)
                return n1;

            if(n1.data <= n2.data)
            {
                sorting = n1;
                n1 = sorting.next;
            }
            else
            {
                sorting = n2;
                n2 = sorting.next;
            }

            Node<int> newHead = sorting;

            while(n1 != null && n2 != null)
            {
                if(n1.data <= n2.data)
                {
                    sorting.next = n1;
                    sorting = n1;
                    n1 = sorting.next;
                }
                else
                {
                    sorting.next = n2;
                    sorting = n2;
                    n2 = sorting.next;
                }
            }
            if (n1 == null) sorting.next = n2;
            if (n2 == null) sorting.next = n1;
            return newHead;
        }

        private void InsertNodeAtFirst_Click(object sender, EventArgs e)
        {

        }

        private void ReverseTheLinkedlist_Click(object sender, EventArgs e)
        {
            Node l1 = FormLinkedListNodes();
            var res = ReverseLinkList(l1);
        }

        private Node ReverseLinkList(Node head)
        {
            if (head == null || head.next == null)
                return head;

            Node reversed = head;
            Node tobeReversed = head.next;

            reversed.next = null;

            while(tobeReversed != null)
            {
                Node temp = tobeReversed;
                tobeReversed = tobeReversed.next;

                temp.next = reversed;
                reversed = temp;
            }
            return reversed; 
        }

        private void DeleteNodesBasedOnInput_Click(object sender, EventArgs e)
        {
            Node l1 = FormLinkedListNodes();
            var res = DeleteNode(l1, "4");
        }

        private Node DeleteNode(Node head, string d)
        {
            Node p = head;
            Node q = head.next;

            //Delete First Node
            if (p.data.ToString() == d)
            {
                while (p.data.ToString() != d)
                {
                    head = q;
                    ///Delete(p);
                    p = head;
                    q = head.next;
                }
            }

            while (q.data.ToString() == d)
            {
                p = p.next;
                q = q.next;
            }

            // Delete Last Node
            if (q == null)
            {
                p.next = null;
                ///Delete(q);
            }
            else // Delete Middle Node
            {
                p.next = q.next;
                q = q.next.next;
            }
            return head;
        }

        private void IntersectionPointOfTwoLinkedLists_Click(object sender, EventArgs e)
        {

        }

        private Node<int> IntersectionPoint(Node<int> node1, Node<int> node2)
        {
            int node1Len = 0;
            int node2Len = 0;

            if (node1 != null)
            {
                while (node1.next != null)
                {
                    node1Len += 1;
                }
            }

            if (node2 != null)
            {
                while (node2.next != null)
                {
                    node2Len += 1;
                }
            }

            if (node1Len == 0 || node2Len == 0)
                return null;

            int diff = Math.Abs(node1Len - node2Len);

            while (node1 != null && node2 != null)
            {
                if (diff <= 0)
                {
                    if (node1.data == node2.data)
                    {
                        return node1;
                    }
                    else
                    {
                        node1 = node1.next;
                        node2 = node2.next;
                    }
                }
                else
                {
                    if (node1Len > node2Len) { node1 = node1.next; }
                    else { node2 = node2.next; }
                    diff--;
                }
            }
            return null;
        }

        private void ReverseTheLinkedList_2_Click(object sender, EventArgs e)
        {
            var before = FormLinkedListNodesForReverse();
            var after = ReverseTheLinkedList2(before);
        }

        private Node<int> FormLinkedListNodesForReverse()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 2;
            node.next.next = new Node<int>();
            node.next.next.data = 3;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 4;
            node.next.next.next.next = null;
            return node;
        }

        private Node<int> ReverseTheLinkedList2(Node<int> head)
        {
            if (head == null || head.next == null)
                return head;

            Node<int> reversed = head;
            Node<int> tobe = head.next;

            reversed.next = null;

            while (tobe != null)
            {
                Node<int> temp = tobe;
                tobe = tobe.next;

                temp.next = reversed;
                reversed = temp;
            }

            return reversed;
        }

        private void RemoveDuplicatesFromLinkedList_Click(object sender, EventArgs e)
        {
            // var node = FormLinkedListNodesForUnSotedDuplicates();
            // var after = DeleteDuplicates_Unsorted(node);

            var node2 = FormLinkedListNodesForSotedDuplicates();
            var after2 = DeleteDuplicates_Sorted(node2);
        }

        private Node<int> DeleteDuplicates_Unsorted(Node<int> node)
        {
            if (node == null || node.next == null)
                return node;

            Node<int> current = node;
            Node<int> withoutDupe = null;
            Node<int> retNode = null;
            Dictionary<int, int> list = new Dictionary<int, int>();

            while (current != null)
            {
                if (list.ContainsKey(current.data))
                {
                    withoutDupe.next = current.next;
                }
                else
                {
                    list.Add(current.data, current.data);
                    withoutDupe = current;
                }
                current = current.next;
                if(retNode == null)
                {
                    retNode = withoutDupe;
                }
            }
            return retNode;
        }


        private Node<int> DeleteDuplicates_Sorted(Node<int> node)
        {
            if (node == null || node.next == null)
            {
                return node;
            }

            Node<int> current = node;
            Node<int> retNode = current;
            Node<int> delNode = null;

            while (current.next != null)
            {
                if (current.data == current.next.data)
                {
                    delNode = current.next.next;
                    current.next = null;
                    current.next = delNode;
                }
                else
                {
                    current = current.next;
                }
            }
            return retNode;
        }

        private Node<int> FormLinkedListNodesForUnSotedDuplicates()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 2;
            node.next.next = new Node<int>();
            node.next.next.data = 1;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 3;
            node.next.next.next.next = null;
            return node;
        }

        private Node<int> FormLinkedListNodesForSotedDuplicates()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 1;
            node.next.next = new Node<int>();
            node.next.next.data = 2;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 2;
            node.next.next.next.next = null;
            return node;
        }

        private void DeleteNodesByInput_Click(object sender, EventArgs e)
        {
            var node = FormLinkedListNodes2();
            var res = DeleteNodesByGivenInput(node, 1);
        }

        private Node<int> DeleteNodesByGivenInput(Node<int> node, int del)
        {
            Node<int> current = node;

            // Delete the Head node(s)
            if (node.data == del)
            {
                while(node.data == del)
                {
                    node = current.next;
                    current = node;
                }
            }

            while(current.next != null)
            {
                if(current.next.data == del && current.next.next == null) // Delete the last node
                {
                    current.next = null;
                }
                else if(current.next.data == del) // delete the middle node(s)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return node;
        }

        private Node<int> FormLinkedListNodes2()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 1;
            node.next.next = new Node<int>();
            node.next.next.data = 2;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 1;
            node.next.next.next.next = null;
            return node;
        }


        private Node<int> FormLinkedListNodesForInsertionSort()
        {
            Node<int> node = new Node<int>();
            node.data = 6;
            node.next = new Node<int>();
            node.next.data = 5;
            node.next.next = new Node<int>();
            node.next.next.data = 3;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 1;
            node.next.next.next.next = new Node<int>();
            node.next.next.next.next.data = 8;
            node.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.data = 7;
            node.next.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.next.data = 2;
            node.next.next.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.next.next.data = 4;
            node.next.next.next.next.next.next.next.next = null;
            return node;
        }

        private void InsertionSortOfLinkedList_Click(object sender, EventArgs e)
        {
            Node<int> head = FormLinkedListNodesForInsertionSort();
            var res = InsertionSort(head);
        }

        // function to sort a singly linked list using insertion sort 
        private Node<int> InsertionSort(Node<int> head)
        {
            // Initialize sorted linked list 
            Node<int> sorted = null;
            Node<int> current = head;
            // Traverse the given linked list and insert every 
            // node to sorted 
            while (current != null)
            {
                // Store next for next iteration 
                Node<int> next = current.next;
                // insert current in sorted linked list 
                sorted = SortNodes(current, sorted);
                // Update current 
                current = next;
            }
            // Update head_ref to point to sorted linked list 
            //head = sorted;
            return sorted;
        }

        /* 
         * function to insert a new_node in a list. Note that  
         * this function expects a pointer to head_ref as this 
         * can modify the head of the input linked list  
         * (similar to push()) 
         */
        private Node<int> SortNodes(Node<int> newnode, Node<int> sorted)
        {
            /* Special case for the head end */
            if (sorted == null || sorted.data >= newnode.data)
            {
                newnode.next = sorted;
                sorted = newnode;
            }
            else
            {
                Node<int> current = sorted;
                /* Locate the node before the point of insertion */
                while (current.next != null && current.next.data < newnode.data)
                {
                    current = current.next;
                }
                newnode.next = current.next;
                current.next = newnode;
            }

            return sorted;
        }

        private void IntersectionPoint_TwoLinkedLists_Click(object sender, EventArgs e)
        {
            Node<int> node1 = FormLinkedListNodesForIntersectionPoint1();
            Node<int> node2 = FormLinkedListNodesForIntersectionPoint2();

            Node<int> res = IntersectionPointOfTwoLinkedLists2(node1, node2);

        }

        private Node<int> FormLinkedListNodesForIntersectionPoint1()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 2;
            node.next.next = new Node<int>();
            node.next.next.data = 3;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 4;
            node.next.next.next.next = null;
            return node;
        }

        private Node<int> FormLinkedListNodesForIntersectionPoint2()
        {
            Node<int> node = new Node<int>();
            node.data = 7;
            node.next = new Node<int>();
            node.next.data = 3;
            node.next.next = new Node<int>();
            node.next.next.data = 4;
            node.next.next.next = null;
            //node.next.next.next.data = 6;
            //node.next.next.next.next = null;
            return node;
        }

        private Node<int> IntersectionPointOfTwoLinkedLists2(Node<int> node1, Node<int> node2)
        {
            if (node1 == null || node2 == null)
                return null;

            int node1Len = 0;
            int node2Len = 0;

            Node<int> node1Temp = node1;
            Node<int> node2Temp = node2;

            while (node1Temp != null)
            {
                ++node1Len;
                node1Temp = node1Temp.next;
            }

            while (node2Temp != null)
            {
                ++node2Len;
                node2Temp = node2Temp.next;
            }

            int diff = Math.Abs(node1Len - node2Len);
            if (node1Len > node2Len)
            {
                while (diff != 0)
                {
                    node1 = node1.next;
                    --diff;
                }
            }
            else if (node1Len < node2Len)
            {
                node2 = node2.next;
                --diff;
            }

            while (node1 != null && node2 != null)
            {
                if (node1.data == node2.data)
                {
                    return node1;
                }
                else
                {
                    node1 = node1.next;
                    node2 = node2.next;
                }
            }

            return null;
        }

        private void FindKthNodeFromLast_Click(object sender, EventArgs e)
        {
            Node<int> node = FormLinkedListNodesForInsertionSort();
            Node<int> res = NthNodeFromLast(node, 1);
        }

        private Node<int> NthNodeFromLast(Node<int> node, int n)
        {
            if (node == null)
                return null;

            if (n < 1)
                return null;

            Node<int> fast = node;
            Node<int> slow = node;
            int count = 0;

            while (fast != null)
            {
                if (count >= n)
                {
                    slow = slow.next;
                }
                fast = fast.next;
                ++count;
            }

            slow.next = null;
            return slow;
        }

        private void SwapKthNodeWithHead_Click(object sender, EventArgs e)
        {
            Node<int> node = FormLinkedListNodesForSwap();
            Node<int> res = SwapNthNode(node, 1);
        }

        private Node<int> SwapNthNode(Node<int> head, int n)
        {
            if (head == null || head.next == null || n <= 1) { return null; }
            int count = 1;
            Node<int> prev = null;
            Node<int> current = head;

            while (count < n)
            {
                prev = current;
                current = current.next;
                count++;
            }

            Node<int> temp = current.next;
            current.next = head.next;
            head.next = temp;
            prev.next = head;
            head = current;

            return head;
        }

        private Node<int> FormLinkedListNodesForSwap()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 2;
            node.next.next = new Node<int>();
            node.next.next.data = 3;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 4;
            node.next.next.next.next = new Node<int>();
            node.next.next.next.next.data = 5;
            node.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.data = 6;
            node.next.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.next.data = 7;
            node.next.next.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.next.next.data = 8;
            node.next.next.next.next.next.next.next.next = null;
            return node;
        }

        private void MergeTwoSortedLinkedLists_V2_Click(object sender, EventArgs e)
        {
            Node<int> node1 = MergeLinkedLists_Node1();
            Node<int> node2 = MergeLinkedLists_Node2();

            var res = MergeTwoSortedLinkedLists_v2(node1, node2);
            var res2 = res;
        }


        private Node<int> MergeTwoSortedLinkedLists_v2(Node<int> node1, Node<int> node2)
        {
            if (node1 == null) return node2;
            else if (node2 == null) return node1;
            else if (node1 == null && node2 == null) return null;

            Node<int> newNode = new Node<int>(-1);
            Node<int> retNode = newNode;

            while (node1 != null && node2 != null)
            {
                if (node1.data < node2.data)
                {
                    newNode.data = node1.data;
                    node1 = node1.next;
                }
                else
                {
                    newNode.data = node2.data;
                    node2 = node2.next;
                }
                if (node1 != null || node2 != null)
                    newNode.next = new Node<int>(-1);
                newNode = newNode.next;
            }

            while (node1 != null)
            {
                newNode.data = node1.data;
                node1 = node1.next;
                if (node1 != null)
                    newNode.next = new Node<int>(-1);
                newNode = newNode.next;
            }

            while (node2 != null)
            {
                newNode = node2;
                node2 = node2.next;
                if (node2 != null)
                    newNode.next = new Node<int>(-1);
                newNode = newNode.next;
            }

            return retNode;
        }


        private Node<int> MergeLinkedLists_Node1()
        {
            Node<int> node = new Node<int>();
            node.data = 1;
            node.next = new Node<int>();
            node.next.data = 3;
            node.next.next = new Node<int>();
            node.next.next.data = 5;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 7;
            node.next.next.next.next = null;
            return node;
        }

        private Node<int> MergeLinkedLists_Node2()
        {
            Node<int> node = new Node<int>();
            node.data = 2;
            node.next = new Node<int>();
            node.next.data = 4;
            node.next.next = new Node<int>();
            node.next.next.data = 6;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 8;
            node.next.next.next.next = null;
            return node;
        }

        private void MergeSortOnLinkedList_Click(object sender, EventArgs e)
        {
            Node<int> node = FormLinkedListNodesForMergeSort();
            var res = DivideList(node);
            var res2 = res;
        }

        private Node<int> DivideList(Node<int> node)
        {
            Node<int> oldList = node;
            Node<int> lenNode = node;
            if (node == null || node.next == null) { return node; }
            int len = 0;
            while (lenNode != null)
            {
                len++;
                lenNode = lenNode.next;
            }
            int mid = len / 2;

            while (mid - 1 > 0)
            {
                oldList = oldList.next;
                mid--;
            }

            Node<int> newList = oldList.next;
            oldList.next = null;
            oldList = node;

            Node<int> t1 = DivideList(oldList);
            Node<int> t2 = DivideList(newList);

            return MergeList(t1, t2);
        }

        private Node<int> MergeList(Node<int> a, Node<int> b)
        {
            if (a == null)
                return b;
            else if (b == null)
                return a;
            else if (a == null || b == null)
                return null;

            Node<int> retNode = null;
            if (a.data > b.data)
            {
                retNode = b;
                retNode.next = MergeList(a, b.next);
            }
            else
            {
                retNode = a;
                retNode.next = MergeList(a.next, b);
            }
            return retNode;
        }

        private Node<int> FormLinkedListNodesForMergeSort()
        {
            Node<int> node = new Node<int>();
            node.data = 4;
            node.next = new Node<int>();
            node.next.data = 8;
            node.next.next = new Node<int>();
            node.next.next.data = 5;
            node.next.next.next = new Node<int>();
            node.next.next.next.data = 1;
            node.next.next.next.next = new Node<int>();
            node.next.next.next.next.data = 7;
            node.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.data = 3;
            node.next.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.next.data = 6;
            node.next.next.next.next.next.next.next = new Node<int>();
            node.next.next.next.next.next.next.next.data = 2;
            node.next.next.next.next.next.next.next.next = null;
            return node;
        }

        private void SwapEvenNodes_Click(object sender, EventArgs e)
        {
            Node<int> node = FormLinkedListNodesForSwap();
            Node<int> res = SwapEvenNodesMethod(node);
        }

        private Node<int> SwapEvenNodesMethod(Node<int> node)
        {
            if (node == null || node.next == null || node.next.next == null || node.next.next.next.next == null) { return null; }

            int x = 4;
            Node<int> retNode = node;
            Node<int> prev = null;
            Node<int> even1 = null;
            Node<int> even2 = null;
            Node<int> temp = null;
            Node<int> next = null;

            int count = 1;
            while (node != null)
            {
                if(count == 1)
                {
                    prev = node;
                }
                if (count == 2)
                {
                    even1 = node;
                    next = node;
                }
                if (count == 4)
                {
                    even2 = node;
                    temp = even1.next;

                    even1.next = even2.next;
                    temp.next = even1;
                    prev.next = even2;
                    even2.next = temp;

                    while(node.data != next.data)
                    {
                        node = node.next;
                    }
                    
                    //node.next = next;
                    count = 0;
                }

                count++;
                node = node.next;
            }
            return retNode;
        }

        private void RotateLinkedList_Click(object sender, EventArgs e)
        {
            Node<int> node = FormLinkedListNodesForSwap();
            Node<int> res = RotateLinkedListV2(node, 4);
        }

        private Node<int> RotateLinkedListV2(Node<int> node, int k)
        {
            Node<int> head = node;
            while (node.data != k)
            {
                node = node.next;
            }

            Node<int> newHead = node.next;
            Node<int> newHeadReturn = node.next;
            node.next = null;

            while (newHead.next != null)
            {
                newHead = newHead.next;
            }
            newHead.next = head;
            return newHeadReturn;
        }

        private void ReverseLinkedListOnGroupByK_Click(object sender, EventArgs e)
        {
            Node<int> node = FormLinkedListNodesForSwap();
            Node<int> res = ReverseLinkedListByGrouoOfKElements(node, 3);
        }

        private Node<int> ReverseLinkedListByGrouoOfKElements(Node<int> head, int k)
        {
            if (head == null || head.next == null)
                return head;

            if (k < 2)
                return null;

            int x = k;
            Node<int> h = head;
            Node<int> prev = null;
            Node<int> next = null;

            while (x > 0 && h != null)
            {
                next = h.next;
                h.next = prev;
                prev = h;
                h = next;

                x--;
            }
            if (next != null)
                head.next = ReverseLinkedListByGrouoOfKElements(next, k);

            return prev;
        }


        Node<int> retNode = null;
        int carry = 0;
        private void AddTwoLinkedLists_Click(object sender, EventArgs e)
        {
            Node<int> node1 = MergeLinkedLists_Node1();
            Node<int> node2 = MergeLinkedLists_Node2();

            var res = AddTwoInt(node1, node2);

            if(carry != 0)
            {
                Node<int> n = new Node<int>();
                n.data = carry;
                n.next = res;
                res = n;
            }
            Console.WriteLine(res); // res is the output
        }
        
        private Node<int> AddTwoInt(Node<int> node1, Node<int> node2)
        {
            if (node1 == null && node2 == null)
            {
                return null;
            }
            AddTwoInt(node1.next, node2.next);
            int sum = node1.data + node2.data + carry;
            carry = 0;
            if (sum >= 10)
            {
                carry = 1;
                sum = sum % 10;
            }

            Node<int> newNode = new Node<int>(-1);
            newNode.data = sum;

            if (retNode == null)
                retNode = newNode;
            else
            {
                newNode.next = retNode;
                retNode = newNode;
            }
            return retNode;
}
    }
}
