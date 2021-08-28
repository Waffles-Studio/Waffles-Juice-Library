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
    public partial class _06_About : Form
    {
        public _06_About()
        {
            InitializeComponent();
            label5.Text = "¡Welcome! \n" + UserData.NombreUs;
        }

        #region BarraSup----------------------------------------------------------------------------------------------------
        private void btn_library_Click(object sender, EventArgs e)
        {
            this.Close();
            _02_Library fmsl = new _02_Library();
            fmsl.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_comunnity_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fmsfo = new Form1();
            fmsfo.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Close();
            _03_Search fmsse = new _03_Search();
            fmsse.Show();
        }

        private void btn_news_Click(object sender, EventArgs e)
        {
            this.Close();
            _04_News fmsne = new _04_News();
            fmsne.Show();
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
        #endregion

        private void _06_About_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact information: \n\nEmails: \n182310497@lerdo.tecnm.mx \n182310540@lerdo.tecnm.mx \n182310214@lerdo.tecnm.mx \n\nWhatsapp group: https://chat.whatsapp.com/E13IbtQ9sDtExoX48gygCN", "Team Waffles", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void _06_About_Load(object sender, EventArgs e)
        {

        }
    }
}
