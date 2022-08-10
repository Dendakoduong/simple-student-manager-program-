using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] arr = new string[8];
        string degree;
        ArrayList StudentList = new ArrayList();
        ArrayList Temp = new ArrayList();
            public Form1()
            {
                InitializeComponent();
            }
        public bool checkfield()
        {
            if (string.IsNullOrEmpty(name_txtbox.Text) || string.IsNullOrEmpty(id_txtbox.Text) || string.IsNullOrEmpty(add_txtbox.Text) || string.IsNullOrEmpty(phone_txtbox.Text) || string.IsNullOrEmpty(year_txtbox.Text))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public void UpdateList(ArrayList a)
        {
            ListViewItem itm;
            listofstudent.Items.Clear();
            foreach (Student stu in a)
            {
                arr[0] = stu.ID;
                arr[1] = stu.Name;
                arr[2] = stu.Birthday;
                arr[3] = stu.Address;
                arr[4] = stu.Phone;
                arr[5] = stu.School_year;
                arr[6] = stu.Degree;
                arr[7] = stu.Major;
                itm = new ListViewItem(arr);
                listofstudent.Items.Add(itm);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (checkfield())
            {
                if (name_txtbox.Text != "" && id_txtbox.Text != "" && add_txtbox.Text != "" && phone_txtbox.Text != "" && year_txtbox.Text != "")
                {
                    Student a = new Student(id_txtbox.Text, name_txtbox.Text, birthday.Text, add_txtbox.Text, phone_txtbox.Text, year_txtbox.Text, degree, major_txtbox.Text);
                    this.StudentList.Add(a);
                }
                ListViewItem itm;
                //add items to ListView
                arr[0] = id_txtbox.Text;
                arr[1] = name_txtbox.Text;
                arr[2] = birthday.Value.ToString("d");
                arr[3] = add_txtbox.Text;
                arr[4] = phone_txtbox.Text;
                arr[5] = year_txtbox.Text;
                arr[6] = degree;
                arr[7] = major_txtbox.Text;
                itm = new ListViewItem(arr);
                listofstudent.Items.Add(itm);
            }
        }
       
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Check_Associate(object sender, EventArgs e)
        {
            arr[6] = "Associate";
            degree = "Associate";
        }

        private void Check_Bachelor(object sender, EventArgs e)
        {
            arr[6] = "Bachelor";
            degree = "Bachelor";
        }

        private void Check_Master(object sender, EventArgs e)
        {
            arr[6] = "Master";
            degree = "Master";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? This can't be undo.", "Clear all", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.StudentList.Clear();
                this.Temp.Clear();
                listofstudent.Items.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }
       
        private void Delete_click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedList;
            selectedList = listofstudent.SelectedItems;
            foreach (ListViewItem item in selectedList)
                {
                    string id = item.Text;
                    foreach (Student stu in StudentList)
                    {
                        if (stu.ID != id) Temp.Add(stu);
                    }
                }
            UpdateList(Temp);
            StudentList = (ArrayList)Temp.Clone();

            this.Temp.Clear();
        }

        private void Search_click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter student ID that you want to search", "Search", "Student ID", 0, 0);
            foreach (Student stu in StudentList)
            {
                if (stu.ID == input) MessageBox.Show(stu.ToString());
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
