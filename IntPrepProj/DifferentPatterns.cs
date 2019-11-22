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
    public partial class DifferentPatterns : Form
    {
        public DifferentPatterns()
        {
            InitializeComponent();
        }

        private void SquaresOfSortedArray_Click(object sender, EventArgs e)
        {
            var input = new int[] { -4, -1, 0, 3, 10 };
            PrintArray(input);
            var res = Sortedsquares(input);
            Console.Write("Sum of Sorted Squares are ");
            PrintArray(res);
        }

        private void PrintArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + "  ");
            }
        }

        private int[] Sortedsquares(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int neg = 0, pos = 0;
            while (neg < arr.Length && arr[neg] < 0)
                neg++;
            pos = neg;
            neg--;
            int count = 0;

            while(neg >= 0 && pos < arr.Length) 
            {
                if(arr[neg] * arr[neg] < arr[pos] * arr[pos])
                {
                    newArr[count++] = arr[neg] * arr[neg];
                    neg--;
                }
                else
                {
                    newArr[count++] = arr[pos] * arr[pos];
                    pos++;
                }
            }

            while(neg >= 0)
            {
                newArr[count++] = arr[neg] * arr[neg];
                neg--;
            }

            while (pos < arr.Length)
            {
                newArr[count++] = arr[pos] * arr[pos];
                pos++;
            }

            return newArr;
        }

        private void SumOfTripletsToZero_Click(object sender, EventArgs e)
        {
            var input = new int[] { -1, 0, 1, 2, -1, -4 };
            Console.Write("Input Array --     ");
            PrintArray(input);
            var res = SumOfTripletsToZero_V1(new int[] { -1, 0, 1, 2, -1, -4 });
            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("Sum of Triplets are....");
            int count = 1;
            foreach (var x in res)
            {
                Console.WriteLine("The results Count - " + count++);
                PrintArray(x.ToArray());
                Console.WriteLine("");
            }
        }

        private IList<IList<int>> SumOfTripletsToZero_V1(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return null;

            Array.Sort(arr);
            IList<IList<int>> retList = new List<IList<int>>();

            for(int i = 0; i< arr.Length-1; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                {              // skip same result
                    continue;
                }
                int left = i + 1;
                int right = arr.Length - 1;
                int curr = arr[i];
                while(left < right)
                {
                    List<int> list = new List<int>();
                    if(arr[left] + arr[right] + curr == 0)
                    {
                        list.Add(curr);
                        list.Add(arr[left]);
                        list.Add(arr[right]);
                        retList.Add(list);

                        while (left < right && arr[left] == arr[left + 1])
                        { left++; } // skip same result
                        while (left < right && arr[right] == arr[right - 1])
                        { right--; } // skip same result

                        left++;
                        right--;
                    }
                    else if(arr[left] + arr[right] + curr < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return retList;
        }

        private void BackSpaceStringCompare_Click(object sender, EventArgs e)
        {
            var res = BackspaceStringCompare("xywrrmp", "xywrrmu#p");
        }

        private bool BackspaceStringCompare(string s, string t)
        {
            if (s == null || t == null)
                return false;

            int i = s.Length - 1;
            int j = t.Length - 1;
            int iSum = 0;
            int jSum = 0;

            while (i >= 0 || j >= 0)
            {
                while (i >= 0 && (s[i] == '#' || iSum > 0))
                {
                    if (s[i] == '#') { --i; ++iSum; }
                    else if (iSum > 0) { --i; --iSum; }
                }

                while (j >= 0 && (t[j] == '#' || jSum > 0))
                {
                    if (t[j] == '#') { --j; ++jSum; }
                    else if (jSum > 0) { --j; --jSum; }
                }

                if (i >= 0 && j >= 0 && s[i] != t[j])
                    return false;

                if ((i >= 0) != (j >= 0))
                    return false;
                i--; j--;
            }


            return true;
        }

        private void IntervalsIntersection_Click(object sender, EventArgs e)
        {
            Interval[] arr1 = new Interval[]
            {
                new Interval() { start = 0, end = 2},
                new Interval() { start = 5, end = 10},
                new Interval() { start = 13, end = 23},
                new Interval() { start = 24, end = 25},
            };

            Interval[] arr2 = new Interval[]
            {
                new Interval() { start = 1, end = 5},
                new Interval() { start = 8, end = 12},
                new Interval() { start = 15, end = 24},
                new Interval() { start = 25, end = 26},
            };

            var res = IntervalIntersection(arr1, arr2);
            var x = res;
        }

        public Interval[] IntervalIntersection(Interval[] A, Interval[] B)
        {
            var intersection = new List<Interval>();

            var lengthA = A.Length;
            var lengthB = B.Length;

            int indexA = 0;
            int indexB = 0;
            while (indexA < lengthA && indexB < lengthB)
            {
                // overlap
                var currentA = A[indexA];
                var currentB = B[indexB];

                var maxStart = Math.Max(currentA.start, currentB.start);
                var minEnd = Math.Min(currentA.end, currentB.end);

                var overlap = maxStart <= minEnd;
                if (overlap)
                {
                    var newOne = new Interval(maxStart, minEnd);

                    intersection.Add(newOne);

                    if (currentA.end <= currentB.end)
                        indexA++;
                    else
                        indexB++;
                }
                else
                {
                    // go to next iteration
                    if (currentA.start < currentB.start)
                    {
                        indexA++;
                    }
                    else
                    {
                        indexB++;
                    }
                }
            }

            return intersection.ToArray();
        }

        private void FirstMissingPositive_Method1_Click(object sender, EventArgs e)
        {
            FirstMissingPositive_Method2(new int[] { 3, 4, -1, 1 });
        }

        private int FirstMissingPositiveNumber_Method1(int[] nums)
        {
            if (nums == null || nums.Length <= 0)
                return 1;

            int[] tempArr = new int[10000];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] <= nums.Length)
                    tempArr[nums[i]] = 1;
            }

            for (int i = 1; i < tempArr.Length; i++)
            {
                if (tempArr[i] == 0)
                    return i;
            }

            return nums.Length + 1;
        }

        // Below is using Cyclic Sort Approach
        public int FirstMissingPositive_Method2(int[] nums)
        {
            int i = 0, n = nums.Length;
            while (i < n)
            {
                // If the current value is in the range of (0,length) and it's not at its correct position, 
                // swap it to its correct position.
                // Else just continue;
                if (nums[i] >= 0 && nums[i] < n && nums[nums[i]] != nums[i])
                    swap(nums, i, nums[i]);
                else
                    i++;
            }

            int k = 1;

            // Check from k=1 to see whether each index and value can be corresponding.
            while (k < n && nums[k] == k)
                k++;

            // If it breaks because of empty array or reaching the end. K must be the first missing number.
            if (n == 0 || k < n)
                return k;
            else   // If k is hiding at position 0, K+1 is the number. 
                return nums[0] == k ? k + 1 : k;

        }
        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private void ReverseGroupInLinkedList_Click(object sender, EventArgs e)
        {
            Node node = new Node();
            node.data = 1;
            node.next = new Node();
            node.next.data = 2;
            node.next.next = new Node();
            node.next.next.data = 3;
            node.next.next.next = new Node();
            node.next.next.next.data = 4;
            node.next.next.next.next = new Node();
            node.next.next.next.next.data = 5;
            node.next.next.next.next.next = new Node();
            node.next.next.next.next.next.data = 6;
            node.next.next.next.next.next.next = null;

            PrintLinkedList(node);
            var res = ReverseInBetween(node, 3, 5);
            Console.WriteLine("The output is ");
            PrintLinkedList(res);

        }

        public Node ReverseInBetween(Node head, int m, int n)
        {
            if (m < 1 || m >= n)
                return null;

            if (head == null || head.next == null)
                return head;

            Node dummy = new Node(-1);
            dummy.next = head;

            Node prev1 = null;
            Node curr1 = dummy;

            for (int i = 0; i < m; i++)
            {
                prev1 = curr1;
                curr1 = curr1.next;
            }

            Node prev2 = prev1;
            Node curr2 = curr1;
            Node next = null;

            for (int i = m; i <= n; i++)
            {
                next = curr2.next;
                curr2.next = prev2;

                prev2 = curr2;
                curr2 = next;
            }

            prev1.next = prev2;
            curr1.next = curr2;

            return dummy.next;
        }

        private void PrintLinkedList(Node head)
        {
            while(head != null)
            {
                Console.Write(head.data + " --> ");
                head = head.next;
            }
            Console.Write("null");
            Console.WriteLine("");
        }
    }
}
