using System;
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
    public partial class MS : Form
    {
        string[] Ones = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "tweleve", "thirteen",
                "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        string[] Tens = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
        string[] Thousands = new string[] { "", "Thousand", "Million", "Billion", };

        public MS()
        {
            InitializeComponent();
        }

        private void CarNumberAndPenalty_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.Write("Input Date: ");
            var date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Format("Penalty collected for date {0} is {1}", date.ToString(), PenaltyCollected(date)));
            Console.WriteLine("");
            Console.WriteLine("");
        }

        private int PenaltyCollected(int date)
        {
            int[] carNumbers = new int[] { 2375, 7682, 2325, 2352 };
            int[] penalties = new int[] { 250, 500, 350, 200 };
            int sum = 0;
            bool isOdd = date % 2 == 1;
            for (int i = 0; i < carNumbers.Length; i++)
            {
                if((carNumbers[i] % 2 == 1) != isOdd)
                    sum += penalties[i];
            }
            return sum;
        }

        private void SumOfTwoNumbersInArrayEqualExpected_Click(object sender, EventArgs e)
        {
            Console.Clear();
            var aa = SumOfTwoNumbersEqualsExpected();
        }

        private bool SumOfTwoNumbersEqualsExpected()
        {
            int[] input = new int[] { 4, 17, 5, 6, 9, 10, 15 };
            int expected = 17;
            
            for (int i = 0; i < input.Length - 2; i++)
            {
                for (int j = i + 1; j < input.Length - 1; j++)
                {
                    if (input[i] + input[j] == expected)
                    {
                        Console.WriteLine(string.Format("Index {0} with Value {1} and Index {2} with value {3} forms {4}", i, input[i], j, input[j], expected));
                        return true;
                    }
                }
            }
            Console.WriteLine("Number doesn't match with expected");
            return false;
        }

        private void BinaryNumberDivisibleBy3_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Input the Binary Number");
            var input = Console.ReadLine();
            var res = IsBinaryNumberDivisbleBy3(input);
            Console.WriteLine(string.Format("Input Binary number {0} is divisable by 3 is {1}", input, res));
        }

        private bool IsBinaryNumberDivisbleBy3(string input)
        {
            int counter = 0;
            for (int i = 1; i <= input.Length; i++)
            {
                if (i % 2 == 1 && input[i-1] == '1')
                    counter++;
                else if (i % 2 == 0 && input[i-1] == '1')
                    counter--;
            }
            if (counter == 0 || counter % 3 == 0)
                return true;

            return false;
        }

        private void NumberToWords_Click(object sender, EventArgs e)
        {
            Console.Clear();
            var res = CalculateNumber(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(res);
        }

        private string CalculateNumber(int n)
        {
            string s = "";
            s += GetString((n / 100000)%100, "Lakh");
            s += GetString((n / 1000)%100, "Thousand");
            s += GetString((n / 100)%10, "Hundred");
            s += GetString(n % 100, " ");
            return s;
        }
        
        private string GetString(int n, string s)
        {
            string str = "";
            if (n > 0)
            {
                if (n > 19)
                {
                    str = Tens[n / 10] + " " + Ones[n % 10] + " " + s + " ";
                }
                else
                {
                    str = Ones[n] + " " + s + " ";
                }
            }
            
            return str;
        }

        private void PrintNumberToWordsUS_Click(object sender, EventArgs e)
        {
            var a = ConvertToString(65544321);
            Console.WriteLine(a);
        }

        private string Helper(int n)
        {
            if (n == 0)
                return "";
            else if (n < 20)
                return Ones[n] + " ";
            else if (n < 100)
                return Tens[n/10] + " " + Helper(n%10);
            else
                return Ones[n / 100] + " Hundred " + Helper(n % 100);
        }

        private string ConvertToString(int num)
        {
            if (num == 0)
                return "Zero";

            string s = "";
            int i = 0;
            while (num > 0)
            {
                if(num % 1000 != 0)
                    s = Helper(num % 1000) + Thousands[i] + " " + s;
                num /= 1000;
                i++;
            }

            return s;
        }


        
    }
}
