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
    public partial class DynamicProgramming : Form
    {
        public DynamicProgramming()
        {
            InitializeComponent();
        }

        private void PossibleWaysToDecodeADigit_Click(object sender, EventArgs e)
        {
            // This problem was asked by Facebook.
            // Given the mapping a = 1, b = 2, ... z = 26, and an encoded message, count the number of ways it can be decoded.
            // For example, the message '111' would give 3, since it could be decoded as 'aaa', 'ka', and 'ak'.
            // You can assume that the messages are decodable. For example, '001' is not allowed.
            var x = CountPossibeWaysToDecodeDigit("241");
        }

        private int CountPossibeWaysToDecodeDigit(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int[] dpAry = new int[str.Length+1];
            dpAry[0] = 1; //dp[0] means an empty string will have one way to decode
            dpAry[1] = str[0] == '0' ? 0 : 1; // dp[1] means the way to decode a string of size 1

            for(int i = 2; i <= str.Length; i++)
            {
                int first = Convert.ToInt32(str.Substring(i - 1, 1));
                int second = Convert.ToInt32(str.Substring(i - 2, 2));

                if(first >= 1 && first <= 9)
                {
                    dpAry[i] += dpAry[i - 1];
                }

                if(second >= 10 && second <= 26)
                {
                    dpAry[i] += dpAry[i - 2];
                }
            }

            return dpAry[str.Length];

        }

        private void UniquePathsFromStartToEnd_Click(object sender, EventArgs e)
        {
            // https://leetcode.com/problems/unique-paths/
            /*
             The assumptions are

                When (n==0||m==0) the function always returns 1 since the robot
                can't go left or up.
                For all other cells. The result = uniquePaths(m-1,n)+uniquePaths(m,n-1)
                Therefore I populated the edges with 1 first and use DP to get the full 2-D array.

                Please give any suggestions on improving the code.
             */

            var x = FindUniquePathsFromStartToEnd(7, 3);
        }

        private int FindUniquePathsFromStartToEnd(int m, int n)
        {
            if (m == 0 || n == 0)
                return 0;

            if (m == 1 || n == 1)
                return 1;

            int[] dpAry = new int[n];
            for (int i = 0; i < n; i++)
                dpAry[i] = 1;

            for(int i = 1; i < m; i++)
                for(int j = 1; j < n; j++)
                {
                    dpAry[j] += dpAry[j - 1]; 
                }

            return dpAry[n-1];
        }
    }

    // https://leetcode.com/problems/climbing-stairs/
    // https://leetcode.com/problems/fibonacci-number/
}
