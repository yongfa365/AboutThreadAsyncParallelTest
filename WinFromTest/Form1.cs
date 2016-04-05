using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFromTest
{
    public partial class Form1 : Form
    {
        private int _MinWorkThreads = 0;
        private int _MinCompletionPortThreads = 0;
        private int _DefaultConnectionLimit = 0;

        private static object objlock = new object();
        private static decimal HasCount = 100;
        private static void Opt()
        {
            lock (objlock)
            {
                HasCount--;
            }
        }

        public Form1()
        {
            InitializeComponent();
            ThreadPool.GetMinThreads(out _MinWorkThreads, out _MinCompletionPortThreads);
            _DefaultConnectionLimit = ServicePointManager.DefaultConnectionLimit;

            FillEnv();
        }

        private void FillEnv()
        {
            lblSourceEnv.Text = $"Default:DefaultConnectionLimit:{_DefaultConnectionLimit}    MinWorkThreads:{_MinWorkThreads}    MinCompletionPortThreads:{_MinCompletionPortThreads}";

            int _minworkthreads, _mincompletionportthreads;
            ThreadPool.GetMinThreads(out _minworkthreads, out _mincompletionportthreads);
            lblNowEnv.Text = $"    Now:DefaultConnectionLimit:{ServicePointManager.DefaultConnectionLimit}    MinWorkThreads:{_minworkthreads}    MinCompletionPortThreads:{_mincompletionportthreads}";
        }

        private void btnSaveMin_Click(object sender, EventArgs e)
        {
            ThreadPool.SetMinThreads((int)numMinWorkThreads.Value, (int)numMinCompletionPortThreads.Value);
            ServicePointManager.DefaultConnectionLimit = (int)numDefaultConnectionLimit.Value;
            FillEnv();
        }



        private void btnSync_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now + "\tStart");
            HasCount = numTotal.Value;
            var startTime = DateTime.Now;
            for (int i = 0; i < numTotal.Value; i++)
            {
                var timer = DateTime.Now;
                var aaa = new WebClient().DownloadString(txtUrl.Text);
                Opt();
                Console.WriteLine($"HasCount:{HasCount}\t ThreadID:{Thread.CurrentThread.ManagedThreadId}\t 它耗时：{DateTime.Now - timer} 从开始：{DateTime.Now - startTime}  ok {aaa.Length}");
            };

        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now + "\tStart");
            HasCount = numTotal.Value;
            var startTime = DateTime.Now;
            Parallel.For(0, (int)numTotal.Value, new ParallelOptions { MaxDegreeOfParallelism = 100 }, i =>
              {
                  var timer = DateTime.Now;
                  var aaa = new WebClient().DownloadString(txtUrl.Text);
                  Opt();
                  Console.WriteLine($"HasCount:{HasCount}\t ThreadID:{Thread.CurrentThread.ManagedThreadId}\t 它耗时：{DateTime.Now - timer} 从开始：{DateTime.Now - startTime}  ok {aaa.Length}");
              });

        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now + "\tStart");
            HasCount = numTotal.Value;

            var startTime = DateTime.Now;
            for (var i = 0; i < numTotal.Value; i++)
            {
                AsyncTest2(i, startTime);
            }
        }
        private async void AsyncTest2(int i, DateTime startTime)
        {

            var timer = DateTime.Now;
            var client = new HttpClient();
            var aaa = await client.GetStringAsync(txtUrl.Text);
            Opt();
            Console.WriteLine($"HasCount:{HasCount}\t ThreadID:{Thread.CurrentThread.ManagedThreadId}\t 它耗时：{DateTime.Now - timer} 从开始：{DateTime.Now - startTime}  ok {aaa}");

        }

        private void btnSetServer_Click(object sender, EventArgs e)
        {
            var aaa = new WebClient().DownloadString(txtServerUrl.Text);
            MessageBox.Show(aaa);
        }
    }
}
