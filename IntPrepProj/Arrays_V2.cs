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
    public partial class Arrays_V2 : Form
    {
        public Arrays_V2()
        {
            InitializeComponent();
        }

        private void ProductOfArrayExceptSelf_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[] { 1, 2, 3, 4 };
            //var res = ProductOfArrayWithoutSelf_WithDivision(arr);
            //var x = res;

            int[] arr = new int[] { 2, 3, 4, 5 };
            var res2 = ProductOfArrayWithoutSelf_WithoutDivision(arr);
            var y = res2;
        }

        private int[] ProductOfArrayWithoutSelf_WithDivision(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return arr;

            int sum = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum *= arr[i];
            }

            int[] result = new int[arr.Length];
            for(int i = 0;i<arr.Length;i++)
            {
                result[i] = sum / arr[i];
            }

            return result;
        }

        //https://leetcode.com/problems/product-of-array-except-self/discuss/65622/Simple-Java-solution-in-O(n)-without-extra-space
        private int[] ProductOfArrayWithoutSelf_WithoutDivision(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return arr;

            int[] result = new int[arr.Length];

            int left = 1; // For the array travel from left to right
            for (int i = 0; i< arr.Length; i++)
            {
                result[i] = left; // add left value to result array
                left *= arr[i]; // calculate left value
            }

            int right = 1; // For the array travel from right to left
            for (int i = arr.Length - 1; i>= 0; i--)
            {
                result[i] *= right; // add right value to result array
                right *= arr[i]; // calculate right value
            }

            return result;
        }

        private void KthLargestElementInArray_QuickSelect_Click(object sender, EventArgs e)
        {
            /*
             The algorithm is similar to QuickSort. The difference is, instead of recurring for both sides (after finding pivot), it recurs only for the part that contains the k-th smallest element. 
             The logic is simple, if index of partitioned element is more than k, then we recur for left part. If index is same as k, we have found the k-th smallest element and we return.
             If index is less than k, then we recur for right part. This reduces the expected complexity from O(n log n) to O(n), with a worst case of O(n^2).
             */
            int[] arr = new int[] { 3, 2, 1, 5, 6, 4 };
            var res = QuickSelect(arr, 2);

            int[] arr2 = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            var res2 = QuickSelect(arr2, 4);

            var x = res2;
        }

        private int QuickSelect(int[] arr, int k)
        {
            int low = 0;
            int high = arr.Length - 1;
            k = arr.Length - k;
            while(low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                if(partitionIndex == k)
                {
                    break;
                }
                else if(partitionIndex < k)
                {
                    low = partitionIndex + 1;
                }
                else
                {
                    high = partitionIndex - 1;
                }
            }

            return arr[k];
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int partitionIndex = low;

            for(int i = low; i<high;i++)
            {
                if(arr[i] <= pivot)
                {
                    int temp1 = arr[i];
                    arr[i] = arr[partitionIndex];
                    arr[partitionIndex] = temp1;
                    partitionIndex++;
                }
            }

            int temp = arr[high];
            arr[high] = arr[partitionIndex];
            arr[partitionIndex] = temp;

            return partitionIndex;
        }

        private void SmallestMissingPositiveInt_Click(object sender, EventArgs e)
        {
            var x = FindSmallestMissingPositiveInt(new int[] { 1, - 1, - 5, - 3, 3, 4, 2, 8 });
            var y = x;
        }

        private int FindSmallestMissingPositiveInt(int[] arr)
        {
            // Move -ve to last
            var end = MoveNegativeNumbersToLast(arr);
            return MarkAvailableNumbersToNegative(arr, end);
        }

        private int MarkAvailableNumbersToNegative(int[] arr, int end)
        {
            // 3 4 1
            // 3 4 -1
            // 3 4 -1
            // -3 4 -1
            for(int i = 0; i<= end; i++)
            {
                int val = Math.Abs(arr[i]) - 1;
                if(val <= end & val >= 0)
                {
                    if(arr[val] > 0)
                    {
                        arr[val] = -arr[val];
                    }
                }
            }

            for(int i = 0; i<= end; i++)
            {
                if (arr[i] > 0)
                    return i + 1;
            }
            return end + 1;
        }

        private int MoveNegativeNumbersToLast(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left < right)
            {
                if(arr[left] < 0 && arr[right] > 0)
                {
                    var temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
                else if(arr[left] > 0)
                {
                    left++;
                }
                else if(arr[right] < 0)
                {
                    right--;
                }
            }
            return left;
        }
    }
}
