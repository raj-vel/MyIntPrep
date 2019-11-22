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
    public partial class MathAndStats : Form
    {
        public MathAndStats()
        {
            InitializeComponent();
        }

        private void FindKthPermutation_Click(object sender, EventArgs e)
        {
            for(int i=1; i<=GetFactorial(4); i++)
            {
                Console.WriteLine(i + "th permutation = \t" + GetKthPermutation(4, i));
            }
        }

        private int GetFactorial(int n)
        {
            if(n == 1 || n == 0)
            {
                return 1;
            }
            return n * GetFactorial(n - 1);
        }

        private string GetKthPermutation(int n, int k)
        {
            List<char> permutationArray = new List<char>();
            char c = '1';
            while(n>0)
            {
                permutationArray.Add(c);
                c++;
                n--;
            }
            StringBuilder result = new StringBuilder();
            FindKthPermuationFn(permutationArray, k, result);
            return result.ToString();
        }

        private void FindKthPermuationFn(List<char> arr, int k, StringBuilder res)
        {
            if (arr.Count <= 0)
                return;

            int arrLen = arr.Count;
            int permutationCount = GetFactorial(arrLen - 1);
            int selectedChar = (k - 1) / permutationCount;

            res.Append(arr[selectedChar]);
            arr.RemoveAt(selectedChar);

            k = k - (permutationCount * selectedChar);
            FindKthPermuationFn(arr, k, res);
        }

        private void DivideTwoIntegers_Click(object sender, EventArgs e)
        {
            DivideTwoIntegersFn(15, 6);
        }

        private void DivideTwoIntegersFn(int number, int divisor)
        {
            if (divisor > number)
                Console.WriteLine("Invalid Input");
            else if (divisor == number)
                Console.WriteLine("Both are same number and the reminder is 1");

            int count = 0;
            int reminder;
            int num = number;
            int div = divisor;

            while (num >= div)
            {
                num -= div;
                ++count;
            }
            reminder = num;

            Console.WriteLine("Number {0} is divisible by {1} is {2} time(s) and the reimder is {3}", number, divisor, count, reminder);
        }

        private void IsPythagoreanTriplets_Click(object sender, EventArgs e)
        {
            FindPythagoreanTriplet(new int[] { 3, 1, 4, 6, 5 });
        }

        private void FindPythagoreanTriplet(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
            }

            Array.Sort(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int l = 0;
                int r = arr.Length - 1;

                while (l < r)
                {
                    if (arr[i] == arr[l] + arr[r])
                    {
                        Console.WriteLine($"The triplets are {i}, {l} and {r}");
                        return;
                    }
                    else if (arr[l] + arr[r] > arr[i])
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }
            Console.WriteLine("There are NO triplets in this array");
        }

        private void FindAllPythagoreanTriplets_Click(object sender, EventArgs e)
        {
            PrintAllPythagorean(20);
        }

        private void PrintAllPythagorean(int limit)
        {
            if (limit < 2)
                Console.WriteLine("Invalid input");

            int a, b, c = 0;
            int m = 2;

            while (c < limit)
            {
                for (int n = 1; n < m; ++n)
                {
                    a = (m * m) - (n * n);
                    b = 2 * m * n;
                    c = (m * m) + (n * n);

                    if (c > limit)
                        break;

                    Console.WriteLine($"{a}, {b} and {c}");
                }
                m++;
            }
        }

        private void AllSumCombinations_Click(object sender, EventArgs e)
        {
            GetAllCombinations(6);
        }

        private void GetAllCombinations(int sum)
        {
            int[] arr = new int[sum];
            Recursive(arr, 0, sum, sum);
        }

        private void Recursive(int[] arr, int i, int sum, int remining)
        {
            int prev = i > 0 ? arr[i - 1] : 1;
            for (int k = prev; k <= sum; k++)
            {
                arr[i] = k;

                if (remining > k)
                    Recursive(arr, i + 1, sum, remining - k);

                if (remining == k)
                    PrintArr(arr, i);
            }
        }

        private void PrintArr(int[] arr, int n)
        {
            for(int i=0; i<=n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine("");
        }

        private void FindTheMissingNumber_Click(object sender, EventArgs e)
        {
            int res = FindMissingNumberInSequence(new int[] { 7, 11,12,13,2,3,4,5,6,1,9,10});
            var res1 = res;
        }

        private int FindMissingNumberInSequence(int[] arr)
        {
            int n = arr.Length+1;
            int expected = ((n*n) + n) / 2;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                expected -= arr[i];
            }
            return expected;
        }

        private void FindAllPermutations_Click(object sender, EventArgs e)
        {
            string input = "abcdef";
            RecursivePermutation(input.ToCharArray(), 0);
        }

        private void RecursivePermutation(char[] arr, int index)
        {
            if (index == arr.Length - 1)
                Console.WriteLine(new string(arr));

            for (int i = index; i < arr.Length; i++)
            {
                arr = Swap(arr, index, i);
                RecursivePermutation(arr, index + 1);
                arr = Swap(arr, index, i);
            }
        }

        private char[] Swap(char[] arr, int x, int y)
        {
            char temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
            return arr;
        }

        private void AllSubsetsOfGivenInteger_Click(object sender, EventArgs e)
        {
            GetAllSubSets(new int[] { 1, 2, 3 });
        }

        // https://www.techiedelight.com/print-distinct-subsets-given-set/
        private void GetAllSubSets(int[] arr)
        {
            Array.Sort(arr);
            int n = (int)Math.Pow(2, arr.Length);
            for (int i = 0; i < n; i++)
            {
                string subset = "";
                for (int j = 0; j < arr.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                        subset += arr[j] + " ";
                }

                Console.WriteLine(subset);
            }
        }

        private void GivenInputIsIntegerOrNot_Click(object sender, EventArgs e)
        {
            // https://www.geeksforgeeks.org/check-given-string-valid-number-integer-floating-point/
            var req = Console.ReadLine();
            var res = IsInteger(req);
            Console.WriteLine($"The input {req} is Number: {res}");
        }

        private bool IsInteger(string str)
        {
            str = str.Trim();
            int startIndex = (str[0] == '-' || str[0] == '+') ? 1 : 0;

            bool isDotAllowed = true;
            bool isEAllowed = true;

            for (int i=startIndex; i< str.Length; i++)
            {
                char curr = str[i];
                if (curr == 'e')
                {
                    if (!isEAllowed)
                        return false;

                    isDotAllowed = false;
                    isEAllowed = false;
                }
                else if (curr == '.')
                {
                    if (!isDotAllowed)
                        return false;

                    isDotAllowed = false;
                    isEAllowed = false;
                }
                else if ((int)curr >= 48 && (int)curr <= 57)
                {
                    continue;
                }
                else
                    return false;
                
            }
            return true;
        }

        private void PowerOfN_Click(object sender, EventArgs e)
        {
            int exponent = 123;
            int b_ase = 456;
            Power(b_ase, exponent);
        }

        private void Power(int x, int n)
        {
            int[] arr = new int[10000];
            int arrSize = 0;
            int newBase = x;

            while(newBase > 0)
            {

                int temp = newBase % 10;
                arr[arrSize++] = temp;
                newBase /= 10;
            }

            for(int i=2; i<= n; i++)
            {
                arrSize = Multiply(arr, x, arrSize);
            }

            for (int i = arrSize - 1; i >= 0; i--)
                Console.Write(arr[i]);

        }

        private int Multiply(int[] arr1, int x, int arrSize)
        {
            int carry = 0;
            for(int i=0; i<arrSize; i++)
            {
                int actual = arr1[i] * x + carry;
                arr1[i] = actual % 10;
                carry = actual / 10;
            }

            while(carry > 0)
            {
                arr1[arrSize] = carry % 10;
                carry = carry / 10;
                arrSize++;
            }
            return arrSize;
        }

        private void CalculateSquareRoot_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Square Root of 25 is {FindSquareRootByBinarySearch(25)}");
            Console.WriteLine($"Square Root of 125 is {FindSquareRootByBinarySearch(125)}");
            Console.WriteLine($"Square Root of 625 is {FindSquareRootByBinarySearch(625)}");
            Console.WriteLine($"Square Root of 500 is {FindSquareRootByBinarySearch(500)}");
            Console.WriteLine($"Square Root of 987654321 is {FindSquareRootByBinarySearch(987654321)}");
        }

        private int FindSquareRootByBinarySearch(int x)
        {
            if (x <= 0)
                return x;

            int ans = 0;
            int start = 0, end = x;
            

            while (start < end)
            {
                int mid = (start + end) / 2;
                if (mid * mid == x)
                    return mid;
           

                if (mid * mid < x)
                {
                    ans = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return ans;
        }
    }
}
