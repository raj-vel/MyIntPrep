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
    public partial class LinkedList_V2 : Form
    {
        public LinkedList_V2()
        {
            InitializeComponent();
        }

        private void PrintLinkedList(ListNode node)
        {
            Console.WriteLine("");
            while(node != null)
            {
                Console.Write(node.data + "-->");
                node = node.next;
            }
            Console.Write("null");
            Console.WriteLine("");
        }

        private ListNode FormLinkedList()
        {
            ListNode head = new ListNode(1);
            ListNode newHead = head;
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            return newHead;
        }

        private void InsertNodeAtFront_Click(object sender, EventArgs e)
        {
            ListNode node = new ListNode(9);

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            PrintLinkedList(head);
            var res = AddNodeAtFront(node, head);
            PrintLinkedList(res);
        }

        private ListNode AddNodeAtFront(ListNode node, ListNode head)
        {
            if (node == null)
                return null;

            node.next = head;
            head = node;

            return head;
        }

        private void InsertNodeAtLast_Click(object sender, EventArgs e)
        {
            ListNode node = new ListNode(9);

            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            PrintLinkedList(head);
            var res = InsertNodeatLast(node, head);
            PrintLinkedList(res);
        }

        private ListNode InsertNodeatLast(ListNode node, ListNode head)
        {
            if (node == null || head == null)
                return null;

            ListNode newHead = head;
            while (head.next != null)
            {
                head = head.next;
            }
            head.next = node;
            return newHead;
        }

        private void InsertNodeInMid_Click(object sender, EventArgs e)
        {
            ListNode head = FormLinkedList();
            ListNode node = new ListNode(9);

            PrintLinkedList(head);
            var res = InsertNodeInMiddle(node, head, 3);
            PrintLinkedList(res);
        }

        private ListNode InsertNodeInMiddle(ListNode node, ListNode head, int x)
        {
            if (node == null || head == null)
                return null;

            ListNode newHead = head;

            while(head != null && head.data != x)
            {
                head = head.next;
            }

            if(head != null)
            {
                ListNode temp = head.next;
                head.next = node;
                node.next = temp;
            }

            return newHead;
        }

        private void DeleteANodeFromLinkedList_Click(object sender, EventArgs e)
        {
            ListNode head = FormLinkedList();
            PrintLinkedList(head);
            var res = DeleteNodeFromLinkedList(head, 0);
            PrintLinkedList(res);
        }

        private ListNode DeleteNodeFromLinkedList(ListNode node, int delIndex)
        {
            if (node == null || node.next == null || delIndex < 1)
                return node;

            // Head Node
            if (delIndex == 1)
                return node.next;

            int count = 1;
            ListNode prev = node;
            ListNode newHead = prev;
            
            while (count != delIndex && node != null)
            {
                prev = node;
                node = node.next;
                ++count;
            }

            if(node != null)
                prev.next = node.next;

            return newHead;
        }

        private void MergeTwoSortedLinkedLists_Click(object sender, EventArgs e)
        {
            ListNode node1 = FormLinkedList();
            PrintLinkedList(node1);
            ListNode node2 = FormLinkedList();
            PrintLinkedList(node2);
            var res = MergeSortedLists(node1, node2);
            PrintLinkedList(res);
        }

        private ListNode MergeSortedLists(ListNode node1, ListNode node2)
        {
            if (node1 == null)
                return node2;
            if (node2 == null)
                return node1;

            ListNode temp = null;
            ListNode newHead = null;

            if(node1.data <= node2.data)
            {
                temp = node1;
                node1 = node1.next;
            }
            else
            {
                temp = node2;
                node2 = node2.next;
            }

            newHead = temp;

            while(node1 != null && node2 != null)
            {
                if(node1.data <= node2.data)
                {
                    temp.next = node1;
                    temp = node1;
                    node1 = temp.next;
                }
                else
                {
                    temp.next = node2;
                    temp = node2;
                    node2 = temp.next;
                }
            }

            if (node1 == null)
                temp.next = node2;

            if (node2 == null)
                temp.next = node1;

            return newHead;
        }

        private void ReverseTheLinkedList_Click(object sender, EventArgs e)
        {

        }

        private ListNode ReverseLinkedList_InPlace(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode tobe = head.next;
            ListNode reversed = head;

            reversed.next = null;

            while (tobe != null)
            {
                ListNode temp = tobe;
                tobe = tobe.next;

                temp.next = reversed;
                reversed = temp;
            }

            return reversed;
        }
    }
}
