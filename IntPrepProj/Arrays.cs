using System;
using System.Collections;
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
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }

        private int[] ReverseArray(int[] input)
        {
            for(int i=0; i< input.Length/2; i++)
            {
                var temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
            return input;
        }

        private int[] ReverseArrayWithIndex(int[] input, int startingIndex, int length)
        {
            for (int i = startingIndex; i < length; i++)
            {
                var temp = input[i];
                input[i] = input[startingIndex + length - 1];
                input[startingIndex + length - 1] = temp;
                length--;
            }
            return input;
        }

        private void Rotate_Array_By_Pivot_Click(object sender, EventArgs e)
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int pivot = 2;
            input = ReverseArrayWithIndex(input, 0, input.Length);
            input = ReverseArrayWithIndex(input, 0, 2);
            var ab = ReverseArrayWithIndex(input, 2, 3);
        }

        private void Find_Missing_Number_Click(object sender, EventArgs e)
        {
            //Using XOR
            int[] input = { 11, 12, 13,14, 15, 16,17,19 };
            var aa = MissingNumber(input);
            Console.Write(aa);
        }

        public int MissingNumber(int[] input)
        {
            int i;
            int x1 = input[0];
            int x2 = 1;

            for(i = 1; i < input.Length; i++)
            {
                x1 = x1 ^ input[i];
            }

            for(i=2; i<= input.Length + 1; i++)
            {
                x2 = x2 ^ i;
            }
            var res = x1 ^ x2;
            return res;
        }

        private void Find_SubArray_With_Sum_Zero_Click(object sender, EventArgs e)
        {
            var aa = SubArrayWithSumZero(new int[] { 4, 2, -3, 1, 6 });
            //var aa = SubArrayWithSumZero(new int[] { -3, 2, 3, 1, 6 });
            Console.WriteLine(aa);
        }

        private bool SubArrayWithSumZero(int[] input)
        {
            Hashtable ht = new Hashtable();
            int sum = 0;
            for(int i=0; i<input.Length; i++)
            {
                sum += input[i];

                if(sum == 0 || input[i] == 0 | ht[sum] != null)
                {
                    return true;
                }

                ht.Add(sum, i);
            }
            return false;
        }

        private void SumOfTripletsToZero_Click(object sender, EventArgs e)
        {
           var aa = Sum_TripletsTo_Zero(new int[] { 0, -1, 2, -3, 1 });
            var bb = aa;
        }

        private Dictionary<string, string> Sum_TripletsTo_Zero(int[] numbers)
        {
            Dictionary<string, string> res = new Dictionary<string, string>();

            //Sort the numbers array
            Array.Sort(numbers);

            if(numbers[0] > 0)
            {
                return res;
            }

            for(int i=0; i<numbers.Length -1; i++)
            {
                for(int j=i+1; j<numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    int numToFind = -1 * sum;
                    int index = Array.BinarySearch(numbers, numToFind);

                    if(index > -1 && index != i && index != j)
                    {
                        string sortedNumbers = SortThreeNumbers(numbers[i], numbers[j], numbers[index]);
                        if (!res.ContainsKey(sortedNumbers))
                        {
                            res.Add(sortedNumbers, string.Format("{0} {1} {2}", numbers[i], numbers[j], numbers[index]));
                            Console.WriteLine(string.Format("Sum of Triplet to zero is - {0} {1} {2}", numbers[i], numbers[j], numbers[index]));
                        }
                    }
                }
            }
            return res;
        }

        private string SortThreeNumbers(int a, int b, int c)
        {
            StringBuilder res = new StringBuilder();
            int max = -1;
            if(a > b)
            {
                if(a > c)
                {
                    res.Append(a);
                    max = a;
                }
                else
                {
                    res.Append(c);
                    max = c;
                }
            }
            else if(b > c)
            {
                res.Append(b);
                max = b;
            }
            else
            {
                res.Append(c);
                max = c;
            }
            if(max == a)
            {
                if(b > c)
                {
                    res.Append(b);
                    res.Append(c);
                }
                else
                {
                    res.Append(c);
                    res.Append(b);
                }
            }
            else if(max == b)
            {
                if (a > c)
                {
                    res.Append(a);
                    res.Append(c);
                }
                else
                {
                    res.Append(c);
                    res.Append(a);
                }
            }
            else if (max == c)
            {
                if (a > b)
                {
                    res.Append(a);
                    res.Append(b);
                }
                else
                {
                    res.Append(b);
                    res.Append(a);
                }
            }
            return res.ToString();
        }

        private void ZigZagArray_Click(object sender, EventArgs e)
        {
            var res = PrintArrayInZigZag(new int[] { 3,4,6,7,2,1,8,9 });
            Console.WriteLine(string.Format("Input Array: {0}", string.Join(" ", new int[] { 3, 4, 6, 7, 2, 1, 8, 9 })));
            Console.WriteLine(string.Format("Output Array: {0}", string.Join(" ", res)));
        }

        private int[] PrintArrayInZigZag(int[] input)
        {
            bool isZero = true;
            for(int i=0; i<=input.Length-2; i++)
            {
                if (isZero)
                {
                    if(input[i] < input[i + 1])
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                    }
                    isZero = false;
                }
                else
                {
                    if (input[i] > input[i + 1])
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;

                    }
                    isZero = true;
                }
            }
            return input;
        }

        private void WordInArrayTransformation_Click(object sender, EventArgs e)
        {
            var res = PathOfWordInArrayTransformation(new List<string> { "DOG", "DIG", "BIG", "BAG", "BAT", "CAT", "RAT" }, "PIG", "CAT");
            res.ForEach(Console.WriteLine);
            // https://www.geeksforgeeks.org/transform-one-string-to-another-using-minimum-number-of-given-operation/
            // https://www.geeksforgeeks.org/word-ladder-length-of-shortest-chain-to-reach-a-target-word/
        }
        private List<string> PathOfWordInArrayTransformation(List<string> array, string input, string output)
        {
            var result = new List<string>() { input };
            string inputToBeProcessed = input;
            while (array.Count > 0)
            {
                foreach(string str in array.ToList())
                {
                    for(int i=0; i<str.Length; i++)
                    {
                        var aa = ReplaceChar(str, i);
                        var bb = ReplaceChar(inputToBeProcessed, i);
                        if(aa == bb)
                        {
                            inputToBeProcessed = str;
                            result.Add(str);
                            array.Remove(str);
                            if (str == output)
                                return result;
                            break;
                        }
                    }
                }
            }
            result = new List<string>();
            return result;
        }
        private string ReplaceChar(string input, int index)
        {
            var temp = input.ToArray();
            temp[index] = '?';
            return new string(temp);
        }

        private void SumOfNumberInArrayEqualToInput_Click(object sender, EventArgs e)
        {
            var list = SumOfNumEqualToInput();
            list.ForEach(Console.WriteLine);
        }

        private List<string> SumOfNumEqualToInput()
        {
            int[] input = new int[] { 3, 7, 4, 8, 11, 12, 15, -1 };
            int number = 11;
            List<string> list = new List<string>();

            for (int i = 0; i < input.Length - 2; i++)
            {
                for (int j = i + 1; j < input.Length - 2; j++)
                {
                    if (input[i] + input[j] == number)
                    {
                        list.Add(string.Format("Index {0} with value {1} and index {2} with value {3} forms the expected number {4}", i, input[i], j, input[j], number));
                    }
                }
            }

            return list;
        }

        private void SumOfSubArrayEqualsSum(int[] arr, int sum)
        {
            int subSum = arr[0];
            int start = 0;

            for (int i = 1; i <= arr.Length - 1; i++)
            {
                while (subSum > sum && start < i-1)
                {
                    subSum -= arr[start];
                    start++;
                }

                if (subSum == sum)
                {
                    Console.WriteLine("SubArray is from {0} and {1}", start, i - 1);
                }

                if (i < arr.Length - 1)
                    subSum += arr[i];
            }
        }

        private void FindAllSequences_Click(object sender, EventArgs e)
        {
            int[] input = new int[] { 1, 2, 3, 7, 9, 10, 11, 12, 15, 16, 18, 20};
            foreach (int i in input)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            PrintSeq(input);    
        }

        private void PrintSeq(int[] arr)
        {
            int start = 0;
            int end = arr.Length-1;
            int i = 0;
            //bool isBreak = false;
            int expected = arr[i];
            List<int> output = new List<int>();

            while (i <= end)
            {
                if (arr[i] != expected)
                {
                    if (output.Count > 1)
                    {
                        Console.WriteLine("Sequence....");
                        output.ForEach(Console.WriteLine);
                    }
                    output = new List<int>();
                    output.Add(arr[i]);
                    expected = arr[i];
                }
                else
                {
                    output.Add(arr[i]);
                }
                i++;
                expected++;
            }

            if (output.Count > 1)
            {
                Console.WriteLine("Sequence....");
                output.ForEach(Console.WriteLine);
            }
        }

        private void SumOfContinousSubArray_Click(object sender, EventArgs e)
        {
            var input = new int[] { 4, -3, -2, 2, 3, 1, -2, -3, 4, 2, -6, -3, -1, 3, 1, 2 };
            int maxSoFar = input[0];
            int maxEndingHere = 0;
            int start = 0, end = 0, s = 0;

            for(int i=0; i<input.Length -1; i++)
            {
                maxEndingHere = maxEndingHere + input[i];
                if (maxSoFar < maxEndingHere)
                {
                    maxSoFar = maxEndingHere;
                    start = s; end = i;
                }

                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0;
                    s = i + 1;
                }
            }

            Console.WriteLine("Max Value - " + maxSoFar);
            Console.WriteLine("StartIndex: " + start + "EndIndex: " + end);
        }

        private void MergeTwoSortedArrays_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[] { 1, 4, 7, 8, 14, 24, 33, 35, 37, 39 };
            int[] arr2 = new int[] { 2, 3, 5, 10, 12, 16, 17, 18, 19, 20};
            var res = MergeArrays(arr1, arr2).ToList();
            // Console.WriteLine(res);
            res.ForEach(Console.WriteLine);
        }

        private int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int a1Len = arr1.Length;
            int a2Len = arr2.Length;
            int i = 0, j = 0, k = 0;
            int[] res = new int[a1Len + a2Len];

            while (i <= a1Len - 1 && j <= a2Len - 1)
            {
                if (arr1[i] < arr2[j])
                {
                    res[k] = arr1[i];
                    i++; k++;
                }
                else
                {
                    res[k] = arr2[j];
                    j++; k++;
                }
            }

            while (i <= a1Len - 1)
            {
                res[k] = arr1[i];
                i++; k++;
            }

            while (j <= a2Len - 1)
            {
                res[k] = arr2[j];
                j++; k++;
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BinarySearch_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 2, 3, 5, 8, 9, 12, 15, 22 };
            int res = BinarySearchRec(arr, 9);
            Console.WriteLine(res);
        }

        private int BinarySearchRec(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low<=high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                    return mid;
                else if(arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        private void FindFirstOrLastOccurenceOfNumber_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 1,1, 2,2,2,2,2,2,3,3,3,3, 3, 4,4,4,4,4, 5,5,5,5,5, 6, 7, 8, 9 };
            int res = BinarySearchFindFirstOrLastOccurence(arr, 2);
            Console.WriteLine(res);
        }

        private int BinarySearchFindFirstOrLastOccurence(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            int retValue = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                {
                    // First Occurence
                    retValue = mid;
                    high = mid - 1;

                    // Last Occurence
                    // retValue = mid;
                    // low = mid + 1;
                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return retValue;
        }

        private int FindFirstOccurence(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            int retValue = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                {
                    // First Occurence
                    retValue = mid;
                    high = mid - 1;

                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return retValue;
        }

        private int FindLastOccurence(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            int retValue = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                {
                    // Last Occurence
                    retValue = mid;
                    low = mid + 1;

                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return retValue;
        }

        private void NumberOfOccurences_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 7, 8, 9 };
            int res = CountNumberOfOccurences(arr, 1);
            Console.WriteLine(res);
        }

        private int CountNumberOfOccurences(int[] arr, int x)
        {
            int first = FindFirstOccurence(arr, x);
            int last = FindLastOccurence(arr, x);

            return (last - first) + 1;
        }


        private int FindRotatedIndex(int[] arr, int x)
        {
            int low = 0;
            int high = arr.Length - 1;
            
            while(low <= high)
            {
                int mid = (low + high) / 2;
                if(arr[low] < arr[high])
                {
                    return low;
                }
                int next = (mid + 1) % x;
                int prev = (mid + (x - 1)) % x;
                if (arr[mid] <= arr[next] && arr[mid] <= arr[prev])
                {
                    return mid;
                }
                else if(arr[mid] <= arr[high])
                {
                    high = mid - 1;
                }
                else if(arr[mid] >= arr[low])
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        private void MergeSortAlg_Click(object sender, EventArgs e)
        {
            int[] input = new int[] { 2, 4, 1, 6, 8, 5, 3, 7 };
            var res = MergeSort(input);
            var b = res;
        }

        private int[] MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n < 2)
                return arr;

            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for(int i = 0; i<mid; i++)
            {
                left[i] = arr[i];
            }

            for(int i=mid; i<n; i++)
            {
                right[i-mid] = arr[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);
            var res = MergeArrays(left, right);
            return res;
        }

        private int[] MergeArrays(int[] arr1, int[] arr2, int[] res)
        {
            int a1Len = arr1.Length;
            int a2Len = arr2.Length;
            int i = 0, j = 0, k = 0;
            res = new int[a1Len + a2Len];

            while (i <= a1Len - 1 && j <= a2Len - 1)
            {
                if (arr1[i] < arr2[j])
                {
                    res[k] = arr1[i];
                    i++; k++;
                }
                else
                {
                    res[k] = arr2[j];
                    j++; k++;
                }
            }

            while (i <= a1Len - 1)
            {
                res[k] = arr1[i];
                i++; k++;
            }

            while (j <= a2Len - 1)
            {
                res[k] = arr2[j];
                j++; k++;
            }

            return res;
        }

        private void SortArrayElements012_Click(object sender, EventArgs e)
        {
            int[] input = new int[] { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            var res = Sort012(input);
            var aa = res;
        }

        private int[] Sort012(int[] arr)
        {
            int low = 0;
            int mid = 0;
            int high = arr.Length - 1;

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        var temp = arr[low];
                        arr[low] = arr[mid];
                        arr[mid] = temp;
                        // swap(arr[low], arr[mid]);
                        low++; mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        var temp2 = arr[mid];
                        arr[mid] = arr[high];
                        arr[high] = temp2;
                        // Swap(arr[mid], arr[high]);
                        high--;
                        break;
                }
            }
            return arr;
        }

        private void FindEqulibirium_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[] { 3,1,5,2,2 };
            int[] arr = new int[] { 2, 3, 1, 4, 1, 1, 6, 5, 6 };
            var res = EquilibriumPoint(arr);
            Console.WriteLine(res);
        }

        private int EquilibriumPoint(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            int subSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                subSum += arr[i];
                if (subSum == sum)
                    return i;


                sum -= arr[i];
            }

            return -1;
        }

        private void FindMax3UsedWordsInFile_Click(object sender, EventArgs e)
        {
            string[] inputText = new string[] { "a","b","c","a","b","d","a","c","e","c","f","r","k","a","b","c","d","k" };
            PrintMax3Words(inputText, 3);
        }

        private void PrintMax3Words(string[] words, int n)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            foreach (string str in words)
            {
                if (results.ContainsKey(str))
                {
                    int count = results[str];
                    results[str] = ++count;
                }
                else
                    results.Add(str, 1);
            }
            var top = results.OrderByDescending(x => x.Value).Take(n).Select(x => x.Key).ToList();

            top.ForEach(Console.WriteLine);

        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 2, 8, 9 , 3, 1, 5, 6, 7, 4};
            Console.WriteLine("Before Sorting: ");
            arr.ToList().ForEach(Console.WriteLine);
            var res = BubbleSort1(arr);
            Console.WriteLine("After Sorting: ");
            res.ToList().ForEach(Console.WriteLine);
        }

        private int[] BubbleSort1(int[] arr)
        {
            bool needsSorting = true;
            while (needsSorting)
            {
                needsSorting = false;
                for (int i = 1; i <= arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                        needsSorting = true;
                    }
                }
            }
            return arr;
        }

        private void NumPlatformsRequired_Click(object sender, EventArgs e)
        {
            int[] arrival = new int[] { 900, 940, 950, 1100, 1500, 1800 };
            int[] departures = new int[] { 910, 1200, 1120, 1130, 1900, 2000 };
            var res = NumberOfPlatforms(arrival, departures);
            Console.WriteLine(res);
        }

        private int NumberOfPlatforms(int[] arr, int[] dep)
        {
            Array.Sort(arr);
            Array.Sort(dep);

            int n = arr.Length;
            int numOfPlatforms = 1;
            int res = 1;
            int i = 1;
            int j = 0;

            while (i < n && j < n)
            {
                if (arr[i] < dep[j])
                {
                    i++;
                    numOfPlatforms++;

                    if (numOfPlatforms > res)
                        res = numOfPlatforms;
                }
                else
                {
                    j++;
                    numOfPlatforms--;
                }
            }
            return res;
        }

        private void RoomsAvailableInHotel_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3, 4, 6 };
            int[] dep = { 2, 6, 5, 5, 7 };

            //int[] arr = { 1, 3, 5 };
            //int[] dep = { 2, 6, 8 };

            int k = 3;
            var res = CheckIfRoomsAvailable(arr, dep, k);
            Console.WriteLine(res);
        }

        private bool CheckIfRoomsAvailable(int[] arr, int[] dep, int k)
        {
            Array.Sort(arr);
            Array.Sort(dep);

            int roomsAvailable = 1;
            int i = 1; int j = 0;
            int n = arr.Length;

            while (i < n && j < n)
            {
                if (arr[i] < dep[j])
                {
                    i++;
                    roomsAvailable++;
                    if (roomsAvailable > k)
                        return false;
                }
                else
                {
                    j++;
                    roomsAvailable--;
                }
            }
            return true;
        }

        private void LeadersInAnArray_Click(object sender, EventArgs e)
        {
            // var res = LeadersInArray(new int[] { 16, 17, 4, 3, 5, 2 });
            // var res = LeadersInArray(new int[] { 16, 17, 4, 3, 5 });
            var res = LeadersInArray(new int[] { 2, 4, 5, 4, 8, 12, 4, 15, 1 });
            res.ForEach(Console.WriteLine);
        }

        private List<int> LeadersInArray(int[] arr)
        {
            int curr = -1;
            List<int> retValue = new List<int>();
            int currentLeader = arr[arr.Length - 1];

            retValue.Add(currentLeader);
            for (int i = arr.Length-2; i >=0; i--)
            {
                curr = arr[i];
                if (curr > currentLeader)
                {
                    retValue.Add(curr);
                    currentLeader = curr;
                }
            }
            return retValue;
        }

        private void SubArraySumForInputK_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 4, 2,1 ,10, 23, 3, 1, 0,25, 20 };
            var res = MaxValueOnSubArray(arr, 4);
            Console.WriteLine(res);
        }

        private int MaxValueOnSubArray(int[] arr, int k)
        {
            int currMax = 0;
            int start = 0;
            int currValue = 0;

            for (int i = 0; i < k; i++)
            {
                currMax += arr[i];
            }
            currValue = currMax;
            for (int i = k; i < arr.Length; i++)
            {
                currValue = arr[i] + currValue - arr[i - k];
                currMax = Math.Max(currMax, currValue);
            }
            return currMax;
        }

        private void ReverseArrayInGroups_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var res = ReverseInGroups(arr, 4);
            arr.ToList().ForEach(Console.WriteLine);
        }

        private int[] ReverseInGroups(int[] arr, int k)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int innerStart = start;
                int innerEnd = innerStart + k-1;

                if (innerEnd > end)
                    innerEnd = end;

                while (innerStart < innerEnd)
                {
                    int temp = arr[innerStart];
                    arr[innerStart] = arr[innerEnd];
                    arr[innerEnd] = temp;
                    innerStart++;
                 innerEnd--;
                }
                start = start + k;
            }

            return arr;
        }

        private void MinElementsBtwnTwoArrayElements_Click(object sender, EventArgs e)
        {
            int[] arr = { 7, 3, 2, 4, 9, 12, 56 };
            var res = MinArrayDiff(arr, 3);
            var err = res;
        }

        private int MinArrayDiff(int[] arr, int m)
        {
            Array.Sort(arr);
            int n = arr.Length - 1;
            int first = 0;
            int last = 0;
            int minDiff = int.MaxValue;

            for (int i = 0; i + m - 1 < n; i++)
            {
                int diff = arr[i + m - 1] - arr[i];
                if (diff < minDiff)
                {
                    minDiff = diff;
                    first = i;
                    last = i + m - 1;
                }
            }

            return (arr[last] - arr[first]);
        }

        private void MaxDiffBetweenTwoElementsOfArray_Click(object sender, EventArgs e)
        {
            int[] arr = { 2, 3, 10, 6, 4, 8, 1 };

            int maxDiff = arr[1] - arr[0];
            int minValue = arr[0];

            for(int i=1; i<arr.Length-1; i++)
            {
                if (arr[i] - minValue > maxDiff)
                    maxDiff = arr[i] - minValue;

                if (arr[i] < minValue)
                    minValue = arr[i];
            }
            Console.WriteLine(maxDiff);
        }

        private void RemoveDuplicatesInPlace_Click(object sender, EventArgs e)
        {
            var res = RemoveDupesFromArrayInPlace(new int[] { 1, 1, 2, 2, 3, 3 });
        }

        private int[] RemoveDupesFromArrayInPlace(int[] arr)
        {
            int i = 0;
            int j = 1;

            while(j<arr.Length)
            {
                if(arr[i] != arr[j])
                {
                    i++;
                    arr[i] = arr[j];
                }
                j++;
            }

            return arr;
        }

        private void RemoveElementsByValue_Click(object sender, EventArgs e)
        {
            var res = RemoveElementsByGivenValue(new int[] { 3, 2, 2, 3 }, 3);
        }

        private int[] RemoveElementsByGivenValue(int[] arr, int val)
        {
            int i = 0;
            int n = arr.Length;

            while(i < n)
            {
                if(arr[i] == val)
                {
                    arr[i] = arr[n - 1];
                    n--;
                }
                else
                {
                    i++;
                }
            }

            return arr;
        }

        private void MatchSubstring_Click(object sender, EventArgs e)
        {
            var res = StrStr("a", "a");
            var s = res;
        }
        private int StrStr(string haystack, string needle)
        {
            int haystackLen = haystack.Length;
            int needleLen = needle.Length;
            int threshold = haystackLen - needleLen;

            if (threshold < 0)
            {
                return -1;
            }
            else if (haystackLen == 0 || needleLen == 0)
            {
                return 0;
            }

            for (int i = 0; i <= threshold; i++)
            {
                if (haystack.Substring(i, needleLen) == needle)
                    return i;
            }
            return -1;

        }

        private void SearchInsertPosition_Click(object sender, EventArgs e)
        {
            var res1 = SearchUsingBinarySearch(2, new int[] { 1, 3, 5, 6 });
            var res2 = SearchUsingBinarySearch(7, new int[] { 1, 3, 5, 6 });
            var res3 = SearchUsingBinarySearch(0, new int[] { 1, 3, 5, 6 });
            var res4 = SearchUsingBinarySearch(6, new int[] { 7, 8, 9, 10 });
            var res5 = SearchUsingBinarySearch(7, new int[] { 6, 8, 9, 10 });
            var res6 = SearchUsingBinarySearch(10, new int[] { 6, 8, 9, 11 });
            var res7 = SearchUsingBinarySearch(9, new int[] { 6, 8, 10, 11 });
            //var res1 = res;
        }

        private int SearchUsingBinarySearch(int x, int[] arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            if (x > arr[high])
                return high + 1;
            if (x < arr[low])
                return 0;

            int mid = -1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }

        private void MoveZerosToLast_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Input is " + string.Join(", ", new int[] { 11, 0, 3, 0, 0, 5, 7 }) + "  Output is " + string.Join(", ", MoveZeros(new int[] { 11, 0, 3, 0, 0, 5, 7 })));
            var res2 = MoveZeros(new int[] { 11, 0, 0, 0, 0, 5, 7 });
            var res3 = MoveZeros(new int[] { 0, 0, 0, 0, 0, 5, 7 });
            var res4 = MoveZeros(new int[] { 11, 3, 0, 0, 0 });
        }

        private int[] MoveZeros(int[] arr)
        {
            int zeroIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0 && zeroIndex != -1)
                {
                    //Swap
                    int temp = arr[i];
                    arr[i] = arr[zeroIndex];
                    arr[zeroIndex] = temp;

                    zeroIndex = ++zeroIndex;
                }

                if (arr[i] == 0 && zeroIndex == -1)
                {
                    zeroIndex = i;
                }
            }
            return arr;
        }

        private void QuickSort_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 4, 7, 9, 1, 5, 2, 6, 3, 8 };
            Console.Write("Initial Array is - ");
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }
            QuickSort1(arr, 0, arr.Length - 1);
            Console.WriteLine("");
            Console.Write("Array after Sort is - ");
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }

        }

        private int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int partitionIndex = start;

            for(int i=start; i<end; i++)
            {
                if(arr[i] <= pivot)
                {
                    // Swap
                    int temp1 = arr[i];
                    arr[i] = arr[partitionIndex];
                    arr[partitionIndex] = temp1;
                    partitionIndex++;
                }
            }
            // Swap
            int temp = arr[end];
            arr[end] = arr[partitionIndex];
            arr[partitionIndex] = temp;
 
            return partitionIndex;
        }

        private void QuickSort1(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int partitionIndex = Partition(arr, start, end);
                QuickSort1(arr, start, partitionIndex-1);
                QuickSort1(arr, partitionIndex + 1, end);
            }
        }

        private void SlidingWindowMaximum_Click(object sender, EventArgs e)
        {
            //SlidingWindow(new int[] { 3, 1, -1, -3, 5, 3, 6, 7 }, 3);
            var res1 = MaxSlidingWindow(new int[] { 3, 1, -1, -3, 5, 3, 6, 7 }, 3);
            //var res = GetAllSlidingWindowMax(new int[] { 3, 1, -1, -3, 5, 3, 6, 7 }, 3);
            //res.ToList().ForEach(Console.WriteLine);
        }

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
                return new int[0];

            if (k == 1)
                return nums;

            int[] result = new int[nums.Length - k + 1];

            int maxPos = 0, i = 0;
            for (int j = 1; j < k; j++)
            {
                if (nums[j] > nums[maxPos])
                    maxPos = j;
            }
            result[i] = nums[maxPos];
            i++;

            int start = 1, end = (k - start) + 1;
            while (start < nums.Length - k + 1)
            {
                if (start <= maxPos && end >= maxPos)
                {
                    if (nums[maxPos] < nums[end])
                    {
                        maxPos = end;
                        result[i] = nums[end];
                        i++;
                    }
                    else
                    {
                        result[i] = nums[maxPos];
                        i++;
                    }
                }
                else
                {
                    maxPos = start;
                    for (int j = start + 1; j <= end; j++)
                    {
                        if (nums[j] > nums[maxPos])
                            maxPos = j;
                    }
                    result[i] = nums[maxPos];
                    i++;
                }
                start++;
                end++;
            }
            return result;
        }

        private int[] GetAllSlidingWindowMax(int[] arr, int x)
        {
            int[] maxLeft = new int[arr.Length];
            int[] maxRight = new int[arr.Length];

            maxLeft[0] = arr[0];
            maxRight[arr.Length - 1] = arr[arr.Length - 1];

            for(int i = 1; i< arr.Length; i++)
            {
                maxLeft[i] = (i % x == 0) ? arr[i] : Math.Max(maxLeft[i - 1], arr[i]);

                int j = arr.Length - i- 1;
                maxRight[j] = (j % x == 0) ? arr[j] : Math.Max(maxRight[j+1], arr[j]);
            }

            int[] slidingMax = new int[arr.Length - x + 1];
            for (int i = 0, j = 0; i + x <= arr.Length; i++)
            {
                slidingMax[j++] = Math.Max(maxRight[i], maxLeft[i + x -1]);
            }

            return slidingMax;
        }


        private void SlidingWindow(int[] arr, int k)
        {
            Console.Write("\nResult : ");
            if (k <= 0)
            {
                Console.Write("NA");
                return;
            }
            var temp = arr[0];
            for (var i = 1; i < k && i < arr.Length; i++)
            {
                if (arr[i] > temp)
                    temp = arr[i];
            }
            Console.Write(temp + " ");
            for (var j = k; j < arr.Length; j++)
            {
                if (k == 1 || arr[j] > temp)
                    temp = arr[j];
                Console.Write(temp + " ");
            }
        }

        private void FindNumberInRotatedArray_Click(object sender, EventArgs e)
        {
            var res1 = GetNumberInRotatedArray(new int[] { 3, 4, 5, 1, 2 }, 1);
            var res2 = GetNumberInRotatedArray(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3);
            var res3 = GetNumberInRotatedArray(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
        }

        private int GetNumberInRotatedArray(int[] arr, int x)
        {
            if (arr == null || arr.Length <= 0) return -1;
            int low = 0;
            int high = arr.Length - 1;
            int arrLen = arr.Length - 1;

            while(low < high)
            {
                int mid = low + (high - low) / 2;
                if((arr[mid] - arr[arrLen]) * (x - arr[arrLen]) > 0) // Target and Mid are in different sides
                {
                    if (arr[mid] < x)
                    {
                        low = mid + 1;
                    }
                    else
                        high = mid;
                }
                else if(x > arr[arrLen]) // Left side
                {
                    high = mid;
                }
                else // Right side
                {
                    low = mid + 1;
                }
            }

            if (arr[low] == x)
                return low;
            else
                return -1;
        }

        private void SmallestCommonNumberInThreeArrays_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[] { 2, 8, 15, 20, 35, 45, 100 };
            int[] arr2 = new int[] { 5, 9, 20, 45, 110 };
            int[] arr3 = new int[] { 3, 4, 15, 20, 30, 45, 80, 120 };
            var retValue1 = FindCommonSmallestNumber_Approach2(arr1, arr2, arr3);
            var retvalue2 = FindCommonSmallestNumber_Approach1(arr1, arr2, arr3);
        }

        private int FindCommonSmallestNumber_Approach1(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length && k < arr3.Length)
            {
                if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
                {
                    return arr1[i];
                }
                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr2[j] < arr3[k])
                {
                    j++;
                }
                else
                    k++;
            }
            return -1;
        }

        private int FindCommonSmallestNumber_Approach2(int[] arr1, int[] arr2, int[] arr3)
        {
            int i = 0, j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    // Find the element in 3rd arr
                    if (FindElementInArray(arr3, arr1[i]) == true)
                    {
                        return arr1[i];
                    }
                    else
                    {
                        i++; j++;                    }
                }
                if (arr1[i] > arr2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }

        private bool FindElementInArray(int[] arr, int data)
        {
            var len = arr.Length;
            var min = 0;
            var max = len - 1;
            while (min < max)
            {
                var mid = (min + max) / 2;
                if (arr[mid] == data)
                    return true;
                else if (arr[mid] < data)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return false;
        }

        private void RotateArrayByNElements_Click(object sender, EventArgs e)
        {
            int[] input1 = new int[] { 1, 2, 3, 4, 5 };
            var res1 = RotateArray(input1, 2);
            res1.ToList().ForEach(Console.WriteLine);
        }

        private int[] RotateArray(int[] arr, int k)
        {
            var reversedArr = ReverseArrayByStartEnd(arr, 0, arr.Length - 1);
            var one = ReverseArrayByStartEnd(reversedArr, 0, k - 1);
            var res = ReverseArrayByStartEnd(reversedArr, k, arr.Length - 1);
            return res;
        }

        private int[] ReverseArrayByStartEnd(int[] arr, int start, int end)
        {
            if (arr.Length > 0 && start < arr.Length - 1 && end <= arr.Length - 1)
            {
                while (start < end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
                return arr;
            }
            return arr;
        }

        private void FindFirstAndLastOccurenceOfNumber_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 7, 8, 9 };
            int x = 2;
            int first = FindFirstAndLastOccurence(arr, x, true);
            int last = FindFirstAndLastOccurence(arr, x, false);

            Console.WriteLine("First Occurence of " + x + " is in index " + first);
            Console.WriteLine("Last Occurence of " + x + " is in index " + last);
        }

        private int FindFirstAndLastOccurence(int[] arr, int x, bool isFirst)
        {
            int low = 0;
            int high = arr.Length - 1;
            int retValue = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == x)
                {
                    retValue = mid;

                    if (isFirst)
                        high = mid - 1; // First Occurence
                    else
                        low = mid + 1; // Last Occurence

                }
                else if (arr[mid] > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return retValue;
        }

        private void MoveZerosToFirstOrLast_Click(object sender, EventArgs e)
        {
            int[] input = new int[] { 1, 2, 0, 3, 0, 0, 5, 0, 7, 6, 0, 9, 8 };
            Print(input, "Input is -- ");
            Console.WriteLine(""); Console.WriteLine("");
            var first = MoveZerosToFirst(input);
            Print(input, "Output for Move Zeros to First is -- ");
            Console.WriteLine(""); Console.WriteLine("");
            var last = MoveZerosToLast1(input);
            Print(last, "Output for Move Zeros to Last is -- ");
        }

        private int[] MoveZerosToLast1(int[] arr)
        {
            int zeroIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0 && zeroIndex != -1)
                {
                    // Swap Logic
                    int temp = arr[i];
                    arr[i] = arr[zeroIndex];
                    arr[zeroIndex] = temp;

                    zeroIndex++;
                }

                if (arr[i] == 0 && zeroIndex == -1)
                    zeroIndex = i;
            }
            return arr;
        }

        private int[] MoveZerosToFirst(int[] arr)
        {
            int zeroIndex = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != 0 && zeroIndex != -1)
                {
                    // Swap Logic
                    int temp = arr[i];
                    arr[i] = arr[zeroIndex];
                    arr[zeroIndex] = temp;

                    zeroIndex--;
                }

                if (arr[i] == 0 && zeroIndex == -1)
                    zeroIndex = i;
            }
            return arr;
        }

        private void Print(int[] arr, string appendStr)
        {
            Console.Write(appendStr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }

        private void MaxBuySellProfit_Click(object sender, EventArgs e)
        {
            var res1 = GetMaxProfit(new int[] { 45, 24, 35, 31, 40, 38, 11 });
            var res2 = GetMaxProfit(new int[] { 2, 3, 10, 6, 4, 8, 1 });
        }

        // https://coderbyte.com/algorithm/stock-maximum-profit
        private int GetMaxProfit(int[] arr)
        {
            int buyPrice, sellPrice, maxProfit;
            buyPrice = arr[0];
            sellPrice = arr[1];
            maxProfit = arr[1] - arr[0];

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] < buyPrice)
                    buyPrice = arr[i];

                sellPrice = arr[i + 1];
                int currProfit = sellPrice - buyPrice;
                maxProfit = Math.Max(currProfit, maxProfit);
            }
            return maxProfit;
        }

        private void MergeOverlappingIntervals_Click(object sender, EventArgs e)
        {
            Interval[] arr1 = new Interval[] 
            {
                new Interval() { start = 1, end = 3},
                new Interval() { start = 2, end = 6},
                new Interval() { start = 5, end = 9},
                new Interval() { start = 7, end = 11},
            };

            MergeIntervals(arr1);

            Interval[] arr2 = new Interval[]
            {
                new Interval() { start = 1, end = 3},
                new Interval() { start = 2, end = 5},
                new Interval() { start = 6, end = 10},
                new Interval() { start = 9, end = 11},
            };

            MergeIntervals(arr2);
        }

        //https://www.geeksforgeeks.org/merging-intervals/
        private void MergeIntervals(Interval[] arr)
        {
            Console.Write("The Input for Merge is ");
            foreach(var x in arr)
            {
                Console.Write("[" + x.start + ", " + x.end + "] ");
            }
            Console.WriteLine("");

            int n = arr.Length;
            int index = 0;

            for(int i=0;i<n;i++)
            {
                if(index !=0 && arr[index-1].end >= arr[i].start)
                {
                    while(index != 0 && arr[index-1].end >= arr[i].start)
                    {
                        arr[index - 1].start = Math.Min(arr[index - 1].start, arr[i].start);
                        arr[index - 1].end = Math.Max(arr[index - 1].end, arr[i].end);
                        index--;
                    }
                }
                else
                {
                    arr[index] = arr[i];
                }
                index++;
            }

            Console.Write("The Output for Merge is ");
            for(int x = 0; x < index; x++)
            {
                Console.Write("[" + arr[x].start + ", " + arr[x].end + "] ");
            }
            Console.WriteLine("");
        }

        private void SumOfTwoValues_Click(object sender, EventArgs e)
        {
            int[] arr = new int[] { 5, 7, 1, 2, 8, 4, 3 };
            Console.Write("The Input Array is (Approach 1) ");
            foreach (var x in arr)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine("The Output is Approach 1 -- " + SumOfTwoValues_1(arr, 10));
            Console.WriteLine("");
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach (var x in arr2)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine("The Output is Approach 2 -- " + SumOfTwoValues_2(arr2, 10));
        }

        private string SumOfTwoValues_1(int[] arr, int x)
        {
            Dictionary<int, int> list = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                int exp = x - i;
                if (list.ContainsKey(exp))
                {
                    return "[" + i + ", " + exp + "]";
                }
                else
                    list.Add(i, i);
            }

            return "-1";
        }

        private string SumOfTwoValues_2(int[] arr, int x)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                if (arr[start] + arr[end] == x)
                {
                    return "[" + arr[start] + ", " + arr[end] + "]";
                }
                else if (arr[start] + arr[end] > x)
                {
                    end--;
                }
                else
                {
                    start++;
                }
            }
            return "-1";
        }
    }

    public class Interval
    {
        public int start;
        public int end;
    }
}
