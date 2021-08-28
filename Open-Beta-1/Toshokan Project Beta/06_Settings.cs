using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;

namespace Toshokan_Project_Beta
{
    public partial class _05_Settings : Form
    {
        SqlConnection conexion = new SqlConnection(UserData.conexion);
        public _05_Settings()
        {
            InitializeComponent();
            label5.Text = "¡Welcome! \n"+UserData.NombreUs;
            label3.Text = "User ID: " + UserData.UserId;
            label7.Text = "Type: Admin";
            label8.Text = "User Name: " + UserData.NombreUs;
            label9.Text = "Email: " + UserData.mail;

            UserData.UserCambio = UserData.UserId;
        }

        #region BarraSup----------------------------------------------------------------------------------------------------
        private void btn_library_Click(object sender, EventArgs e)
        {
            this.Close();
            _02_Library fmsl = new _02_Library();
            fmsl.Show();
        }

        private void btn_comunnity_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fmsf = new Form1();
            fmsf.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.Close();
            _03_Search fmss = new _03_Search();
            fmss.Show();
        }

        private void btn_news_Click(object sender, EventArgs e)
        {
            this.Close();
            _04_News fmsn = new _04_News();
            fmsn.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            this.Close();
            _06_About fmsabo = new _06_About();
            fmsabo.Show();
        }
        #endregion

        #region Missclick---------------------------------------------------------------------------------------------------
        private void _05_Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Mostraraforma-----------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Logs logffs = new Logs();
            logffs.Show();
        }
        #endregion

        #region PSeleccionar Usuario----------------------------------------------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {
            SeUser select = new SeUser();
            select.Show();
        }
        #endregion

        #region EncriptarConeccion------------------------------------------------------------------------------------------
        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config;
                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.SectionInformation.ProtectSection(null);
                config.Save();

                MessageBox.Show("Encrypted Connection", "^o^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to encrypt the connection", " p_p", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            

        }
        #endregion

        #region DatosUsuario------------------------------------------------------------------------------------------------
        private void btn_login_Click(object sender, EventArgs e)
        {
            UserData.UserCambio = UserData.UserId;
            EPUser Edu = new EPUser();
            Edu.Show();
        }
        #endregion

        #region CrearBackup-------------------------------------------------------------------------------------------------
        private void btn_BACKUP_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;

            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = folderBrowserDialog1.SelectedPath;
                    GuardarBD(ruta);

                }

            }
            catch (Exception z)
            {
                MessageBox.Show("Error saving the file. \n"+z,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void GuardarBD(string ruta)
        {
            try
            {
                conexion.Open();
                SqlCommand com = new SqlCommand("spBacBD", conexion);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@idUsuario", SqlDbType.Int).Value = UserData.UserId;
                com.Parameters.Add("@directorio", SqlDbType.VarChar, 255).Value = ruta;
                com.ExecuteNonQuery();

                conexion.Close();
                notifyIcon1.ShowBalloonTip(100, "Backup was Generated", "Correctly", ToolTipIcon.Info);

                MessageBox.Show("The backup was generated correctly", "Task completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception z)
            {
                MessageBox.Show("Error saving the file. \n" + z, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


                            
        }
        #endregion

        #region Desaces Cambios
        private void btn_Undo_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand com = new SqlCommand("spRestaurar", conexion);
                com.CommandType = CommandType.StoredProcedure;
                com.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Last change successfully restored", "Task completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception z)
            {
                MessageBox.Show("The last change could not be restored. \n" + z, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
