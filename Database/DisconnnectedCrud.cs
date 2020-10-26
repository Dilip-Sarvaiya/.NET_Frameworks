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
    public partial class DisconnectedCrud : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        DataSet ds;
        DataTable dt;

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Second_db.mdf;Integrated Security=True;Connect Timeout=30";
        
        public DisconnectedCrud()
        {
            InitializeComponent();
        }
        void DataDisplay()
        {
            con = new SqlConnection(constring);
            string insertquery = "select * from [User]";
            cmd = new SqlCommand(insertquery, con);
            adapter = new SqlDataAdapter(cmd);
            commandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds);
            dt = new DataTable();
            dt = ds.Tables[0];

            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            dt.Columns[0].AutoIncrement = true;
            dataGridView2.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constring);
            try {
                //string insertquery = "Insert into [User] (name,email,phone) values (@Name,@Email,@Phone)";
                //cmd = new SqlCommand(insertquery, con);
                //cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                //cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                //cmd.Parameters.AddWithValue("@Phone", txt_phone.Text);
                //adapter.InsertCommand = cmd;

                DataRow dr = dt.NewRow();
                dr[1] = txt_name.Text;
                dr[2] = txt_email.Text;
                dr[3] = txt_phone.Text;
                dt.Rows.Add(dr);

                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataDisplay();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constring);
            try
            {
                //string updatequery = "update [User] set name=@Name,email=@Email,phone=@Phone where id= " + Convert.ToInt32(id_txt.Text);
                //cmd = new SqlCommand(updatequery, con);
                //cmd.Parameters.AddWithValue("@Name", txt_name.Text);
                //cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                //cmd.Parameters.AddWithValue("@Phone", txt_phone.Text);
                //adapter.UpdateCommand = cmd;

                DataRow dr = dt.Rows.Find(id_txt.Text);
                dr[1] = txt_name.Text;
                dr[2] = txt_email.Text;
                dr[3] = txt_phone.Text;
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataDisplay();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(constring);
            try
            {
                //string deletequery = "Delete from [User] where id= " + Convert.ToInt32(id_txt.Text);
                //SqlCommand cmd = new SqlCommand(deletequery, con);
                //adapter.DeleteCommand = cmd;

                DataRow dr = dt.Rows.Find(id_txt.Text);
                dr.Delete();
                adapter.Update(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataDisplay();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
            id_txt.Text = row.Cells[0].Value.ToString();
            txt_name.Text = row.Cells[1].Value.ToString();
            txt_email.Text = row.Cells[2].Value.ToString();
            txt_phone.Text = row.Cells[3].Value.ToString();


        }

        private void btn_bind_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = dt.Rows.Find(id_txt.Text);
                id_txt.Text = row[0].ToString();
                txt_name.Text = row[1].ToString();
                txt_email.Text = row[2].ToString();
                txt_phone.Text = row[3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
