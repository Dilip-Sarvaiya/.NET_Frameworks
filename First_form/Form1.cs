using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace First_form
{
    public partial class Form1 : Form
    {
        public static string setval = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            LoadTxtHint();
        }
        private void LoadTxtHint()
        {
            string[] Name5 = { "Dilip", "Bhavesh", "Bhagirath", "Nayna" };
            username_txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            username_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            username_txt.AutoCompleteCustomSource.AddRange(Name5);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //  string message = "Do you want to close this window?";
            //  MessageBox.Show(message, username_txt.Text, buttons);\
            // MessageBox.Show("Welcome " + username_txt.Text);
            string msg = "Form will Submitted...?";
            string caption = "Form Closing";
            var result = MessageBox.Show(msg,caption,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            set_use.Text = username_txt.Text;
            if (result == DialogResult.No)
            {
                this.Dispose();
            }
            else
            {
               // Form2 form2 = new Form2();
                Form2 form2 = new First_form.Form2();
                form2.Show();
                form2.MdiParent = this;
            }
        }
        private void rdb_Male_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }
        private void rdb_female_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = Color.Green;
        }

        private void username_txt_MouseHover(object sender, EventArgs e)
        {
            username_txt.Text = "";
        }

        private void chk_first_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_first.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Trial Button is Cheked now");
                first_List.Items.Add(chk_first.Text);
            }
            else if(chk_first.CheckState==CheckState.Indeterminate)
            {
                MessageBox.Show("Trial Button is in Intermidiate State");
            }
            else
            {
                MessageBox.Show("Trial Button is UnChecked");
                first_List.Items.Remove(chk_first.Text);
            }
        }
        private void chk_first_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Trial button's State is Changed now");
        }

        private void chk_second_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Second Button is Checked");
            
            if (chk_second.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Second Button is Cheked now");
                first_List.Items.Add(chk_second.Text);
            }
            else if (chk_second.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("Second Button is in Intermidiate State");
            }
            else
            {
                MessageBox.Show("Second Button is Checked");
                first_List.Items.Remove(chk_second.Text);
            }
        }

        private void chk_third_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Third button is Checked");
          
            if (chk_third.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Third Button is Cheked now");
                first_List.Items.Add(chk_third.Text);
            }
            else if (chk_third.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("Third Button is in Intermidiate State");
            }
            else
            {
                MessageBox.Show("Third Button is Checked");
                first_List.Items.Remove(chk_third.Text);
            }
        }

        private void chk_forth_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Forth Button is checked");
            if (chk_forth.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Forth Button is Cheked now");
                first_List.Items.Add(chk_forth.Text);
            }
            else if (chk_forth.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("Forth Button is in Intermidiate State");
            }
            else
            {
                MessageBox.Show("Forth Button is Checked");
                first_List.Items.Remove(chk_forth.Text);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
           MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(dateTimePicker1.Value.ToLongTimeString());
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
            MessageBox.Show(dateTimePicker1.Value.Date.AddDays(10).ToString());
          //  Message.Create.ToString(dateTimePicker1.Value);
        }

        private void srt_btn_Click(object sender, EventArgs e)
        {
            first_List.Sorted = true;
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            first_List.Items.Clear();
        }

        private void clr_item_Click(object sender, EventArgs e)
        {
            first_List.Items.Remove(first_List.SelectedItem);
        }

        private void username_txt_KeyUp(object sender, KeyEventArgs e)
        {
            set_use.Text = username_txt.Text;
        }

       
    }
}
