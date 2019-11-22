using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProgramGenerator
{
    public partial class RandomProgramGenerator : Form
    {

        public RandomProgramGenerator()
        {
            InitializeComponent();
        }

        private void Array_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var res = pbm.GetArrayProblems();
            int x = GetRandom(res.Length - 1);
            label1.Text = res[x];
        }

        private int GetRandom(int x)
        {
            Random r = new Random();
            int nextInt = r.Next(0, x);
            return nextInt;
        }

        private void BinaryTree_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var res = pbm.GetBinaryTreeProblems();
            int x = GetRandom(res.Length - 1);
            label1.Text = res[x];
        }

        private void LinkedLists_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var res = pbm.GetLinkedListProblems();
            int x = GetRandom(res.Length - 1);
            label1.Text = res[x];
        }

        private void Matrix_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var res = pbm.GetMatrixProblems();
            int x = GetRandom(res.Length - 1);
            label1.Text = res[x];
        }

        private void Number_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var res = pbm.GetNumbersProblems();
            int x = GetRandom(res.Length - 1);
            label1.Text = res[x];
        }

        private void Recursion_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var res = pbm.GetRecursionProblems();
            int x = GetRandom(res.Length - 1);
            label1.Text = res[x];
        }

        private void String_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var res = pbm.GetStringProblems();
            int x = GetRandom(res.Length - 1);
            label1.Text = res[x];
        }

        private void All_Click(object sender, EventArgs e)
        {
            AllProblems pbm = new AllProblems();
            var arr = pbm.GetArrayProblems();
            var bt = pbm.GetBinaryTreeProblems();
            var ll = pbm.GetLinkedListProblems();
            var mx = pbm.GetMatrixProblems();
            var nm = pbm.GetNumbersProblems();
            var rec = pbm.GetRecursionProblems();
            var str = pbm.GetStringProblems();

            var list = new List<string>();
            list.AddRange(arr);
            list.AddRange(bt);
            list.AddRange(ll);
            list.AddRange(mx);
            list.AddRange(nm);
            list.AddRange(rec);
            list.AddRange(str);

            int x = GetRandom(list.Count - 1);
            label1.Text = list[x];
        }
    }
}
