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
    public partial class _03_Search : Form
    {
        public _03_Search()
        {
            InitializeComponent();
            label5.Text = "¡Welcome! \n" + UserData.NombreUs;
            radioButton1.Checked = true;
        }

        //coneccion sql 
        SqlConnection conexion = new SqlConnection(UserData.conexion);

        int LibSelect;

        #region BarraSup--------------------------------------------------------------------------------
        private void btn_library_Click(object sender, EventArgs e)
        {
            this.Close();
            _02_Library fmslibra = new _02_Library();
            fmslibra.Show();
        }

        private void btn_comunnity_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fmscom = new Form1();
            fmscom.Show();
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
            _06_About fmsabo = new _06_About();
            fmsabo.Show();

        }
        #endregion

        #region Busqueda--------------------------------------------------------------------------------
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT *FROM Books ORDER BY BookTitle", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();

                }
                if (radioButton2.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT *FROM Books ORDER BY BookAutor", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
                if (radioButton3.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT *FROM Books ORDER BY BookPages", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
                if (radioButton4.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT *FROM Books ORDER BY BookTags", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
                if (radioButton5.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT *FROM Books ORDER BY BookType", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
            }

            if (radioButton6.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT Books.BookId, Books.BookType, Books.BookTitle, Books.BookPages, Books.BookTags, Books.BookAutor FROM Books inner join Favorites on(Books.BookId = Favorites.BookID) where Favorites.UserId = "+UserData.UserId+" ORDER BY Books.BookTitle", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();

                }
                if (radioButton2.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT Books.BookId, Books.BookType, Books.BookTitle, Books.BookPages, Books.BookTags, Books.BookAutor FROM Books inner join Favorites on(Books.BookId = Favorites.BookID) where Favorites.UserId = " + UserData.UserId + " ORDER BY BookAutor", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
                if (radioButton3.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT Books.BookId, Books.BookType, Books.BookTitle, Books.BookPages, Books.BookTags, Books.BookAutor FROM Books inner join Favorites on(Books.BookId = Favorites.BookID) where Favorites.UserId = " + UserData.UserId + " ORDER BY BookPages", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
                if (radioButton4.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT Books.BookId, Books.BookType, Books.BookTitle, Books.BookPages, Books.BookTags, Books.BookAutor FROM Books inner join Favorites on(Books.BookId = Favorites.BookID) where Favorites.UserId = " + UserData.UserId + " ORDER BY BookTags", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
                if (radioButton5.Checked == true)
                {
                    conexion.Open();
                    SqlDataAdapter daCarga = new SqlDataAdapter("SELECT Books.BookId, Books.BookType, Books.BookTitle, Books.BookPages, Books.BookTags, Books.BookAutor FROM Books inner join Favorites on(Books.BookId = Favorites.BookID) where Favorites.UserId = " + UserData.UserId + " ORDER BY BookType", conexion);
                    DataSet dsCarga = new DataSet();
                    daCarga.Fill(dsCarga, "Books");
                    dataGridView1.DataSource = dsCarga;
                    dataGridView1.DataMember = "Books";

                    conexion.Close();
                }
            }


        }
        #endregion

        #region Resetbusqueda---------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlDataAdapter daCarga = new SqlDataAdapter("SELECT *FROM Books", conexion);
            DataSet dsCarga = new DataSet();
            daCarga.Fill(dsCarga, "Books");
            dataGridView1.DataSource = dsCarga;
            dataGridView1.DataMember = "Books";

            conexion.Close();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton10.Checked = false;
            radioButton9.Checked = true;
        }
        #endregion

        #region SeleccionarLibro------------------------------------------------------------------------
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                LibSelect = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
            }
            
        }
        #endregion

        #region Añadir/Eliminar favorito----------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand com = new SqlCommand("spAddFavorite", conexion);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@idLibro", SqlDbType.Int).Value = LibSelect;
            com.Parameters.Add("@idUsuario", SqlDbType.Int).Value = UserData.UserId;
            com.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Action performed correctly", "Thank you ;)", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        #endregion

        #region MissClick-------------------------------------------------------------------------------
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void _03_Search_Load(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
        }

        private void _03_Search_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
