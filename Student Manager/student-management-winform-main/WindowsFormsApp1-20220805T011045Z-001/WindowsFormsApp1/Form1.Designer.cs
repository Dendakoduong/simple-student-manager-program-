namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.date_of_birth = new System.Windows.Forms.Label();
            this.schoolyear = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.Label();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.year_txtbox = new System.Windows.Forms.TextBox();
            this.phone_txtbox = new System.Windows.Forms.TextBox();
            this.add_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.major_txt = new System.Windows.Forms.Label();
            this.major_txtbox = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.stu_list_txt = new System.Windows.Forms.Label();
            this.listofstudent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.exit_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.associate_btn = new System.Windows.Forms.RadioButton();
            this.bachelor_btn = new System.Windows.Forms.RadioButton();
            this.master_btn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(149, 50);
            this.name_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(216, 22);
            this.name_txtbox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(44, 56);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(89, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Student name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(44, 135);
            this.address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 16);
            this.address.TabIndex = 2;
            this.address.Text = "Address";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(44, 94);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(68, 16);
            this.id.TabIndex = 3;
            this.id.Text = "Student ID";
            // 
            // date_of_birth
            // 
            this.date_of_birth.AutoSize = true;
            this.date_of_birth.Location = new System.Drawing.Point(44, 211);
            this.date_of_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(78, 16);
            this.date_of_birth.TabIndex = 4;
            this.date_of_birth.Text = "Date of birth";
            // 
            // schoolyear
            // 
            this.schoolyear.AutoSize = true;
            this.schoolyear.Location = new System.Drawing.Point(19, 123);
            this.schoolyear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schoolyear.Name = "schoolyear";
            this.schoolyear.Size = new System.Drawing.Size(79, 16);
            this.schoolyear.TabIndex = 8;
            this.schoolyear.Text = "School year";
            // 
            // phone_num
            // 
            this.phone_num.AutoSize = true;
            this.phone_num.Location = new System.Drawing.Point(44, 170);
            this.phone_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(94, 16);
            this.phone_num.TabIndex = 9;
            this.phone_num.Text = "Phone number";
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(148, 88);
            this.id_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(216, 22);
            this.id_txtbox.TabIndex = 10;
            // 
            // year_txtbox
            // 
            this.year_txtbox.Location = new System.Drawing.Point(121, 126);
            this.year_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.year_txtbox.Name = "year_txtbox";
            this.year_txtbox.Size = new System.Drawing.Size(160, 22);
            this.year_txtbox.TabIndex = 13;
            // 
            // phone_txtbox
            // 
            this.phone_txtbox.Location = new System.Drawing.Point(149, 170);
            this.phone_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.phone_txtbox.Name = "phone_txtbox";
            this.phone_txtbox.Size = new System.Drawing.Size(204, 22);
            this.phone_txtbox.TabIndex = 14;
            // 
            // add_txtbox
            // 
            this.add_txtbox.Location = new System.Drawing.Point(148, 129);
            this.add_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.add_txtbox.Name = "add_txtbox";
            this.add_txtbox.Size = new System.Drawing.Size(205, 22);
            this.add_txtbox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(19, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Degree";
            // 
            // major_txt
            // 
            this.major_txt.AutoSize = true;
            this.major_txt.Location = new System.Drawing.Point(19, 86);
            this.major_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.major_txt.Name = "major_txt";
            this.major_txt.Size = new System.Drawing.Size(41, 16);
            this.major_txt.TabIndex = 21;
            this.major_txt.Text = "Major";
            // 
            // major_txtbox
            // 
            this.major_txtbox.FormattingEnabled = true;
            this.major_txtbox.Items.AddRange(new object[] {
            "IT",
            "Marketing",
            "Law"});
            this.major_txtbox.Location = new System.Drawing.Point(121, 86);
            this.major_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.major_txtbox.Name = "major_txtbox";
            this.major_txtbox.Size = new System.Drawing.Size(216, 24);
            this.major_txtbox.TabIndex = 24;
            // 
            // add_btn
            // 
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(20, 24);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(94, 35);
            this.add_btn.TabIndex = 27;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.Add_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Image = ((System.Drawing.Image)(resources.GetObject("remove_btn.Image")));
            this.remove_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove_btn.Location = new System.Drawing.Point(20, 78);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(4);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(94, 35);
            this.remove_btn.TabIndex = 29;
            this.remove_btn.Text = "      Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.Delete_click);
            // 
            // reset_btn
            // 
            this.reset_btn.Image = ((System.Drawing.Image)(resources.GetObject("reset_btn.Image")));
            this.reset_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.Location = new System.Drawing.Point(53, 505);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(94, 35);
            this.reset_btn.TabIndex = 30;
            this.reset_btn.Text = "   Clear all";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_Click);
            // 
            // stu_list_txt
            // 
            this.stu_list_txt.AutoSize = true;
            this.stu_list_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stu_list_txt.Location = new System.Drawing.Point(356, 243);
            this.stu_list_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stu_list_txt.Name = "stu_list_txt";
            this.stu_list_txt.Size = new System.Drawing.Size(125, 20);
            this.stu_list_txt.TabIndex = 31;
            this.stu_list_txt.Text = "List of students";
            // 
            // listofstudent
            // 
            this.listofstudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listofstudent.FullRowSelect = true;
            this.listofstudent.GridLines = true;
            this.listofstudent.HideSelection = false;
            this.listofstudent.Location = new System.Drawing.Point(53, 267);
            this.listofstudent.Margin = new System.Windows.Forms.Padding(4);
            this.listofstudent.Name = "listofstudent";
            this.listofstudent.Size = new System.Drawing.Size(705, 230);
            this.listofstudent.TabIndex = 32;
            this.listofstudent.UseCompatibleStateImageBehavior = false;
            this.listofstudent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of birth";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Year";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 49;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Degree";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 78;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Major";
            this.columnHeader8.Width = 65;
            // 
            // birthday
            // 
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.Location = new System.Drawing.Point(148, 205);
            this.birthday.Margin = new System.Windows.Forms.Padding(4);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(137, 22);
            this.birthday.TabIndex = 33;
            // 
            // exit_btn
            // 
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(801, 7);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(72, 27);
            this.exit_btn.TabIndex = 36;
            this.exit_btn.Text = "Exit";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.Exit_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_btn.Location = new System.Drawing.Point(20, 212);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(94, 35);
            this.search_btn.TabIndex = 35;
            this.search_btn.Text = "   Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.Search_click);
            // 
            // associate_btn
            // 
            this.associate_btn.AutoSize = true;
            this.associate_btn.Location = new System.Drawing.Point(91, 38);
            this.associate_btn.Margin = new System.Windows.Forms.Padding(4);
            this.associate_btn.Name = "associate_btn";
            this.associate_btn.Size = new System.Drawing.Size(88, 20);
            this.associate_btn.TabIndex = 36;
            this.associate_btn.TabStop = true;
            this.associate_btn.Text = "Associate";
            this.associate_btn.UseVisualStyleBackColor = true;
            this.associate_btn.CheckedChanged += new System.EventHandler(this.Check_Associate);
            // 
            // bachelor_btn
            // 
            this.bachelor_btn.AutoSize = true;
            this.bachelor_btn.Location = new System.Drawing.Point(187, 38);
            this.bachelor_btn.Margin = new System.Windows.Forms.Padding(4);
            this.bachelor_btn.Name = "bachelor_btn";
            this.bachelor_btn.Size = new System.Drawing.Size(82, 20);
            this.bachelor_btn.TabIndex = 37;
            this.bachelor_btn.TabStop = true;
            this.bachelor_btn.Text = "Bachelor";
            this.bachelor_btn.UseVisualStyleBackColor = true;
            this.bachelor_btn.CheckedChanged += new System.EventHandler(this.Check_Bachelor);
            // 
            // master_btn
            // 
            this.master_btn.AutoSize = true;
            this.master_btn.Location = new System.Drawing.Point(277, 38);
            this.master_btn.Margin = new System.Windows.Forms.Padding(4);
            this.master_btn.Name = "master_btn";
            this.master_btn.Size = new System.Drawing.Size(69, 20);
            this.master_btn.TabIndex = 38;
            this.master_btn.TabStop = true;
            this.master_btn.Text = "Master";
            this.master_btn.UseVisualStyleBackColor = true;
            this.master_btn.CheckedChanged += new System.EventHandler(this.Check_Master);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_btn);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.remove_btn);
            this.groupBox1.Location = new System.Drawing.Point(759, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 254);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "MANAGE STUDENTS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.associate_btn);
            this.groupBox2.Controls.Add(this.bachelor_btn);
            this.groupBox2.Controls.Add(this.master_btn);
            this.groupBox2.Controls.Add(this.schoolyear);
            this.groupBox2.Controls.Add(this.major_txtbox);
            this.groupBox2.Controls.Add(this.major_txt);
            this.groupBox2.Controls.Add(this.year_txtbox);
            this.groupBox2.Location = new System.Drawing.Point(472, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 175);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Educational details";
            // 
            // logout_btn
            // 
            this.logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("logout_btn.Image")));
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(689, 7);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(79, 27);
            this.logout_btn.TabIndex = 36;
            this.logout_btn.Text = "Log out";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(317, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(895, 777);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listofstudent);
            this.Controls.Add(this.stu_list_txt);
            this.Controls.Add(this.add_txtbox);
            this.Controls.Add(this.phone_txtbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.id);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.name_txtbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Student Management ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label date_of_birth;
        private System.Windows.Forms.Label schoolyear;
        private System.Windows.Forms.Label phone_num;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.TextBox year_txtbox;
        private System.Windows.Forms.TextBox phone_txtbox;
        private System.Windows.Forms.TextBox add_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label major_txt;
        private System.Windows.Forms.ComboBox major_txtbox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label stu_list_txt;
        private System.Windows.Forms.ListView listofstudent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.RadioButton associate_btn;
        private System.Windows.Forms.RadioButton bachelor_btn;
        private System.Windows.Forms.RadioButton master_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

