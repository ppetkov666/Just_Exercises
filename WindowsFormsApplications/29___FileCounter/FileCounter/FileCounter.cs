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

namespace FileCounter
{

    public partial class FileCounter : Form
    {
        public FileCounter()
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

        private async void btn_start_Click(object sender, EventArgs e)
        {

            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            lbl_count.Text = "You Request is processing. Please wait...";
            int countedChars = await (task);
            lbl_count.Text = countedChars.ToString() + " characters in the file!";
        }
    }
}
