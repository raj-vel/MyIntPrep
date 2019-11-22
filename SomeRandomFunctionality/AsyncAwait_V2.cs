using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeRandomFunctionality
{
    public partial class AsyncAwait_V2 : Form
    {
        public string str = "";
        public AsyncAwait_V2()
        {
            InitializeComponent();
        }

        private async void AsyncAwaitDebug_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            str += "Step 1 - Starting" + Environment.NewLine;
            await GetTheTaskDone();
            str += "Step Final - Ending" + Environment.NewLine;
            label1.Text = str;
        }

        public async Task GetTheTaskDone()
        {
            str += "Step 2 - Before the task starts" + Environment.NewLine;
            await TimeDealy();
            str += "Step 5 - Before the task Ends" + Environment.NewLine;
        }

        public async Task TimeDealy()
        {
            str += "Step 3 - Before the time delay" + Environment.NewLine;
            await Task.Delay(10000);
            str += "Step 4 - After the time delay" + Environment.NewLine;
        }
    }
}
