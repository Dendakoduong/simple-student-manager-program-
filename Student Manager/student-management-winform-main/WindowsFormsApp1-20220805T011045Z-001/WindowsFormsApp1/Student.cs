using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Student
    {

        private string name;
        private string stu_id;
        private string birthday;
        private string address;
        private string phone;
        private string year;
        private string degree;
        private string major;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return stu_id; }
            set { stu_id = value; }
        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string School_year
        {
            get { return year; }
            set { year = value; }
        }
        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public Student(string ID,string Name, string Birthday, string Address, string Phone, string School_year,string Degree, string Major)
        {
            ArrayList al = new ArrayList();
            this.name = Name;
            this.stu_id = ID;
            this.address = Address;
            this.phone = Phone;
            this.year = School_year;
            this.birthday = Birthday;
            this.degree = Degree;
            this.major = Major;
        }
        //return searched student information 
        public override string ToString()
        {
            return name + " (" + birthday + ")" + ", "+ "Academic year: " + year + ", " + "Degree: " + degree + " of " + major;
        }
    }
   
}
