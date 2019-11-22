using SomeRandomFunctionality.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace SomeRandomFunctionality
{
    public partial class AsyncAwait : Form
    {
        public AsyncAwait()
        {
            InitializeComponent();
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();
            resultLabel.Text = "";

            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            resultLabel.Text += $"{ data.websiteURL } downloaded: { data.websiteData.Length } characters long.{ Environment.NewLine }";
        }

        // Sync Code - start
        private void button1_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            RunDownloadSync();

            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            resultLabel.Text += $"Total Execution Time: { elapsedTime }";
        }

        private void RunDownloadSync()
        {
            List<string> websites = PrepData();
            foreach (var site in websites)
            {
                WebsiteDataModel res = DownloadWebsite(site);
                ReportWebsiteInfo(res);
            }
        }

        private WebsiteDataModel DownloadWebsite(string url)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.websiteURL = url;
            output.websiteData = client.DownloadString(url);

            return output;
        }

        // Sync Code - End

        private async void button2_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await RunDownloadASync();

            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            resultLabel.Text += $"Total Execution Time: { elapsedTime }";
        }

        private async Task RunDownloadASync()
        {
            List<string> websites = PrepData();
            foreach (var site in websites)
            {
                WebsiteDataModel res = await Task.Run(() => DownloadWebsiteAsync(site));
                ReportWebsiteInfo(res);
            }
        }

        private async Task RunDownloadParallelASync()
        {
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (var site in websites)
            {
                tasks.Add(DownloadWebsiteAsync(site));
            }

            var results = await Task.WhenAll(tasks);
            foreach (var item in results)
            {
                ReportWebsiteInfo(item);
            }
        }


        private async Task<WebsiteDataModel> DownloadWebsiteAsync(string url)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.websiteURL = url;
            output.websiteData = await client.DownloadStringTaskAsync(url);

            return output;
        }

        private async void AsyncAwaitParallel_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await RunDownloadParallelASync();

            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            resultLabel.Text += $"Total Execution Time: { elapsedTime }";
        }

        private async void StepByStepPrintOfAsyncAwait_Click(object sender, EventArgs e)
        {
            WriteOutput("Program Begin");
            DoAsync();
            WriteOutput("Program Complete");
        }

        private static void WriteOutput(string message)
        {
            Console.WriteLine("[{0}] {1}", Thread.CurrentThread.ManagedThreadId, message);
            //lblAsyncAwaitPrint.Text += message + "<br/>";
        }

        private int DoSomethingThatTakesLongTime()
        {
            WriteOutput("A--Started Something");
            Thread.Sleep(1000);
            WriteOutput("B--Finished Something");
            return -1;
        }
        private async Task DoAsync()
        {
            WriteOutput("1--Starting");
            var t = Task.Factory.StartNew<int>(DoSomethingThatTakesLongTime);
            WriteOutput("2--Task Started");
            var result = await t;
            WriteOutput($"3--Task Completed with result - {result}");
        }


    }
}
