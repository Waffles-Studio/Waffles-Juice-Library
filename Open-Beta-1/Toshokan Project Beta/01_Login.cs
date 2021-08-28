using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Toshokan_Project_Beta
{
    public partial class Home : Form
    {


        #region START----------------------------------------------------------------------------------------------

        


        public Home()
        {
            InitializeComponent();
            panel_login.SendToBack();
            panel_login.Visible = false;
            panel1.Enabled = false;

            panel_start.Visible = true;
            panel_login.BringToFront();

            txt_servername.Text = File.ReadAllText("Docs\\ServName.txt");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #endregion
        
        #region LOGIN----------------------------------------------------------------------------------------------
        private void btn_login_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
            panel_login.Visible = true;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            panel_login.SendToBack();
            panel_login.Visible = false;
            txt_username.Text = "";
            txt_pass.Text = "";
            panel_start.Visible = true;
            panel_login.BringToFront();
        }
        #endregion

        #region ServerName-----------------------------------------------------------------------------------------
        private void txt_servername_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tempurl = "Docs\\ServName.txt";
            string serv = txt_servername.Text;
            File.WriteAllText(tempurl, serv);

            if (File.ReadAllText(tempurl) == serv)
            {
                notifyIcon1.ShowBalloonTip(100, "Something changed", "The server changed correctly " + UserData.NombreUs, ToolTipIcon.Info);
            }
            else
            {
                notifyIcon1.ShowBalloonTip(100, "Sorry", "No server change " + UserData.NombreUs, ToolTipIcon.Info);
            }
        }
        #endregion

        #region MISSCLICK------------------------------------------------------------------------------------------
        private void label8_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        #endregion

        #region REGISTRARSE----------------------------------------------------------------------------------------
        private void btn_register_Click(object sender, EventArgs e)
        {
            NewUser nw = new NewUser();
            nw.Show();
        }


        #endregion

        #region  Coneccion------------------------------------------------------------------------------------------
        private void btn_log_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conection = new SqlConnection("Data Source=" + File.ReadAllText("Docs\\ServName.txt") + ";Initial Catalog=WaflesJuice;Integrated Security=True");

                conection.Open();
                SqlCommand com = new SqlCommand("spLogueo", conection);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@UserName", SqlDbType.VarChar, 255).Value = txt_username.Text;
                com.Parameters.Add("@UserPassword", SqlDbType.VarChar, 255).Value = txt_pass.Text;

                com.Parameters.Add("@UserId", SqlDbType.Int).Value = 0;
                com.Parameters["@UserId"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@UserType", SqlDbType.Int).Value = 0;
                com.Parameters["@UserType"].Direction = ParameterDirection.Output;

                com.Parameters.Add("@Status", SqlDbType.Bit).Value = false;
                com.Parameters["@Status"].Direction = ParameterDirection.Output;

                com.ExecuteNonQuery();


                bool status = bool.Parse(com.Parameters["@Status"].Value.ToString());
                int TipoU = int.Parse(com.Parameters["@UserType"].Value.ToString());
                
                if (status == true)
                {
                    using (var command = new SqlCommand())
                    {
                        command.Connection = conection;
                        command.CommandText = "select *from Users where UserName=@user and UserPassword=@pass";
                        command.Parameters.AddWithValue("@user", txt_username.Text);
                        command.Parameters.AddWithValue("@pass", txt_pass.Text);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserData.UserId = reader.GetInt32(0);
                                UserData.UserPassword = reader.GetString(1);
                                UserData.UserTipo = reader.GetInt32(2);
                                UserData.NombreUs = reader.GetString(3);
                                UserData.mail = reader.GetString(4);

                                UserData.conexion = "Data Source=" + File.ReadAllText("Docs\\ServName.txt") + ";Initial Catalog=WaflesJuice;Integrated Security=True";
                            }
                        }
                        //Notificacion
                        notifyIcon1.ShowBalloonTip(100,"Welcome!",""+UserData.NombreUs,ToolTipIcon.Info);
                    }
                    conection.Close();
                    Program.form1.Hide();
                    _02_Library Librar = new _02_Library();
                    Librar.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("I fail everything that could fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public bool LLenar(string user, string pass)
        {
            SqlConnection conection = new SqlConnection("Data Source=" + File.ReadAllText("Docs\\ServName.txt") + ";Initial Catalog=WaflesJuice;Integrated Security=True");

            conection.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = conection;
                command.CommandText = "select *from Users where UserName=@user and UserPassword=@pass";
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserData.UserId = reader.GetInt32(0);
                        UserData.UserPassword = reader.GetString(1);
                        UserData.UserTipo = reader.GetInt32(2);
                        UserData.NombreUs = reader.GetString(3);
                        UserData.mail = reader.GetString(4);

                        UserData.conexion = "Data Source=" + File.ReadAllText("Docs\\ServName.txt") + ";Initial Catalog=WaflesJuice;Integrated Security=True";
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
