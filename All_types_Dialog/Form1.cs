using System;
using System.IO;
using System.Windows.Forms;

namespace All_types_Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult dialogResult= colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                label1.ForeColor = colorDialog.Color;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                label1.BackColor = colorDialog.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //FontDialog fontDialog = new FontDialog();
            DialogResult dialogResult = fontDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void user_txt_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = user_txt.Text;
        }

        private void user_txt_MouseHover(object sender, EventArgs e)
        {
            user_txt.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt|Pictures(*.jpg)|*.jpg|PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //file_lbl.Text = openFileDialog1.FileNames;
                foreach (var filename in openFileDialog1.FileNames)
                {
                    file_lbl.Text += "\n" + filename;
                }
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                file_data.Text = streamReader.ReadToEnd();
                streamReader.Dispose();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title="Save your file";
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt|Pictures(*.jpg)|*.jpg|PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 3;
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.Write(file_data.Text);
                streamWriter.Dispose();
                this.Text = saveFileDialog1.FileName;
            }
        
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

         
            //folderBrowserDialog1.ShowDialog();
            //folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folder_path.Text = folderBrowserDialog1.SelectedPath;
                string [] files=Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (var file in files)
                {
                    folder_files.Text += file+" ";
                }
            }
        }

        private void file_data_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(file_data,"Contents of the File");
        }
    }
}
