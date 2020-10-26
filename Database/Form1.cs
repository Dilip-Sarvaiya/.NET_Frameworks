using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Second_db.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }
        public void GridDisplay()
        {
            SqlConnection con = new SqlConnection(constring);
            try
            {
                string query = "Select * from [User]";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GridDisplay();  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            try
            {
                string insertquery = "Insert into [User] (name,email,phone) values (@Name,@Email,@Phone)";
                SqlCommand cmd = new SqlCommand(insertquery, con);
                cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Phone", txt_phone.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            GridDisplay();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id_txt.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_email.Text = row.Cells[2].Value.ToString();
            txt_phone.Text = row.Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            try
            {
                string updatequery = "update [User] set name=@Name,email=@Email,phone=@Phone where id= "+Convert.ToInt32(id_txt.Text);
                SqlCommand cmd = new SqlCommand(updatequery, con);
                cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                cmd.Parameters.AddWithValue("@Phone", txt_phone.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            GridDisplay();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            try
            {
                string deletequery = "Delete from [User] where id= "+Convert.ToInt32(id_txt.Text);
                SqlCommand cmd = new SqlCommand(deletequery, con);
               
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            GridDisplay();
        }
    }
}
