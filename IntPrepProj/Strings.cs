using OutputProj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntPrepProj
{
    public partial class Strings : Form
    {
        PrintOutput printOutput = new PrintOutput();
        public Strings()
        {
            InitializeComponent();
        }

        private void PrintMatrix(int[,] inputMatrix, string strToBePrinted = "Printing Matrix......")
        {
            int xLen = inputMatrix.GetLength(0);
            int yLen = inputMatrix.GetLength(1);
            Console.WriteLine(strToBePrinted);
            Console.WriteLine();
            for (int i = 0; i < xLen; i++)
            {
                for (int j = 0; j < yLen; j++)
                {
                    Console.Write(inputMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void PrintStringMatrix(string[,] inputMatrix, string strToBePrinted = "Printing Matrix......")
        {
            int xLen = inputMatrix.GetLength(0);
            int yLen = inputMatrix.GetLength(1);
            Console.WriteLine(strToBePrinted);
            Console.WriteLine();
            for (int i = 0; i < xLen; i++)
            {
                for (int j = 0; j < yLen; j++)
                {
                    Console.Write(inputMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        #region STRING COMPRESSION 
        private void StringCompression_Click(object sender, EventArgs e)
        {
            string input = "aaaabcccdd";
            StringBuilder output = new StringBuilder(input.Length);
            Compress(input, output);
        }

        private void Compress(string input, StringBuilder output)
        {
            int counter = 1;
            for(int i=0; i<=input.Length-1; i++)
            {
                if(i < input.Length-1 && input[i] == input[i+1])
                {
                    counter++;
                }
                else
                {
                    if (counter > 1)
                    {
                        output.Append(counter);
                        output.Append(input[i]);
                    }
                    else
                    {
                        output.Append(input[i]);
                    }
                    counter = 1;
                }
            }
            Console.Write("Compressed String: ");
            Console.Write(input.Length <= output.Length ? input : output.ToString());

            Expand(output.ToString());
        }

        private void Expand(string input)
        {
            StringBuilder output = new StringBuilder();
            for(int i=0; i<=input.Length - 1; i++)
            {
                int outParam;
                if(int.TryParse(input[i].ToString(), out outParam))
                {
                    for(int j=1; j<outParam; j++)
                    {
                        output.Append(input[i + 1]);
                    }
                }
                else
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine("");
            Console.Write("Expanded String: ");
            Console.Write(output);
        }

        #endregion

        private void PivotOfBalancedArray_Click(object sender, EventArgs e)
        {
            // refer EquilibriumPoint method in Array form
            var res = FindPivotOfBalancedArray();
            Console.WriteLine(res);
        }

        private int FindPivotOfBalancedArray ()
        {
            int[] input = new int[] { 1,1,1,1,2,3,4,5,6,7,8,3 };
            int pivot = (input.Length / 2) - 1;
            int leftValue = 0;
            int rightValue = 0;
            string direction = "";
            bool isExit = true;

            for(int i=0; i<input.Length; i++)
            {
                if(i < pivot)
                {
                    leftValue += input[i];
                }
                if(i > pivot)
                {
                    rightValue += input[i];
                }
            }
            if (leftValue > rightValue)
                direction = "right";
            else
                direction = "left";

            while (isExit)
            {
                if(leftValue == rightValue)
                {
                    return input[pivot];
                }
                if(leftValue > rightValue)
                {
                    rightValue += input[pivot];
                    leftValue -= input[pivot-1];
                    pivot--;
                    if (direction != "right")
                        isExit = false;
                }
                if (leftValue < rightValue)
                {
                    rightValue -= input[pivot+1];
                    leftValue += input[pivot];
                    pivot++;
                    if (direction != "left")
                        isExit = false;
                }
            }
            return -1;
        }

        private void NumberToString_Click(object sender, EventArgs e)
        {
            var aa = StringToNumberConversion("BC");
            //var res1 = NumberToStringConversion(1);
            //var res11 = NumberToStringConversion(2);
            //var res12 = NumberToStringConversion(3);
            //var res2 = NumberToStringConversion(17);
            //var res3 = NumberToStringConversion(27);
            //var res4 = NumberToStringConversion(28);
        }

        // Excel like
        private string NumberToStringConversion(int number)
        {
            const int initialValue = (int)'A';
            int upperBound = 26;
            string returnValue = "";
            number = number - 1;

            while (number >= 0)
            {
                returnValue = (char)((number % upperBound) + initialValue) + returnValue;
                number = (number / upperBound) - 1;
            }
            return returnValue;
        }

        private int StringToNumberConversion(string str)
        {
            const int initialValue = (int)'A' - 1;
            int upperBound = 26;
            int returnValue = 0;
            foreach(Char c in str)
            {
                returnValue *= upperBound;
                returnValue += (int)c - initialValue;
            }
            return returnValue;
        }

        private void Modify_Input_String_Click(object sender, EventArgs e)
        {
            string input = "GoodMorning";
            int rowSize = 3;
            var matrix = FormMatrix(input, rowSize);
            PrintStringMatrix(matrix);
            ReadMatrixAndPrint(matrix);
        }

        private string[,] FormMatrix(string input, int row)
        {
            string[,] matrix = new string[3, input.Length];
            int counter = 0;
            for(int j = 0; j<input.Length; j++)
            {
                for(int i=0; i<row; i++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        matrix[i, j] = "";
                    }
                    else
                    {
                        matrix[i, j] = input[counter].ToString();
                        counter++;
                    }
                    if(counter >= input.Length)
                    {
                        return matrix;
                    }
                }
            }
            return matrix;
        }

        private void ReadMatrixAndPrint(string[,] matrix)
        {
            StringBuilder output = new StringBuilder();
            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    output.Append(matrix[i, j]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(output);
        }

        private void WildcardPatternMatching_Click(object sender, EventArgs e)
        {
            //var res = IsMatch("axyb", "a*b");
            //Console.WriteLine(res);

            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "axyb", "a*b", IsWildCardMatch("axyb", "a*b")));
            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "axyb", "a??b", IsWildCardMatch("axyb", "a??b")));
            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcdef", "a*", IsWildCardMatch("abcdef", "a*")));
            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcdef", "*", IsWildCardMatch("abcdef", "*")));
            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcdef", "abcd*", IsWildCardMatch("abcdef", "abcd*")));
            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcdef", "abcde*", IsWildCardMatch("abcdef", "abcde*")));
            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcef", "abc??", IsWildCardMatch("abcef", "abc??")));
            //Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcef", "abc?", IsWildCardMatch("abcef", "abc?")));


            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "abc", IsWildCardMatch("abc", "abc")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "a*c", IsWildCardMatch("abc", "a*c")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "b*", IsWildCardMatch("abc", "b*")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "?bc", IsWildCardMatch("abc", "?bc")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "???", IsWildCardMatch("abc", "???")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "?", IsWildCardMatch("abc", "?")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "*", IsWildCardMatch("abc", "*")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "ab*d", IsWildCardMatch("abc", "ab*d")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "aa", "a", IsWildCardMatch("aa", "a")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcd", "*c", IsWildCardMatch("abcd", "*c")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abcd", "a?", IsWildCardMatch("abcd", "a?")));
            Console.WriteLine(string.Format("String: {0}  :::  Pattern: {1}   ===> {2}", "abc", "abcd", IsWildCardMatch("abc", "abcd")));

            //var res = IsWildCardMatch("axyb", "a*b");
            //Console.WriteLine(res);
        }

        private bool IsWildCardMatch(string str, string ptn)
        {
            var res = false;

            int strCount = 0;
            int ptnCount = 0;
            bool isAfterStar = false;
            var stringValue = "";
            var ptnValue = "";
            while (strCount <= str.Length - 1)
            {
                stringValue = str.Substring(strCount, 1);
                ptnValue = (ptn.Length > ptnCount) ? ptn.Substring(ptnCount, 1) : ptnValue == "*" ? ptnValue : "-1";
                if (ptnValue == "*")
                {
                    res = true;
                    isAfterStar = true;
                    strCount++;
                    ptnCount++;
                }
                else if (isAfterStar)
                {
                    if (stringValue == ptnValue || ptnValue == "?")
                    {
                        isAfterStar = false;
                        strCount++;
                        ptnCount++;
                    }
                    else
                    {
                        strCount++;
                    }
                }
                else
                {
                    if (stringValue == ptnValue || ptnValue == "?")
                    {
                        res = true;
                        strCount++;
                        ptnCount++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return res;
        }

        public bool IsMatch(string s, string p)
        {
            var dp = new bool[s.Length + 1, p.Length + 1];
            dp[0, 0] = true;

            for (int j = 0; j < p.Length; j++)
            {
                if (p[j] == '*')
                {
                    dp[0, j + 1] = dp[0, j];
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (s[i] == p[j])
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }
                    else
                    {
                        if (p[j] == '?')
                        {
                            dp[i + 1, j + 1] = dp[i, j];
                        }
                        else if (p[j] == '*')
                        {
                            dp[i + 1, j + 1] = dp[i + 1, j] || dp[i, j + 1];
                        }
                        else
                        {
                            dp[i + 1, j + 1] = false;
                        }
                    }
                }
            }

            return dp[s.Length, p.Length];
        }

        private bool isWildCardMatch(string s, string p)
        {
            char[] str = s.ToCharArray();
            char[] pattern = p.ToCharArray();

            int writeIndex = 0;
            bool isFirst = true;

            for(int i = 0;i<pattern.Length; i++)
            {
                if(pattern[i] == '*')
                {
                    if (isFirst)
                    {
                        pattern[writeIndex++] = pattern[i];
                        isFirst = false;
                    }
                }
                else
                {
                    pattern[writeIndex++] = pattern[i];
                    isFirst = false;
                }
            }

            bool[,] T = new bool[str.Length+1, writeIndex+1];
            if(writeIndex > 0 && pattern[0] == '*')
            {
                T[0, 1] = true;
            }
            T[0, 0] = true;

            for(int i=1; i<str.Length; i++)
            {
                for(int j=1; j< pattern.Length; j++)
                {
                    if(pattern[j-1] == '?' || str[i-1] == pattern[j - 1])
                    {
                        T[i, j] = T[i - 1, j - 1];
                    }
                    else if(pattern[j-1] == '*')
                    {
                        T[i, j] = T[i - 1, j] || T[i, j - 1];
                    }
                }
            }

            return T[str.Length, writeIndex];
        }

        private void AllIpsCombinationOfInput_Click(object sender, EventArgs e)
        {
            var res = AllIPsCombinations("2562561234");
            res.ForEach(Console.WriteLine);
        }

        private List<string> AllIPsCombinations(string input)
        {
            List<string> res = new List<string>();
            for(int i=1; i <= 3; i++)
            {
                for(int j=1; j<= 3; j++)
                {
                    for(int k=1; k<=3; k++)
                    {
                        string first = input.Substring(0, i);
                        string second = input.Substring(i, j);
                        string third = input.Substring(i+j, k);
                        string remaining = input.Substring(i+j+k);
                        res.Add(first + "."+ second + "." + third + "." + remaining);
                    }
                }
            }
            return res;
        }

        private void SpliStringToArray_Click(object sender, EventArgs e)
        {
            string str = "Hi. Welcome  To our class";
            var afterSplit = str.Split(' ');

            var aa = afterSplit;
        }

        private void LongestWordInAString_Click(object sender, EventArgs e)
        {
            Console.WriteLine(LongestWord(Console.ReadLine()));
        }

        private string LongestWord(string sen)
        {
            StringBuilder sb = new StringBuilder();
            string existingWord = "";
            foreach (char c in sen)
            {
                if (c.ToString() == " " || c.ToString() == "&" || c.ToString() == "!")
                {
                    existingWord = sb.Length > existingWord.Length ? sb.ToString() : existingWord;
                    sb = new StringBuilder();
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.Length > existingWord.Length ? sb.ToString() : existingWord;
        }

        private void IsomorphicString_Click(object sender, EventArgs e)
        {
            string str1 = "PAPER";
            string str2 = "TIXLE";

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("False");
                return;
            }
            Hashtable hash = new Hashtable();
            for(int i=0; i<str1.Length-1; i++)
            {
                char key = str1[i];
                char value = str2[i];
                if (hash.ContainsKey(key))
                {
                    if (hash[key].ToString() != value.ToString())
                    {
                        Console.WriteLine("False");
                        return;
                    }
                }
                else
                {
                    hash.Add(key, value);
                }
            }
            Console.WriteLine("True");
        }

        private void ReArrangeString_Click(object sender, EventArgs e)
        {
            string input = "aabbb";
            var res = RearrangeChars(input);
            Console.WriteLine(res);
        }

        private string RearrangeChars(string inputx)
        {
            StringBuilder input = new StringBuilder(inputx);
            int len = input.Length;
            string curr = "";
            string prev = "";
            int i = 1;
            bool isContinue = true;

            while (isContinue)
            {
                curr = input[i].ToString();
                prev = input[i - 1].ToString();
                
                if (curr == prev)
                {
                    if (i == len)
                    {
                        i = -1;
                    }
                    int x = -1;
                    for (x = i + 1; x < len; x++)
                    {
                        if (curr != input[x].ToString())
                        {
                            input[i] = input[x];
                            input[x] = (char)curr[0];
                            break;
                        }
                        else if(i == len)
                        {
                            return "";
                        }
                    }
                }
                else if (i == len - 1)
                {
                    isContinue = false;
                }
                i++;
            }
            return input.ToString();
        }

        private void RemoveDuplicatesFromString_Click(object sender, EventArgs e)
        {
            var str = RemoveDup("errormean");
            Console.WriteLine(str);
        }
        private string RemoveDup(string str)
        {
            string newStr = "";
            str = new string(str.OrderBy(x => x).ToArray());
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    newStr += str[i];
                }
            }
            newStr += str[str.Length - 1];
            return newStr;
        }

        private string RemoveDupFromString1(string[] str)
        {
            int len = str.Length;
            int tail = 1;
            for (int i =1; i < len; ++i)
            {
                int j;
                for(j=0; j<tail; ++j)
                {
                    if(str[j] == str[i])
                    {
                        break;
                    }
                }

                if (j == tail)
                {
                    str[tail] = str[i];
                    ++tail;
                }
                str[tail] = "0";
            }
            
            return str.ToString();
        }

        private void SplitDocToChunkOfStrings_Click(object sender, EventArgs e)
        {
            string doc = "aa:b:ccccccc:ddd:e:ff";
            var res = ChunkOfStrings(doc, 5);
        }

        private List<string> ChunkOfStrings(string doc, int x)
        {
            string[] list = doc.Split(':');
            List<string> output = new List<string>();
            string prev = list[0] + ":";

            for (int i = 1; i < list.Length; i++)
            {
                if (prev.Length >= x)
                {
                    output.Add(prev);
                    prev = list[i] + ":";
                }
                else
                {
                    string concatStr = prev  + list[i] + ":";
                    if (concatStr.Length > x)
                    {
                        output.Add(prev);
                        prev = list[i] + ":";
                    }
                    else
                    {
                        prev = concatStr;
                    }
                }
            }
            if (prev.Length > 0)
                output.Add(prev);
            return output;
            
        }

        private void ConvertStringToIntWithoutnbuilt_Click(object sender, EventArgs e)
        {
            Console.Clear();
            var input = Console.ReadLine();
            var res = GetInt(input);
            Console.WriteLine(res);
        }
        private int GetInt(string str)
        {
            int[] intArr = new int[str.Length];
            int i = 0; int retValue = 0;
            foreach (char c in str)
            {
                int baseValue = 48;
                int charVal = (int)c;
                if (charVal >= 48 && charVal <= 57)
                {
                    intArr[i] = charVal - baseValue;
                    i++;
                }
                else
                    return -1;
            }
            int counter = 1;
            foreach (int val in intArr)
            {
                retValue = retValue + (val * counter);
                counter *= 10;
            }
            return retValue;
        }

        private void DisplayLast3Products_Click(object sender, EventArgs e)
        {
            Dictionary<string, DateTime> keyValue = new Dictionary<string, DateTime>();
            GetUserInput(keyValue);
        }

        private void GetUserInput(Dictionary<string, DateTime> keyValue)
        {
            var input = Console.ReadLine();
            
            var result = InsertToQueue(keyValue, input);
            PrintQueue(result);
        }

        private void PrintQueue(Dictionary<string, DateTime> keyValue)
        {
            Console.WriteLine();
            var sortedList = keyValue.OrderBy(x => x.Value);
            foreach(var item in sortedList)
            {
                Console.Write(item.Key + " | " + item.Value + " |$| ");
            }
            Console.WriteLine();
            GetUserInput(keyValue);
        }

        private Dictionary<string, DateTime> InsertToQueue(Dictionary<string, DateTime> keyValue, string input)
        {
            if(keyValue.Count() >= 3)
            {
                if(keyValue.ContainsKey(input))
                {
                    keyValue[input] = DateTime.Now;
                }
                else
                {
                    var oldestElement = keyValue.OrderBy(x => x.Value).FirstOrDefault();
                    var oldestKey = oldestElement.Key;
                    keyValue.Remove(oldestKey);
                    keyValue.Add(input, DateTime.Now);
                }
            }
            else
            {
                if (keyValue.ContainsKey(input))
                {
                    keyValue[input] = DateTime.Now;
                }
                else
                {
                    keyValue.Add(input, DateTime.Now);
                }
            }
            return keyValue;
        }

        private void ValidateExpression_Click(object sender, EventArgs e)
        {
            Console.WriteLine("The Input Expression: ");
            var exp = Console.ReadLine();
            Console.WriteLine(GetValidateExpression(exp));
        }

        private bool GetValidateExpression(string exp)
        {
            if (exp.Length == 1)
                return true;
            else if (exp.Length == 0)
                return false;

            Stack<char> stack = new Stack<char>();
            char curr = exp[1];
            char prev = exp[0];

            if (IsOpeningBracket(prev))
                stack.Push(prev);

            if (IsArithmetic(prev) || IsClosingBracket(prev))
                return false;

            for(int i=1; i<exp.Length; i++)
            {
                curr = exp[i];
                prev = exp[i - 1];

                if(IsAlpha(curr))
                {
                    if (IsAlpha(prev) || IsNumeric(prev))
                        return false;
                }
                else if(IsArithmetic(curr))
                {
                    if (IsArithmetic(prev) || IsOpeningBracket(prev))
                        return false;
                }
                else if(IsOpeningBracket(curr))
                {
                    if (IsAlpha(prev) || IsNumeric(prev) || IsClosingBracket(prev))
                        return false;
                    stack.Push(curr);
                }
                else if (IsClosingBracket(curr))
                {
                    if (IsArithmetic(prev))
                        return false;
                    if (curr != GetMatch(stack.Pop()))
                        return false;
                }
                if(i == exp.Length-1)
                {
                    if (IsArithmetic(curr) || IsOpeningBracket(curr))
                        return false;
                }
            }
            
            return stack.Count() == 0;
        }

        private bool IsAlpha(char c)
        {
            int cValue = (int)c;
            if ((cValue >= 65 && cValue <= 90) || (cValue >= 97 & cValue <= 122))
                return true;
            return false;
        }
        private bool IsNumeric(char n)
        {
            int nValue = (int)n;
            if (nValue >= 48 && nValue <= 57)
                return true;
            return false;
        }

        private bool IsArithmetic(char a)
        {
            if (a == '+' || a == '-' || a == '*' || a == '%' || a == '/')
                return true;
            return false;
        }

        private bool IsOpeningBracket(char a)
        {
            if (a == '{' || a == '(' || a == '[')
                return true;
            return false;
        }

        private bool IsClosingBracket(char a)
        {
            if (a == '}' || a == ')' || a == ']')
                return true;
            return false;
        }

        private char GetMatch(char c)
        {
            switch(c)
            {
                case '{':
                    return '}';
                case '(':
                    return ')';
                case '[':
                    return ']';
                default:
                    return char.MinValue;
            }
        }

        private void WordBreak_Click(object sender, EventArgs e)
        {
            string s1 = "CATSANDOG";
            List<string> list = new List<string>() { "CAT", "AND", "CATS", "DOG", "SAND" };
            var res1 = WordBreakWithDict(s1, list);
            string s2 = "CATSANDDOG";
            var res2 = WordBreakWithDict(s2, list);

            Console.WriteLine("Input is " + s1 + " -- " + res1);
            Console.WriteLine("Input is " + s2 + " -- " + res2);
        }

        private bool WordBreakWithDict(string s, IList<string> wordDict)
        {
            // https://dotnetfiddle.net/o7mczN
            if (wordDict.Contains(s))
                return true;

            var reducedList = wordDict.Where(x => x.StartsWith(s[0].ToString()));
            foreach(string word in reducedList)
            {
                return WordBreakWithDict(s.Substring(word.Length), wordDict);
            }
            return false;
        }

        // Full working solution
        public bool WordBreakComplete(string s, IList<string> wordDict, IList<string> map)
        {
            if (wordDict.Contains(s))
                return true;
            if (map.Contains(s))
                return false;

            foreach (string word in wordDict)
            {
                if (s.StartsWith(word))
                {
                    return WordBreakComplete(s.Substring(word.Length), wordDict, map);
                }
            }
            map.Add(s);
            return false;
        }

        private void MysteryFunctionPrg_Click(object sender, EventArgs e)
        {
            Person p01 = new Person("01", new Person[] { });
            Person p02 = new Person("02", new Person[] { p01 });
            Person p03 = new Person("03", new Person[] { p02 });
            p03 = new Person("04", new Person[] { p03 });
            Person[] perArr = new Person[3];
            perArr[0] = p01;
            perArr[1] = p02;
            perArr[2] = p03;

            Person p = new Person("raj", perArr);
            var res = p.MysteryFunction1("01");
            var res2 = res;
        }

        private void IncrementDecrementFunction_Click(object sender, EventArgs e)
        {
            MakeTheNumbersMatch(1, 1, 2, 3);
        }

        public static void MakeTheNumbersMatch(int a, int b, int x, int y)
        {
            while(a != x || b != y)
            {
                if (a != x)
                {
                    if (a < x)
                    {
                        a++;
                    }
                    else
                    {
                        a--;
                    }
                }

                if(b != y)
                {
                    if (b < y)
                    {
                        b++;
                    }
                    else
                    {
                        b--;
                    }
                }
            }
        }

        private void ReverseTheSentence_Click(object sender, EventArgs e)
        {
            string input = "hello world ";
            string output = StringReverseWithIndex(input); ;

        }

        private string StringReverseWithIndex(string str)
        {
            char[] charArray = str.ToCharArray();
            var reversedArr = StringReverseWithStartEnd(charArray, 0, charArray.Length-1);

            int start = 0;
            int end = 0;

            for(int i=0; i<reversedArr.Length;i++)
            {
                if(str[i] == ' ' || i == reversedArr.Length-1)
                {
                    reversedArr = StringReverseWithStartEnd(reversedArr, start, end);
                    start = end + 2;
                }
                end++;
            }
            return new string(reversedArr);
        }

        private char[] stringReverse(char[] charArr, int startIndex, int length)
        {
            for(int i=startIndex; i< length; i++)
            {
                var temp = charArr[i];
                charArr[i] = charArr[startIndex + length - 1];
                charArr[startIndex + length - 1] = temp;
                length--;
            }
            return charArr;
        }

        private char[] StringReverseWithStartEnd(char[] arr, int start, int end)
        {
            while(start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }

        private void PrintWordsInString_Click(object sender, EventArgs e)
        {
            string str = "Hello This Is My World";
            int n = 3;
            PrintWordsV2(str, 3);
            //var res = PrintWords(str, n);
            //res.ForEach(Console.WriteLine);
        }

        private List<string> PrintWords(string str, int n)
        {
            List<string> output = new List<string>();
            
            string[] arr = str.Split(' ');
            for(int i=0; i<arr.Length-n+1; i++)
            {
                string temp = "";
                for(int j=0; j<n; j++)
                {
                    if(i+j < arr.Length)
                        temp += arr[i+j] + " ";
                }
                output.Add(temp.Trim());
            }
            return output;
        }

        private void PrintWordsV2(string str, int n)
        {
            string[] arr = str.Split(' ');
            for(int i =0; i<arr.Length-n+1; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if(i+j<arr.Length)
                    {
                        Console.Write(arr[i + j] + " ");
                    }
                }
                Console.WriteLine("");
            }

        }

        private void FindLongestPalindrome_Click(object sender, EventArgs e)
        {
            var x = GetLongestPalindrome("google");
        }

        private string GetLongestPalindrome(string str)
        {
            int len = str.Length-1;
            string maxStr = "", currStr = "";
            int maxLen = 0, currLen = 0;

            for (int i = 0; i < len; i++)
            {
                currStr = ExpandForPalindrome(str, i, i);
                currLen = currStr.Length;

                if (currLen > maxLen)
                {
                    maxStr = currStr;
                    maxLen = currLen;
                }

                currStr = ExpandForPalindrome(str, i, i + 1);
                currLen = currStr.Length;

                if (currLen > maxLen)
                {
                    maxStr = currStr;
                    maxLen = currLen;
                }
            }
            return maxStr;
        }

        private string ExpandForPalindrome(string str, int low, int high)
        {
            int len = str.Length;
            string palindrome = "";
            while (low >= 0 && high < len && str[low] == str[high])
            {
                palindrome = str.Substring(low, high - low + 1);
                low--;
                high++;
            }
            return palindrome;
        }

        private void LongestNonRepeatedSubstring_Click(object sender, EventArgs e)
        {
            var res1 = NonRepeatedSubstring("abccdefgh");
            var res2 = NonRepeatedSubstring("abccdefghhres");
        }

        private string NonRepeatedSubstring(string str)
        {
            if (str == null || str.Length <= 1)
                return str;

            Dictionary<char, char> list = new Dictionary<char, char>();
            string subStr = "";
            StringBuilder sbTemp = new StringBuilder();

            foreach (char c in str)
            {
                if (list.ContainsKey(c))
                {
                    if (subStr.Length <= sbTemp.Length)
                        subStr = sbTemp.ToString();
                    list.Clear();
                    sbTemp.Clear();
                }
                list.Add(c, c);
                sbTemp.Append(c);
            }
            if (subStr.Length <= sbTemp.Length)
                subStr = sbTemp.ToString(); ;

            return subStr;
        }

        private void ReverseWordsInSentence_Click(object sender, EventArgs e)
        {
            var res = ReverseWordsInSentenceFn("The quick brown fox jumped over the lazy dog.");
            Console.WriteLine(res);
        }

        private string ReverseWordsInSentenceFn(string input)
        {
            // "Hello You There"
            string reversed = Reverse(input, 0, input.Length-1);
            string[] arr = reversed.Split(' ');
            string retValue = "";
            foreach (string str in arr)
            {
                retValue = retValue + Reverse(str, 0, str.Length - 1) + " ";
            }
            return retValue;
        }

        private string Reverse(string str, int start, int end)
        {
            var arr = str.ToCharArray();
            while (start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return new String(arr);
        }

        private void RemoveDuplicates_Click(object sender, EventArgs e)
        {
            string str = "errormean";
            Console.WriteLine(RemoveDupes(str));
        }

        private string RemoveDupes(string str)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<char, char> list = new Dictionary<char, char>();
            foreach (char c in str)
            {
                if (!list.ContainsKey(c))
                {
                    list.Add(c, c);
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void RemoveWhiteSpaces_Click(object sender, EventArgs e)
        {
            string str = " e r  ror mean                     !";
            Console.WriteLine(RemoveSpaces(str));
            
        }

        private string RemoveSpaces(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c != ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        private void StringSegmentationWithDictionary_Click(object sender, EventArgs e)
        {
            var dictionary = new List<string> { "I", "have", "Jain", "Sumit", "am", "this", "dog" };
            string str = "IamSumit";
            WordBreak2(dictionary, str);
        }

        private void WordBreak2(List<string> list, string str)
        {
            if (list == null || list.Count <= 0 || string.IsNullOrEmpty(str))
                Console.WriteLine("Cannot segment the string");
            else
            {
                if(!Find(list, str, ""))
                    Console.WriteLine("Cannot segment the string");
            }
        }

        private bool Find(List<string> list, string str, string ans)
        {
            if(str.Length == 0)
            {
                Console.WriteLine(ans);
                return true;
            }

            int index = 0;
            string word = "";

            while(index < str.Length)
            {
                word += str[index];
                if (list.Contains(word))
                {
                    if (Find(list, str.Substring(index + 1), ans + word + " "))
                    {
                        return true;
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                    index++;
            }
            return false;
        }

        private void FindAllPossiblePalindromes_Click(object sender, EventArgs e)
        {
            AllPossiblePalindrome("google");
        }

        private void AllPossiblePalindrome(string str)
        {
            List<string> list = new List<string>();
            for (int i = 0; i< str.Length; i++)
            {
                ExpandForAllPalndromes(str, i, i, list);
                ExpandForAllPalndromes(str, i, i+1, list);
            }
            list.ForEach(Console.WriteLine);
        }

        private List<string> ExpandForAllPalndromes(string str, int low, int high, List<string> list)
        {
            while(low >=0 && high < str.Length && str[low] == str[high])
            {
                string palindrome = str.Substring(low, high - low + 1);
                if (!list.Contains(palindrome))
                    list.Add(palindrome);
                low--;
                high++;
            }
            return list;
        }
    }

    public class Person
    {
        public string Name;
        public Person[] Acquaintances;

        public Person(string name, Person[] acquaintances)
        {
            if(string.IsNullOrWhiteSpace( name ))
            {
                throw new ArgumentException("Name cannot be null or white space.", "name");
            }
            this.Name = name;
            this.Acquaintances = acquaintances;
        }

        public bool MysteryFunction1(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or white space.", "name");
            }

            Stack<Person> myStack = new Stack<Person>();
            foreach(Person acquaintance in Acquaintances)
            {
                myStack.Push(acquaintance);
            }

            do
            {
                var person = myStack.Pop();
                if(person.Name.Equals(name))
                {
                    return true;
                }

                foreach(Person acquaintance in person.Acquaintances)
                {
                    myStack.Push(acquaintance);
                }
            } while (myStack.Count >= 0);

            return false;
        }

        // If the input name doesn't match with any values in myStack and when stack becomes empty, another iteration goes inside do-while loop and when tries to Pop, Exception is thrown
        // If the input name matches with any of the name values in myStack, then returned true
        // 

        // Update the do-while loop to check the Count > 0 (replace "myStack.Count >= 0" with  "myStack.Count > 0")
        // Do null check for "Acquaintances". If the "Acquaintances" value is null, the forach loop to go through all the  "Acquaintances" will fail
        // Rename MysteryFunction1 with appropriate name

        // Positive Testcases:
        // 

    }
}
