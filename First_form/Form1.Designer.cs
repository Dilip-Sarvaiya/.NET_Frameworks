namespace First_form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.chk_first = new System.Windows.Forms.CheckBox();
            this.chk_second = new System.Windows.Forms.CheckBox();
            this.chk_third = new System.Windows.Forms.CheckBox();
            this.chk_forth = new System.Windows.Forms.CheckBox();
            this.first_List = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.set_use = new System.Windows.Forms.Label();
            this.srt_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.clr_item = new System.Windows.Forms.Button();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Submit.Location = new System.Drawing.Point(276, 381);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 40);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.AccessibleName = "";
            this.username_txt.Location = new System.Drawing.Point(287, 183);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(150, 22);
            this.username_txt.TabIndex = 2;
            this.username_txt.Text = "Enter the Username";
            this.username_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.username_txt_KeyUp);
            this.username_txt.MouseHover += new System.EventHandler(this.username_txt_MouseHover);
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdb_Male.Location = new System.Drawing.Point(61, 40);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(59, 21);
            this.rdb_Male.TabIndex = 3;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            this.rdb_Male.CheckedChanged += new System.EventHandler(this.rdb_Male_CheckedChanged);
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdb_female.Location = new System.Drawing.Point(222, 40);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(75, 21);
            this.rdb_female.TabIndex = 4;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "Female";
            this.rdb_female.UseVisualStyleBackColor = true;
            this.rdb_female.CheckedChanged += new System.EventHandler(this.rdb_female_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.rdb_Male);
            this.Gender.Controls.Add(this.rdb_female);
            this.Gender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gender.Location = new System.Drawing.Point(155, 272);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(391, 103);
            this.Gender.TabIndex = 5;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // chk_first
            // 
            this.chk_first.AutoSize = true;
            this.chk_first.Location = new System.Drawing.Point(168, 462);
            this.chk_first.Name = "chk_first";
            this.chk_first.Size = new System.Drawing.Size(89, 21);
            this.chk_first.TabIndex = 6;
            this.chk_first.Text = "First Trial";
            this.chk_first.ThreeState = true;
            this.chk_first.UseVisualStyleBackColor = true;
            this.chk_first.CheckedChanged += new System.EventHandler(this.chk_first_CheckedChanged);
            this.chk_first.CheckStateChanged += new System.EventHandler(this.chk_first_CheckStateChanged);
            // 
            // chk_second
            // 
            this.chk_second.AutoSize = true;
            this.chk_second.Location = new System.Drawing.Point(168, 502);
            this.chk_second.Name = "chk_second";
            this.chk_second.Size = new System.Drawing.Size(110, 21);
            this.chk_second.TabIndex = 7;
            this.chk_second.Text = "Second Trial";
            this.chk_second.UseVisualStyleBackColor = true;
            this.chk_second.CheckedChanged += new System.EventHandler(this.chk_second_CheckedChanged);
            // 
            // chk_third
            // 
            this.chk_third.AutoSize = true;
            this.chk_third.Location = new System.Drawing.Point(168, 544);
            this.chk_third.Name = "chk_third";
            this.chk_third.Size = new System.Drawing.Size(95, 21);
            this.chk_third.TabIndex = 8;
            this.chk_third.Text = "Third Trial";
            this.chk_third.UseVisualStyleBackColor = true;
            this.chk_third.CheckedChanged += new System.EventHandler(this.chk_third_CheckedChanged);
            // 
            // chk_forth
            // 
            this.chk_forth.AutoSize = true;
            this.chk_forth.Location = new System.Drawing.Point(168, 582);
            this.chk_forth.Name = "chk_forth";
            this.chk_forth.Size = new System.Drawing.Size(95, 21);
            this.chk_forth.TabIndex = 9;
            this.chk_forth.Text = "Forth Trial";
            this.chk_forth.UseVisualStyleBackColor = true;
            this.chk_forth.CheckedChanged += new System.EventHandler(this.chk_forth_CheckedChanged);
            // 
            // first_List
            // 
            this.first_List.FormattingEnabled = true;
            this.first_List.ItemHeight = 16;
            this.first_List.Location = new System.Drawing.Point(550, 441);
            this.first_List.Name = "first_List";
            this.first_List.Size = new System.Drawing.Size(193, 164);
            this.first_List.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(586, 104);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 8, 28, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2001, 3, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // set_use
            // 
            this.set_use.AutoSize = true;
            this.set_use.Location = new System.Drawing.Point(174, 233);
            this.set_use.Name = "set_use";
            this.set_use.Size = new System.Drawing.Size(0, 17);
            this.set_use.TabIndex = 12;
            // 
            // srt_btn
            // 
            this.srt_btn.Location = new System.Drawing.Point(361, 462);
            this.srt_btn.Name = "srt_btn";
            this.srt_btn.Size = new System.Drawing.Size(91, 32);
            this.srt_btn.TabIndex = 13;
            this.srt_btn.Text = "Sort";
            this.srt_btn.UseVisualStyleBackColor = true;
            this.srt_btn.Click += new System.EventHandler(this.srt_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(361, 518);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(91, 32);
            this.clr_btn.TabIndex = 14;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // clr_item
            // 
            this.clr_item.Location = new System.Drawing.Point(361, 571);
            this.clr_item.Name = "clr_item";
            this.clr_item.Size = new System.Drawing.Size(91, 32);
            this.clr_item.TabIndex = 15;
            this.clr_item.Text = "Clear Item";
            this.clr_item.UseVisualStyleBackColor = true;
            this.clr_item.Click += new System.EventHandler(this.clr_item_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 630);
            this.Controls.Add(this.clr_item);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.srt_btn);
            this.Controls.Add(this.set_use);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.first_List);
            this.Controls.Add(this.chk_forth);
            this.Controls.Add(this.chk_third);
            this.Controls.Add(this.chk_second);
            this.Controls.Add(this.chk_first);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.CheckBox chk_first;
        private System.Windows.Forms.CheckBox chk_second;
        private System.Windows.Forms.CheckBox chk_third;
        private System.Windows.Forms.CheckBox chk_forth;
        private System.Windows.Forms.ListBox first_List;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label set_use;
        private System.Windows.Forms.Button srt_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button clr_item;
    }
}

