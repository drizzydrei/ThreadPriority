using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread ThreadA, ThreadB, ThreadC, ThreadD;
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart start2 = new ThreadStart(MyThreadClass.Thread2);
            ThreadA = new Thread(start);
            ThreadB = new Thread(start2);
            ThreadC = new Thread(start);
            ThreadD = new Thread(start2);

            Console.WriteLine(label1.Text.ToString());
            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";
            ThreadC.Name = "Thread C";
            ThreadD.Name = "Thread D";
            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;
            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();
            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();
            

            label1.Text = "-End of thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
