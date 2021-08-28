using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toshokan_Project_Beta
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();

        }
        private int a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            a = 1;
            progressBar1.Value = 0;
            timer1.Start();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool flag = a == 1;
            if (flag)
            {
                this.progressBar1.Increment(1);
                bool flag2 = this.progressBar1.Value == 1;
                if (flag2)
                {
                    textBox1.Text="Validating Information";
                }
                bool flag3 = this.progressBar1.Value == 30;
                if (flag3)
                {
                    textBox1.Text = "Connecting to the Server";
                }
                bool flag4 = this.progressBar1.Value == 60;
                if (flag4)
                {
                    textBox1.Text = "Checking for Updates";
                }
                bool flag5 = this.progressBar1.Value == 90;
                if (flag5)
                {

                    textBox1.Text = "Validating files";
                }
                bool flag6 = this.progressBar1.Value == 100;
                if (flag6)
                {
                    this.timer1.Stop();
                    textBox1.Text = "";
                    notifyIcon1.ShowBalloonTip(100, "Updated system", "You are in the latest version!", ToolTipIcon.Info);
                    MessageBox.Show("The program is in the latest version available:)", "Updated system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
