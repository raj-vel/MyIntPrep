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
    public partial class BinaryTree : Form
    {
        
        public BinaryTree()
        {
            InitializeComponent();
        }

        private void SumOfNodesEqualToGivenSum_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforSum();
            List<int> path = new List<int>();
            path.Add(node.data);
            var result = HasPath(node, 15, path);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(result);
        }

        private bool HasPath(BTNode node, int sum, List<int> path)
        {
            if (node == null)
                return (sum == 0);
            else
            {
                bool res = false;
                int subSum = sum - node.data;
                if(subSum == 0 && node.left == null && node.right == null)
                {
                    path.ForEach(Console.WriteLine);
                    return true;
                }

                if(node.left != null)
                {
                    path.Add(node.left.data);
                    res = res || HasPath(node.left, subSum, path);
                    path.Remove(node.left.data);
                }

                if(node.right != null)
                {
                    path.Add(node.right.data);
                    res = res || HasPath(node.right, subSum, path);
                    path.Remove(node.right.data);
                }
                return res;
            }

        }

        private BTNode ConstructTreeforSum()
        {
            BTNode node;
            node = new BTNode(10);
            node.left = new BTNode(8);
            node.left.left = new BTNode(3);
            node.left.right = new BTNode(5);
            node.right = new BTNode(2);
            node.right.left = new BTNode(2);
            return node;
        }

        private BTNode ConstructTreeforIsSymmetic_1()
        {
            BTNode node;
            node = new BTNode(1);
            node.left = new BTNode(2);
            node.left.left = new BTNode(3);
            node.left.right = new BTNode(4);
            node.right = new BTNode(2);
            node.right.left = new BTNode(4);
            node.right.right = new BTNode(3);
            return node;
        }

        private BTNode ConstructTreeforBST()
        {
            // BST Image is here
            // https://www.programcreek.com/2014/04/leetcode-binary-search-tree-iterator-java/ 
            BTNode node;
            node = new BTNode(8); //Root

            // Level - 1
            node.left = new BTNode(3); 
            node.right = new BTNode(10);

            // Level - 2
            node.left.left = new BTNode(1);
            node.left.right = new BTNode(6);
            node.right.right = new BTNode(14);

            // Level - 3
            node.left.right.left = new BTNode(4);
            node.left.right.right = new BTNode(7);
            node.right.right.left = new BTNode(13);

            return node;
        }

        private void BinaryTreeIsSymmetric_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforIsSymmetic_1();
            var isSymetric = IsSymetric(node, node);
            Console.WriteLine(isSymetric);
        }

        private bool IsSymetric(BTNode node1, BTNode node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if(node1 != null && node2 != null && node1.data == node2.data)
            {
                return (IsSymetric(node1.left, node2.right) && IsSymetric(node1.right, node2.left));
            }
            return false;
        }

        private void FormBSTfromArray_Click(object sender, EventArgs e)
        {
            List<int> array = new List<int>() { 12, 18, 12, 1, 3, 20, 17, 19 };

            BTNode root = new BTNode();
            root.data = array[0];

            for (int i = 1; i < array.Count; i++)
            {
                BTNode p = new BTNode();
                p = root;
                BTNode q = new BTNode();
                q.data = array[i];
                bool isLoop = true;

                while (isLoop)
                {
                    if (q.data <= p.data)
                    {
                        if (p.left == null)
                        {
                            p.left = q;
                            isLoop = false;
                        }
                        else
                            p = p.left;
                    }
                    else
                    {
                        if (p.right == null)
                        {
                            p.right = q;
                            isLoop = false;
                        }
                        else
                            p = p.right;
                    }
                }
            }
            var a = root;
        }

        private void IsMirrorOfBinaryTree_Click(object sender, EventArgs e)
        {
            var res = IsMirror(ConstructTreeforIsMirror_R1(), ConstructTreeforIsMirror_R2());
            Console.WriteLine(res);
        }

        private bool IsMirror(BTNode r1, BTNode r2)
        {
            if (r1 == null && r2 == null)
                return true;

            if ((r1 == null && r2 != null) || (r1 != null && r2 == null))
                return false;

            if (r1.data == r2.data)
            {
                if (IsMirror(r1.left, r2.right) && IsMirror(r1.right, r2.left))
                    return true;
            }
            return false;
        }

        private BTNode ConstructTreeforIsMirror_R1()
        {
            BTNode node;
            node = new BTNode(10);
            node.left = new BTNode(8);
            node.left.left = new BTNode(3);
            node.left.right = new BTNode(5);

            node.right = new BTNode(2);
            node.right.left = new BTNode(2);
            return node;
        }

        private BTNode ConstructTreeforIsMirror_R2()
        {
            BTNode node;
            node = new BTNode(10);
            node.right = new BTNode(8);
            node.right.right = new BTNode(3);
            node.right.left = new BTNode(5);

            node.left = new BTNode(2);
            node.left.left = new BTNode(2);
            return node;
        }

        private void DistanceFromRootNode_Click(object sender, EventArgs e)
        {
            PrintNodeDistance(ConstructTreeforIsMirror_R1(), 4);
        }

        private void PrintNodeDistance(BTNode node, int distance)
        {
            if (node == null)
                return;

            if (distance == 0)
                Console.WriteLine(node.data);
            else
            {
                PrintNodeDistance(node.left, distance - 1);
                PrintNodeDistance(node.right, distance - 1);
            }
        }

        private void CheckTwoBinaryTreeAreIdenticial_Click(object sender, EventArgs e)
        {
            BTNode node1 = ConstructTreeforIsMirror_R1();
            BTNode node2 = ConstructTreeforIsMirror_R1();
            var res = CheckBinaryTreeIsIdentical(node1, node2);
            Console.WriteLine(res);
        }

        private bool CheckBinaryTreeIsIdentical(BTNode node1, BTNode node2)
        {
            if (node1 == null && node2 == null)
                return true;
            else if (node1.data == node2.data && (CheckBinaryTreeIsIdentical(node1.left, node2.left) 
                                                && CheckBinaryTreeIsIdentical(node1.right, node2.right)))
                return true;
            return false;
        }

        private void DiffBtwnLeftAndRightNode_Click(object sender, EventArgs e)
        {
            BTNode node1 = ConstructTreeforIsMirror_R1();
            Console.WriteLine(Math.Abs(Calc(node1)));
            int a = Calc(node1.left);
            int b = Calc(node1.right);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(Math.Abs(a - b));
        }

        private int Calc(BTNode node)
        {
            if (node == null)
                return 0;

            int res =  node.data + Calc(node.left) + Calc(node.right);
            return res;
        }

        private void CheckIfreeIsSumTree_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforisSumTree();
            var res = IsSumTree(node);
            Console.WriteLine(res);
        }

        private bool IsSumTree(BTNode node)
        {
            if (node == null)
                return true;
            if (node.left == null && node.right == null)
                return true;

            int left = Calc(node.left);
            int right = Calc(node.right);
            if(node.data == (left + right))
            {
                if (IsSumTree(node.left) && IsSumTree(node.right))
                    return true;
            }
            return false;
        }

        private BTNode ConstructTreeforisSumTree()
        {
            BTNode node;
            node = new BTNode(56);

            node.left = new BTNode(13);
            node.left.left = new BTNode(5);
            node.left.right = new BTNode(3);
            node.left.left.left = new BTNode(3);
            node.left.left.right = new BTNode(2);

            node.right = new BTNode(15);
            node.right.left = new BTNode(9);
            node.right.right = new BTNode(3);
            node.right.right.left = new BTNode(2);
            node.right.right.right = new BTNode(1);
            //node.right.right.right.right = new BTNode(1);
            return node;
        }

        private void PrintLeafNodes_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforIsMirror_R1();
            PrintLeafNode(node);
        }

        private void PrintLeafNode(BTNode node)
        {
            if (node.left != null && node.right != null)
            {
                PrintLeafNode(node.left);
                PrintLeafNode(node.right);
            }
              else
               Console.WriteLine(node.data);
        }

        private void PrintRootToLeafPaths_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforIsMirror_R1();
            Stack<int> stack = new Stack<int>();
            PrintRootToLeaf(node, stack);
        }

        private void PrintRootToLeaf(BTNode node, Stack<int> stack)
        {
            if (node == null)
                return;

            stack.Push(node.data);
            PrintRootToLeaf(node.left, stack);
            if(node.left == null && node.right == null)
                PrintStack(stack);
            PrintRootToLeaf(node.right, stack);
            stack.Pop();
        }

        private void PrintStack(Stack<int> stack)
        {
            var stack1 = stack.Reverse();
            if(stack1.Count() > 0)
            {
                foreach(var s in stack1)
                {
                    Console.Write(string.Format("{0} -> ", s));
                }
            }
            Console.WriteLine();
        }

        private void DeleteAGivenBinaryTree_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforIsMirror_R1();
            DeleteBinaryTree(ref node);
            var aa = node;
        }

        private void DeleteBinaryTree(ref BTNode node)
        {
            if (node == null)
                return;

            DeleteBinaryTree(ref node.left);
            DeleteBinaryTree(ref node.right);
            node = null;
        }

        private void PrintNodesLevelByLevel_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforisSumTree();
            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(node);
            queue.Enqueue(null);
            var isPreviousNodeNull = false;
            while (queue.Count > 0)
            {
                var p = queue.Dequeue();
                if (p == null)
                {
                    if(!isPreviousNodeNull)
                        queue.Enqueue(null);
                    Console.WriteLine(" /n ");
                    isPreviousNodeNull = true;
                }
                else
                {
                    isPreviousNodeNull = false;
                    Console.WriteLine(p.data);
                    if(p.left != null)
                        queue.Enqueue(p.left);

                    if(p.right != null)
                        queue.Enqueue(p.right);
                }
            }
        }

        private void DiagonalPrint_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforisSumTree();
            PrintDiagonalBT(node);
        }

        private void PrintDiagonalBT(BTNode node)
        {
            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(node);
            queue.Enqueue(null);
            while (queue.Count > 0)
            {
                var p = queue.Dequeue();
                if (p == null)
                {
                    Console.WriteLine("");
                    if (queue.Count > 0)
                    {
                        queue.Enqueue(null);
                        p = queue.Dequeue();
                    }
                }

                while (p != null)
                {
                    Console.Write(p.data + "  ");
                    if (p.left != null)
                        queue.Enqueue(p.left);
                    p = p.right;
                }
            }
        }

        private void LowestCommonAncestor_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforisSumTree();
            var res = LCA(node, new BTNode(5), new BTNode(9));
            Console.WriteLine(res.data);
        }

        private BTNode LCA(BTNode root, BTNode p1, BTNode p2)
        {
            if (root == null)
                return root;

            if (root.data == p1.data || root.data == p2.data)
                return root;

            var left = LCA(root.left, p1, p2);
            var right = LCA(root.right, p1, p2);

            if (left != null && right != null)
                return root;
            else
                return left != null ? left : right;
        }

        private bool IsIdentical(BTNode node1, BTNode node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1.data == node2.data)
                return IsIdentical(node1.left, node2.left) && IsIdentical(node1.right, node2.right);

            return false;
        }


        private bool IsSubNodeExists(BTNode node, BTNode subNode)
        {
            while (node != null)
            {
                var res = IsIdentical(node, subNode);
                if (res) return true;
                else
                {
                    return IsSubNodeExists(node.left, subNode) && IsSubNodeExists(node.right, subNode);
                }
            }

            return false;
        }

        private BTNode ConstructTreeforRightView()
        {
            BTNode node;
            node = new BTNode(1);

            node.left = new BTNode(2);
            node.left.left = new BTNode(4);
            node.left.right = new BTNode(5);
            node.left.left.left = new BTNode(7);
            node.left.left.left.right = new BTNode(9);
            node.left.left.left.right.right = new BTNode(10);


            node.right = new BTNode(3);
            node.right.right = new BTNode(6);
            node.right.right.left = new BTNode(8);

            return node;
        }

        private void RightViewOfBinaryTree_Click(object sender, EventArgs e)
        {
            BTNode node = ConstructTreeforRightView();
            Console.WriteLine("Printing RightView of Binary Tree:");
            RightViewOfBT(node);
        }

        private void RightViewOfBT(BTNode node)
        {
            Queue<BTNode> q = new Queue<BTNode>();
            q.Enqueue(node);
            q.Enqueue(null);

            var prev = -1;
            while (q.Count > 0)
            {
                var curr = q.Dequeue();

                if (curr == null)
                {
                    Console.WriteLine(prev);
                    if (q.Count > 0)
                        q.Enqueue(null);
                }
                else
                {
                    prev = curr.data;
                    if (curr.left != null)
                        q.Enqueue(curr.left);

                    if (curr.right != null)
                        q.Enqueue(curr.right);
                }
            }
        }

        private void BinaryTreeIterator_Click(object sender, EventArgs e)
        {
            var node = ConstructBinarySearchTree();
            var hash = BinaryTreeIteratorForNext(node, new Dictionary<int, int>(), 0, new List<int>());
            BTNode nodeNext = new BTNode(85);
            var res = GetNext(nodeNext, hash);
            Console.WriteLine(res);
        }

        private BTNode ConstructBinarySearchTree()
        {
            BTNode node;
            node = new BTNode(100);

            node.left = new BTNode(80);
            node.left.left = new BTNode(70);
            node.left.right = new BTNode(85);

            node.left.left.left = new BTNode(60);
            node.left.left.right = new BTNode(75);
            node.left.right.left = new BTNode(83);
            node.left.right.right = new BTNode(90);

            node.right = new BTNode(125);
            node.right.left = new BTNode(110);
            node.right.right = new BTNode(150);

            node.right.left.left = new BTNode(105);
            node.right.left.right = new BTNode(115);
            node.right.right.left = new BTNode(140);
            node.right.right.right = new BTNode(160);

            return node;
        }

        private Dictionary<int, int> BinaryTreeIteratorForNext(BTNode node, Dictionary<int, int> hash, int counter, List<int> arr)
        {
            if (node != null)
            {
                BinaryTreeIteratorForNext(node.left, hash, counter, arr);
                
                arr.Add(node.data);
                if (counter > 0)
                {
                    hash.Add(arr[counter - 1], arr[counter]);
                }
                counter++;

                //if(!hash.ContainsKey(arr[counter-1]))
                //    hash.Add(arr[counter - 1], node.data);


                BinaryTreeIteratorForNext(node.right, hash, counter + 1, arr);            }
            return hash;
        }

        private int GetNext(BTNode node, Dictionary<int, int> hash)
        {
            if (node != null && node.data > 0)
            {
                int val = node.data;
                return hash[val];
            }
            return -1;
        }

        private void AVLTreeRotations_Click(object sender, EventArgs e)
        {
            AVLTree tree = new AVLTree();

            tree.root = tree.Insert(tree.root, 10);
            tree.root = tree.Insert(tree.root, 20);
            tree.root = tree.Insert(tree.root, 30);
            tree.root = tree.Insert(tree.root, 40);
            tree.root = tree.Insert(tree.root, 50);
            tree.root = tree.Insert(tree.root, 25);
            tree.root = tree.Insert(tree.root, 60);
            tree.root = tree.Insert(tree.root, 70);

            var res = tree;
        }

        private void IsBinaryTreeIdentical_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforIsSymmetic_1();
            Console.WriteLine(IsBinaryTreeIdenticalFn(node, node));
        }

        private bool IsBinaryTreeIdenticalFn(BTNode node1, BTNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            else if (node1 != null && node2 != null && node1.data == node2.data)
                return (IsBinaryTreeIdenticalFn(node1.left, node2.left) &&
                  IsBinaryTreeIdenticalFn(node1.right, node2.right));
            else
                return false;
        }

        private void BinaryTreeIterator_InOrder_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST();
            BinaryTreeIteratorInOrder btIterator = new BinaryTreeIteratorInOrder(node);
            while (btIterator.HasNext())
            {
                Console.WriteLine(btIterator.GetNext().data);
            }
        }

        private void IterativeInOrderTraversal_Click(object sender, EventArgs e)
        {
            // https://java2blog.com/binary-tree-inorder-traversal-in-java/
            var node = ConstructTreeforBST();
            Stack<BTNode> stack = new Stack<BTNode>();
            while(node != null || stack.Count > 0)
            {
                if(node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    var curr = stack.Pop();
                    Console.WriteLine(curr.data);
                    node = curr.right;
                }
            }
        }

        private void InOrderSuccessorInBST_Click(object sender, EventArgs e)
        {
            // https://www.youtube.com/watch?v=JdmAYw5h3G8
            var node = ConstructTreeforBST();
            var res = InOrderSuccessor(node, 14);
        }

        private BTNode InOrderSuccessor(BTNode root, int x)
        {
            var node = root;
            BTNode store = null;
            // Case2: After finding, if the node doesn't have right subtree, the node from where we take the last left is answer
            while(node !=null && node.data != x)
            {
                if(x <= node.data)
                {
                    store = node;
                    node = node.left;
                }
                else
                {
                    node = node.right;
                }
            }

            // Case1: Find the node, If node has right subtree, then find the least value (left most) from that right subtree
            if(node != null && node.data == x && node.right != null)
            {
                BTNode temp = node.right;
                while(temp.left != null)
                {
                    temp = temp.left;
                }
                return temp;
            }
            return store;
        }

        private void LevelOrderTraversal_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST();
            PrintLevelOrderTraversal(node);
        }

        private void PrintLevelOrderTraversal(BTNode node)
        {
            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(node);
            queue.Enqueue(null);
            //Console.Write(node.data);

            while(queue != null && queue.Count > 0)
            {
                var temp = queue.Dequeue();
                if (temp == null)
                {
                    if(queue.Count > 0)
                    {
                        Console.WriteLine();
                        queue.Enqueue(null);
                    }
                }
                else
                    Console.Write(temp.data + "\t");

                if (temp != null && temp.left != null)
                    queue.Enqueue(temp.left);

                if (temp != null && temp.right != null)
                    queue.Enqueue(temp.right);
            }
        }

        private void IsGivenNodeIsBinaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST();
            Console.WriteLine(IsBinaryTree(node, int.MinValue, int.MaxValue));
        }

        private bool IsBinaryTree(BTNode node, int min, int max)
        {
            if (node == null)
                return true;

            if (node.data < min || node.data > max)
                return false;

            return IsBinaryTree(node.left, min, node.data)
                && IsBinaryTree(node.right, node.data, max);

        }

        private void BinaryTreeToDLL_Click(object sender, EventArgs e)
        {
            BinaryTreeDLL tree = new BinaryTreeDLL();
            var node = tree.CreateTree();
            tree.BTtoDLL(node);
            tree.PrintList(tree.head);
        }

        private void HeightOfBinaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST();
            Console.WriteLine("Height of Binary Tree is " + GetHeightOfBinaryTree(node));
        }

        private int GetHeightOfBinaryTree(BTNode node)
        {
            if (node == null)
                return 0;

            int left = GetHeightOfBinaryTree(node.left);
            int right = GetHeightOfBinaryTree(node.right);

            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }

        }

        private void DiameterOfBinaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST();
            Console.WriteLine("Diameter of Binary Tree is " + GetDiameterOfBinaryTree(node));
        }

        private int GetDiameterOfBinaryTree(BTNode node)
        {
            if (node == null)
                return 0;
            int leftHeight = GetHeightOfBinaryTree(node.left);
            int rightHeight = GetHeightOfBinaryTree(node.right);

            int leftDiameter = GetDiameterOfBinaryTree(node.left);
            int rightDiameter = GetDiameterOfBinaryTree(node.right);

            return Math.Max(leftHeight + rightHeight + 1, Math.Max(leftDiameter, rightDiameter));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var node = ConstructBTNodeWithSiblingData_1();
            var updated = ConnectSibilings(node);
        }

        private BTNodeWithSibling ConstructBTNodeWithSiblingData_1()
        {
            BTNodeWithSibling node;
            node = new BTNodeWithSibling(1);

            node.left = new BTNodeWithSibling(2);
            node.right = new BTNodeWithSibling(3);

            node.left.left = new BTNodeWithSibling(4);
            node.left.right = new BTNodeWithSibling(5);
            node.right.left = new BTNodeWithSibling(6);
            node.right.right = new BTNodeWithSibling(7);


            //node.left.left = new BTNode(3);
            //node.left.right = new BTNode(4);
            //node.right = new BTNode(2);
            //node.right.left = new BTNode(4);
            //node.right.right = new BTNode(3);
            return node;
        }

        private BTNodeWithSibling ConnectSibilings(BTNodeWithSibling node)
        {
            if (node == null)
                return null;

            Queue<BTNodeWithSibling> queue = new Queue<BTNodeWithSibling>();
            queue.Enqueue(node);
            queue.Enqueue(null);

            while(queue.Count > 0)
            {
                var curr = queue.Dequeue();

                if (curr != null && curr.left != null)
                    curr.left.next = GetNextSibiling(curr, true);
                if (curr != null && curr.right != null)
                    curr.right.next = GetNextSibiling(curr, false);

                if (curr == null && queue.Count > 0)
                    queue.Enqueue(curr);

                if (curr != null && curr.left != null)
                    queue.Enqueue(curr.left);
                if (curr != null && curr.right != null)
                    queue.Enqueue(curr.right);
            }
            return node;
        }

        private BTNodeWithSibling GetNextSibiling(BTNodeWithSibling curr, bool isLeft)
        {
            if (curr == null)
                return curr;
            if (isLeft)
            {
                if (curr.right != null)
                {
                    return curr.right;
                }
                else if (curr.next != null && curr.next.left != null)
                {
                    return curr.next.left;
                }
                else if (curr.next != null && curr.next.right != null)
                {
                    return curr.next.right;
                }
            }
            else
            {
                if (curr.next != null && curr.next.left != null)
                    return curr.next.left;
                else if (curr.next != null && curr.next.right != null)
                    return curr.next.right;
            }

            return null;
        }

        private void Serialize_Deserialize_BinaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeToSerialize();
            var str = SerializeBinaryTree(node);
            DeSerializeStringToBinaryTree(str.Split(','));
        }

        private BTNode ConstructTreeToSerialize()
        {
            BTNode node;
            node = new BTNode(45);

            node.left = new BTNode(25);
            node.left.left = new BTNode(15);
            node.left.right = new BTNode(35);

            node.right = new BTNode(75);
            node.right.right = new BTNode(88);
            return node;
        }

        private string SerializeBinaryTree(BTNode node)
        {
            if (node == null)
                return "null,";

            StringBuilder sb = new StringBuilder();
            sb.Append(node.data);
            sb.Append(",");
            sb.Append(SerializeBinaryTree(node.left));
            sb.Append(SerializeBinaryTree(node.right));

            return sb.ToString();
        }

        private void DeSerializeStringToBinaryTree(string[] arr)
        {
            BTNode node = new BTNode();
            var z = node;
            Queue<string> queue = new Queue<string>();
            for(int i = 0; i<arr.Length-1; i++)
            {
                queue.Enqueue(arr[i]);
            }
            Helper(node, queue);
        }

        private void Helper(BTNode node,Queue<string> queue)
        {
            if (queue.Count <= 0)
                return;
            var curr = queue.Dequeue();
            node = curr == "null" ? null : new BTNode(Convert.ToInt32(curr));
            if (node == null)
                return;

            Helper(node.left, queue);
            Helper(node.right, queue);
        }

        private void PreOrderTraversal(BTNode node)
        {
            if (node == null)
                return;
            Console.Write(node.data + "\t");
            PreOrderTraversal(node.left);
            PreOrderTraversal(node.right);
        }

        private void FindKthLargestNode_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforBST();
            printTreeInOrder(node);
            var res = KthLargestNode(node, 2);
            Console.WriteLine("2 - Largest Node is" + res.data);
        }

        public static int counter = 0;
        private BTNode KthLargestNode(BTNode node, int k)
        {
            if (node == null)
                return null;
            var temp = KthLargestNode(node.right, k);
            if (k != counter)
            {
                counter++;
                temp = node;
            }

            if (k == counter)
            {
                return temp;
            }
            else
            {
                return KthLargestNode(node.left, k);
            }
        }

        private void printTreeInOrder(BTNode rootNode)
        {
            if (rootNode == null)
                return;
            printTreeInOrder(rootNode.left);
            Console.WriteLine(rootNode.data);
            printTreeInOrder(rootNode.right);
        }

        private void MirrorBinaryTree_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforMirror();
            var res = MirrorBinaryTreeFn2(node);
        }

        private BTNode MirrorBinaryTreeFn2(BTNode node)
        {
            if (node == null)
                return null;

            MirrorBinaryTreeFn2(node.left);
            MirrorBinaryTreeFn2(node.right);
            var temp = node.left;
            node.left = node.right;
            node.right = temp;
            return node;
        }

        private BTNode ConstructTreeforMirror()
        {
            
            BTNode node;
            node = new BTNode(8); //Root

            // Level - 1
            node.left = new BTNode(3);
            node.right = new BTNode(10);

            //// Level - 2
            node.left.left = new BTNode(2);
            node.left.right = new BTNode(6);
            node.right.right = new BTNode(14);

            //// Level - 3
            //node.left.right.left = new BTNode(4);
            //node.left.right.right = new BTNode(7);
            //node.right.right.left = new BTNode(13);

            return node;
        }

        private void SumOfSubNodeEqualToK_Click(object sender, EventArgs e)
        {
            var node = ConstructTreeforMirror();
            var res = SumOfSubNodes(node, 11);
        }

        private BTNodePair SumOfSubNodes(BTNode node, int target)
        {
            // https://java2blog.com/count-subtree-sum-equal-target-binary-tree/
            if (node == null)
                return new BTNodePair(0, 0);

            var left = SumOfSubNodes(node.left, target);
            var right = SumOfSubNodes(node.right, target);

            int sum = left.sum + right.sum + node.data;
            int count = left.count + right.count;
            if(sum == target)
            {
                count++;
            }

            return new BTNodePair(sum, count);
        }
    }

    public class BTNodePair
    {
        public int count;
        public int sum;

        public BTNodePair(int sum, int count)
        {
            this.count = count;
            this.sum = sum;
        }
    }

    public class BinaryTreeIteratorInOrder
    {
        // Iterator Solution from here
        // https://www.hackingnote.com/en/interview/problems/binary-search-tree-iterator
        Stack<BTNode> stack = new Stack<BTNode>();
        public BinaryTreeIteratorInOrder(BTNode root)
        {
            Push(root);
        }

        private void Push(BTNode node)
        {
            while(node != null)
            {
                stack.Push(node);
                node = node.left;
            }
        }

        public BTNode GetNext()
        {
            var current = stack.Pop();
            Push(current.right);
            return current;
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }
    }


    public class BinaryTreeDLL
    {
        // public BTNode node;
        public BTNode head;

        public void BTtoDLL(BTNode node)
        {
            if (node == null)
                return;

            BTtoDLL(node.right);

            node.right = head;

            if (head != null)
                head.left = node;

            head = node;

            BTtoDLL(node.left);
        }
        public virtual void PrintList(BTNode head)
        {
            Console.WriteLine("Extracted Double " +
                              "Linked List is : ");
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.right;
            }
        }

        public BTNode CreateTree()
        {
            /* Constructing below tree  
                    5  
                   / \  
                  3   6  
                 / \   \  
                1   4   8  
               / \     / \  
              0   2   7   9          */

            BTNode root = new BTNode(5);
            root.left = new BTNode(3);
            root.right = new BTNode(6);
            root.left.right = new BTNode(4);
            root.left.left = new BTNode(1);
            root.right.right = new BTNode(8);
            root.left.left.right = new BTNode(2);
            root.left.left.left = new BTNode(0);
            root.right.right.left = new BTNode(7);
            root.right.right.right = new BTNode(9);

            return root;
        }

    }

    public class BTNodeWithSibling
    {
        public int data;
        public BTNodeWithSibling left, right, next;
        public BTNodeWithSibling(int val)
        {
            this.data = val;
            left = null;
            right = null;
            next = null;
        }
    }
}
