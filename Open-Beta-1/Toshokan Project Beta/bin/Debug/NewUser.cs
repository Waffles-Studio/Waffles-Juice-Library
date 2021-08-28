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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        SqlConnection conection = new SqlConnection("Data Source=" + File.ReadAllText("Docs\\ServName.txt") + ";Initial Catalog=WaflesJuice;Integrated Security=True");

        #region NewUsuario-----------------------------------------------------------------------------------
        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                SqlCommand com = new SqlCommand("spAltaUsuarios", conection);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@UsuarioAlta", SqlDbType.VarChar, 255).Value = txt_name.Text;
                com.Parameters.Add("@Contra", SqlDbType.VarChar, 255).Value = txt_pass.Text;
                com.Parameters.Add("@Email", SqlDbType.VarChar, 255).Value = txt_email.Text;
                com.ExecuteNonQuery();

                conection.Close();

                MessageBox.Show("The user has been added correctly", "All right", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error adding the user, check that the user does not exist and that your data is correct.", "Failed everything that could fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
        #endregion
    }
}
