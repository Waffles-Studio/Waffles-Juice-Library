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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(UserData.conexion);

        private void Logs_Load(object sender, EventArgs e)
        {
            conexion.Open();
            SqlDataAdapter daCarga = new SqlDataAdapter("SELECT *FROM Binnacle", conexion);
            DataSet dsCarga = new DataSet();
            daCarga.Fill(dsCarga, "Binnacle");
            dataGridView1.DataSource = dsCarga;
            dataGridView1.DataMember = "Binnacle";

            conexion.Close();
        }
    }
}
