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
    public partial class EPUser : Form
    {
        SqlConnection conection = new SqlConnection("Data Source=" + File.ReadAllText("Docs\\ServName.txt") + ";Initial Catalog=WaflesJuice;Integrated Security=True");

        #region CargaForma-----------------------------------------------------------
        public EPUser()
        {
            InitializeComponent();
            lbl_hi.Text = "Hi, " + UserData.NombreUs + "!";

            CargaD();
        }
        #endregion

        #region OK-------------------------------------------------------------------
        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                SqlCommand com = new SqlCommand("spAcDatos", conection);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@UserOr", SqlDbType.Int).Value = UserData.UserId;
                com.Parameters.Add("@UserID", SqlDbType.Int).Value = UserData.UserCambio;
                com.Parameters.Add("@UserPass", SqlDbType.VarChar, 255).Value = txt_pass.Text;
                com.Parameters.Add("@UserType", SqlDbType.Int).Value = int.Parse(txt_Type.Text);
                com.Parameters.Add("@UserName", SqlDbType.VarChar, 255).Value = txt_Name.Text;
                com.Parameters.Add("@UserEmail", SqlDbType.VarChar, 255).Value = txt_Email.Text;
                com.ExecuteNonQuery();

                conection.Close();
                notifyIcon1.ShowBalloonTip(100, "Information", "was updated correctly", ToolTipIcon.Info);
                MessageBox.Show("All information was updated correctly", "Updated", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred, check that all information is in correct type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }
        #endregion

        #region PassRandom-----------------------------------------------------------
        private void btn_randompass_Click(object sender, EventArgs e)
        {
            conection.Open();
            SqlCommand com = new SqlCommand("spRPass", conection);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@idResponsable", SqlDbType.Int).Value = UserData.UserId;
            com.Parameters.Add("@idResetear", SqlDbType.Int).Value = int.Parse(txt_id.Text);

            com.Parameters.Add("@nuevaContra", SqlDbType.VarChar, 255).Value = "";
            com.Parameters["@nuevaContra"].Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();

            string NewPass = com.Parameters["@nuevaContra"].Value.ToString();

            conection.Close();

            CargaD();

            MessageBox.Show("Password has been generated and changed correctly.", "Completed", MessageBoxButtons.OK,MessageBoxIcon.Information);
            txt_pass.Text = NewPass;
            
        }
        #endregion

        #region CargarDatos----------------------------------------------------------
        private void CargaD()
        {
            conection.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = conection;
                command.CommandText = "select * from Users where UserId = @idusee";
                command.Parameters.AddWithValue("@idusee", UserData.UserCambio);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_id.Text = reader.GetInt32(0).ToString();
                        txt_pass.Text = reader.GetString(1);
                        txt_Type.Text = reader.GetInt32(2).ToString();
                        txt_Name.Text = reader.GetString(3);
                        txt_Email.Text = reader.GetString(4);
                    }

                }
            }
            conection.Close();
        }
        #endregion
    }
}
