using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Toshokan_Project_Beta
{
    public partial class SeUser : Form
    {
        public SeUser()
        {
            InitializeComponent();
            CTAB();
        }
        SqlConnection conexion = new SqlConnection(UserData.conexion);

        public void CTAB()
        {
            conexion.Open();
            SqlDataAdapter daCarga = new SqlDataAdapter("SELECT UserId, UserName FROM Users", conexion);
            DataSet dsCarga = new DataSet();
            daCarga.Fill(dsCarga, "Users");
            dataGridView1.DataSource = dsCarga;
            dataGridView1.DataMember = "Users";

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserData.UserCambio = Int32.Parse(textBox1.Text);
                EPUser epu = new EPUser();
                epu.Show();

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("You have to select a user!!!", "Something went wrong....", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var row
            //textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
