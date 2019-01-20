using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCunterV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\file_counter.txt"))
            {
                string fullContent = reader.ReadToEnd();
                count = fullContent.Length;
                Thread.Sleep(1000);
            }
            return count;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Invoke();
            });
            thread.Start();
            lbl_count.Text = "You Request is processed. Please wait...";
        }

        private void Invoke()
        {
            int count = CountCharacters();
            // this is the first approach that could be used !
            //Action action = () => lbl_count.Text = count.ToString() + " characters in file";
            Action<int> action = SetProgressBar;
            action += SetLabelText;
            this.BeginInvoke(action, count);
        }

        private void SetLabelText(int counter)
        {
            lbl_count.Text = counter.ToString() + " characters in file";
        }
        private void SetProgressBar(int counter)
        {
            prb_FileCounter.Value = 0;
            prb_FileCounter.Maximum = counter;
            for (int i = 0; i < counter; i++)
            {
                prb_FileCounter.Value += 1;
            }
        }
    }
}
