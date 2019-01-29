using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cross_Thread_Actions
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            // create a new thread, where i pass to delegate a method who run  the second form 
            

        }

        Second_Form second_form = new Second_Form();
        
        public void TransferText(string text)
        {
            // this is recursive action because we access a control from another thread and must be invoked 
            if (second_form.tb_textbox_input_second.InvokeRequired)
            {
                second_form.tb_textbox_input_second.Invoke((MethodInvoker)delegate ()
               {
                   TransferText(text);
               });
            }
            else
            {
                second_form.tb_textbox_input_second.Text = text;
            }
        }

        public void CloseForm()
        {
            if (second_form.tb_textbox_input_second.InvokeRequired)
            {
                second_form.tb_textbox_input_second.Invoke((MethodInvoker)delegate ()
                {
                    CloseForm();
                });
            }
            else
            {
                second_form.Hide();

            }
        }

        public void OpenForm()
        {
            if (second_form.tb_textbox_input_second.InvokeRequired)
            {
                second_form.tb_textbox_input_second.Invoke((MethodInvoker)delegate ()
                {
                    OpenForm();
                });
            }
            else
            {
                second_form.tb_textbox_input_second.Text = String.Empty;
                second_form.Show();
            }
        }

        private void Btn_send_text_Click(object sender, EventArgs e)
        {
            TransferText(tb_textbox_input.Text);
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        private void btn_open_new_form_Click(object sender, EventArgs e)
        {
            Thread secondFormThread = new Thread(new ThreadStart(StartSecondForm));
            secondFormThread.Start();
        }
        public void StartSecondForm()
        {
            Application.Run(second_form);
        }
    }
}
