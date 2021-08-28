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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = "¡Welcome! \n" + UserData.NombreUs;
        }

        #region BarraSup----------------------------------------------------------------------------------------------------
        private void btn_library_Click(object sender, EventArgs e)
        {
            this.Close();
            _02_Library fmsLibra = new _02_Library();
            fmsLibra.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Close();
            _03_Search fmssearch = new _03_Search();
            fmssearch.Show();
        }
        private void btn_news_Click(object sender, EventArgs e)
        {
            this.Close();
            _04_News fmsnew = new _04_News();
            fmsnew.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (UserData.UserTipo == 1)
            {
                this.Close();
                _05_Settings fmsnew = new _05_Settings();
                fmsnew.Show();
            }
            else
            {
                MessageBox.Show("Sorry, only administrators can enter to this section", "ㄟ( ▔, ▔ )ㄏ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            this.Close();
            _06_About fmsabou = new _06_About();
            fmsabou.Show();
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
