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
    public partial class _02_Library : Form
    {
        public _02_Library()
        {
            InitializeComponent();
            label5.Text = "¡Welcome! \n" + UserData.NombreUs;
        }

        #region BarraSup----------------------------------------------------------------------------------------------------
        private void btn_comunnity_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 comunniity = new Form1();
            comunniity.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Close();
            _03_Search frmsear = new _03_Search();
            frmsear.Show();

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
                MessageBox.Show("Sorry, only administrators can enter to this section" , "ㄟ( ▔, ▔ )ㄏ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            this.Close();
            _06_About fmsabou = new _06_About();
            fmsabou.Show();
        }
        #endregion

        private void _02_Library_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void _02_Library_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void _02_Library_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }



        #region Libros
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserData.Path = @"Books\GuiaParaEntenderAlGato.pdf";
            notifyIcon1.ShowBalloonTip(100, "Now Reading", "Guia para entender al gato", ToolTipIcon.Info);
            VPdf verel = new VPdf();
            verel.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UserData.Path = @"Books\Lamusi.pdf";
            notifyIcon1.ShowBalloonTip(100, "Now Reading", "La musica en latinoamerica", ToolTipIcon.Info);
            VPdf verel = new VPdf();
            verel.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UserData.Path = @"Books\libro_rojo.pdf";
            notifyIcon1.ShowBalloonTip(100, "Now Reading", "Fauna Silvestre amenazada del Perú", ToolTipIcon.Info);
            VPdf verel = new VPdf();
            verel.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            UserData.Path = @"Books\BiodiversidadMarinaTropical.pdf";
            notifyIcon1.ShowBalloonTip(100, "Now Reading", "Biodiversidad Marina Tropical", ToolTipIcon.Info);
            VPdf verel = new VPdf();
            verel.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            UserData.Path = @"Books\Biologicalandecologicaltraitsofmarinespecies.pdf";
            notifyIcon1.ShowBalloonTip(100, "Now Reading", "Biological and ecol-ogical  traits of marine species", ToolTipIcon.Info);
            VPdf verel = new VPdf();
            verel.Show();
        }

        #endregion


    }
}
