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
    public partial class _04_News : Form
    {
        public _04_News()
        {
            InitializeComponent();
            label5.Text = "¡Welcome! \n" + UserData.NombreUs;
        }

        #region BarraSup----------------------------------------------------------------------------------------------------
        private void btn_library_Click(object sender, EventArgs e)
        {
            this.Close();
            _02_Library fmslibra = new _02_Library();
            fmslibra.Show();
        }

        private void btn_comunnity_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fmsfor = new Form1();
            fmsfor.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Close();
            _03_Search fmsse = new _03_Search();
            fmsse.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {

            Changelog chang = new Changelog();
            chang.Show();
        }
        #endregion

        private void _04_News_Load(object sender, EventArgs e)
        {

        }

        private void _04_News_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update upd = new Update();
            upd.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
