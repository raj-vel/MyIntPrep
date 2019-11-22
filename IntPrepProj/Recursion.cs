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
    public partial class Recursion : Form
    {
        public Recursion()
        {
            InitializeComponent();
        }

        private void PhoneNumberAlphabets_Permutation_Click(object sender, EventArgs e)
        {
            var aa = phoneCombination("237");
            aa.ForEach(Console.WriteLine);
        }

        private List<string> phoneCombination(string numbers)
        {
            Hashtable mapping = new Hashtable();
            mapping.Add(2, "ABC");
            mapping.Add(3, "DEF");
            mapping.Add(4, "GHI");
            mapping.Add(5, "JKL");
            mapping.Add(6, "MNO");
            mapping.Add(7, "PQRS");
            mapping.Add(8, "TUV");
            mapping.Add(9, "WXYZ");
            mapping.Add(0, "");
            mapping.Add(1, "");

            List<string> result = new List<string>();
            if(numbers == null || numbers.Length == 0)
            {
                return result;
            }
            List<char> temp = new List<char>();
            BuildCombination(numbers, temp, result, mapping);
            return result;
        }

        private void BuildCombination(string numbers, List<char> temp, List<string> result, Hashtable mapping)
        {
            if(numbers.Length == 0)
            {
                result.Add(new string(temp.ToArray()));
                return;
            }

            int current = Convert.ToInt32(numbers.Substring(0, 1));
            string letters = mapping[current].ToString();
            for(int i=0; i < letters.Length; i++)
            {
                temp.Add(letters[i]);
                BuildCombination(numbers.Substring(1), temp, result, mapping);
                temp.RemoveAt(temp.Count() - 1);
            }
        }

        private void PascalsTriangeRecursive_Click(object sender, EventArgs e)
        {
            Console.Clear();
            int n = Convert.ToInt32(Console.ReadLine());
            // int n = 3;
            for(int i=0; i<n; i++)
            {
                int j = 0;
                while(j <= i)
                {
                    Console.Write(PascalsTriange_Recursive(i, j) + "  ");
                    j++;
                }
                Console.WriteLine(" ");
            }
        }

        private int PascalsTriange_Recursive(int row, int col)
        {
            if (col == 0 || col == row)
                return 1;

            return PascalsTriange_Recursive(row - 1, col - 1) + PascalsTriange_Recursive(row - 1, col);
        }

        private void PredictHorseMove_Click(object sender, EventArgs e)
        {
            string input = "(1 1)(3 2)";
            int a = input[1];
            int b = input[3];

            int x = input[6];
            int y = input[8];

            int calcX = x - a;
            int calcY = y - b;

            var predictedMove = PredictMove(calcX, calcY);
            Console.WriteLine(predictedMove);

        }

        private int PredictMove(int x, int y)
        {
            if (x == 0 || y == 0)
                return 1;

            return PredictMove(x - 1, y) + PredictMove(x, y - 1);
        }

        private void FibonocciTillN_Click(object sender, EventArgs e)
        {
            Fib(0, 1, 1, 8);
        }

        private void Fib(int a, int b, int counter, int len)
        {
            if (counter < len)
            {
                Console.WriteLine(a);
                Fib(b, a + b, counter + 1, len);
            }
        }

        private void NthFibbonaciNumber_Click(object sender, EventArgs e)
        {
            var res = NthFibbonaci(6);
            Console.WriteLine($"The 6th Fibbonaci number id {res}");
        }

        private int NthFibbonaci(int n)
        {
            if (n <= 1)
                return n;
            return NthFibbonaci(n - 1) + NthFibbonaci(n - 2);
        }


    }
}
