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

namespace ByCompany
{
    public partial class AZ : Form
    {
        public AZ()
        {
            InitializeComponent();
        }

        private void PermutationOfCharsInaString_Click(object sender, EventArgs e)
        {
            string input = "abcxyzbacdfhdskjfcabguesdcba";
            string pattern = "abc";
            List<string> hash = FindPermutation(pattern);
            Hashtable reducedHash = new Hashtable();
            List<string> result = new List<string>();
            foreach(string str in hash)
            {
                var tempKey = CalcHash(str);
                if (!reducedHash.ContainsKey(tempKey))
                    reducedHash.Add(tempKey, str);
            }

            for(int i=0; i<input.Length-2; i++)
            {
                var subStr = input.Substring(i, 3);
                var returnedHash = CalcHash(subStr);
                if(reducedHash.ContainsKey(returnedHash))
                {
                    result.Add(subStr);
                }
            }
            result.ForEach(Console.WriteLine);
        }

        private List<string> FindPermutation(string input)
        {
            List<string> list = new List<string>();
            return Permutation("", input, list);
        }

       private List<string> Permutation(string prefix, string word, List<string> list)
        {
            if(word.Length == 0)
            {
                list.Add(prefix);
            }
            else
            {
                for(int i=0; i < word.Length; i++)
                {
                    Permutation(prefix + word[i], word.Substring(0, i) + word.Substring(i + 1, word.Length - (i + 1)), list);
                }
            }
            return list;
        }

        private int CalcHash(string str)
        {
            int s1, s2, s3;
            s1 = GetMappedHashCode(str[0].ToString());
            s2 = GetMappedHashCode(str[1].ToString());
            s3 = GetMappedHashCode(str[2].ToString());

            var res = s1 + s2 * Math.Pow(3, 0) + s3 * Math.Pow(3, 1);
            return Convert.ToInt32(res);
        }

        private int GetMappedHashCode(string s)
        {
            switch(s.ToUpper())
            {
                case "A":
                    return 1;
                case "B":
                    return 2;
                case "C":
                    return 3;
                case "D":
                    return 4;
                case "E":
                    return 5;
                case "F":
                    return 6;
                case "G":
                    return 7;
                case "H":
                    return 8;
                case "I":
                    return 9;
                default:
                    return 10;
            }
        }

        private void CountNumberOfIslands_Click(object sender, EventArgs e)
        {
            //int[,] input = { { 1, 1, 1, 1, 0 }, { 1, 1, 0, 1, 0}, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] input = { { 1, 1, 0, 0, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 1 } };
            PrintMatrix(input);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            int isLandCount = 0;

            for(int row = 0; row<input.GetLength(0); row++)
            {
                for(int col = 0; col < input.GetLength(1); col++)
                {
                    if(input[row, col] == 1)
                    {
                        isLandCount += 1;
                        LoopThroughIsLand(input, row, col);
                    }
                }
            }

            Console.WriteLine("Number Of Islands: " + isLandCount);
        }

        private void LoopThroughIsLand(int[,] input, int row, int col)
        {
            int newRow = input.GetLength(0);
            int newColumn = input.GetLength(1);

            if(row < 0 || col < 0 || row >= newRow || col >= newColumn || input[row, col] == 0)
            {
                return;
            }

            input[row, col] = 0;
            //LoopThroughIsLand(input, row - 1, col);
            //LoopThroughIsLand(input, row + 1, col);
            //LoopThroughIsLand(input, row, col - 1);
            //LoopThroughIsLand(input, row, col + 1);
            //LoopThroughIsLand(input, row+1, col + 1); // This is for including diagonal
            //LoopThroughIsLand(input, row - 1, col - 1); // This is for including diagonal

            for (int r = row-1; r<=row+1; r++)
            {
                for(int c  = col-1; c<=col+1; c++)
                {
                    if(r != row && c!= col)
                    {
                        LoopThroughIsLand(input, r, c);
                    }
                }
            }
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

        private void CountMaxAreaOfIsland_Click(object sender, EventArgs e)
        {
            //int[,] input = { { 1, 1, 1, 1, 0 }, { 1, 1, 0, 1, 0}, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] input = { { 1, 1, 0, 0, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 1 } };
            PrintMatrix(input);
            AreaOfIsLands(input);
        }

        private void AreaOfIsLands(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            int size = 0;

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    if (matrix[r, c] == 1)
                    {

                        //LoopThroughIsLand(matrix, r, c);
                        int curr = GetSize(matrix, r, c);
                        size = Math.Max(size, curr);
                    }
                }
            }
            Console.WriteLine("Max IsLand Size is " + size);
        }

