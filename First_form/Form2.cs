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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult= fontDialog1.ShowDialog();
            if(dialogResult==DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

    }
}