        private int GetSize(int[,] m, int r, int c)
        {
            if (r < 0 || c < 0 || r >= m.GetLength(0) || c >= m.GetLength(1) || m[r, c] == 0)
            {
                return 0;
            }
            m[r, c] = 0;
            int size = 1;
            for (int r1 = r - 1; r1 <= r + 1; r1++)
            {
                for (int c1 = c-1; c1 <= c + 1; c1++)
                {
                    if (r1 != r || c1 != c)
                    {
                        size += GetSize(m, r1, c1);
                    }
                }
            }
            return size;
        }

        private void CategorizeAndSort_Click(object sender, EventArgs e)
        {
            string[] input = new string[5];
            input[0] = "1235 7901 6321 4232";
            input[1] = "d204 Z643 A234 Q435";
            input[2] = "ZACD DECA ZCFX DBEF";
            input[3] = "ZACD BECA ZCFX DBEF";
            input[4] = "0234 6321  7901   4232";

            var res = CategorizeData(input);
            var finalResult = (res.OrderBy(x => x.CategoryValue.GetHashCode())).ThenBy(y => y.SecondWord).ToList();
            finalResult.ForEach(Console.WriteLine);
        }

        private List<Data> CategorizeData(string[] input)
        {
            var CategorizedData = new List<Data>();
            foreach(var str in input)
            {
                var processedData = ProcessData(str);
                CategorizedData.Add(processedData);
            }

            return CategorizedData;
        }

        private Data ProcessData(string str)
        {
            var processedData = new Data();
            var category = GetCategory(str);
            var secondValue = GetSecondValue(str);
            processedData.Original = str;
            processedData.SecondWord = secondValue;
            processedData.CategoryValue = category;
            return processedData;
        }

        private Category GetCategory(string str)
        {
            str = str.Replace(" ", "");
            List<string> categoryList = new List<string>();
            foreach(char c in str)
            {
                int charValue = (int)c;
                if(charValue >= 48 && charValue <= 57)
                {
                    if (!categoryList.Contains("Numeric"))
                    {
                        categoryList.Add("Numeric");
                    }
                }
                else
                {
                    if (!categoryList.Contains("String"))
                    {
                        categoryList.Add("String");
                    }
                }

                if(categoryList.Count() > 1)
                {
                    return Category.AlphaNumeric;
                }
            }

            if (categoryList[0] == "Numeric")
                return Category.Numeric;
            else
                return Category.Alphabetic;
        }

        private string GetSecondValue(string str)
        {
            string[] splitValues = str.Split(' ');
            bool isNextIsSecond = false;
            string retValue = "";
            foreach(string val in splitValues)
            {
                if(val != " " && !isNextIsSecond)
                {
                    isNextIsSecond = !isNextIsSecond;
                }
                else if (val != " " && isNextIsSecond)
                {
                    return val;
                }
            }
            return retValue;
        }
    }

    public class Data
    {
        public string Original;
        public string SecondWord;
        public Category CategoryValue;
    }

    public enum Category
    {
        Alphabetic = 1,
        Numeric = 2,
        AlphaNumeric = 3
    }
}
