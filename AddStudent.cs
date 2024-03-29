using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment_2_C_
{
    public partial class AddStudent : Form
    {
        bool isUpdate;
        Student student;
        public AddStudent(bool isUpdate, Student student)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.student = student;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtTitle.Text = "Update Student";
                btnAdd.Text = "Update";
                txtID.Text = student.StudentID.ToString();
                txtID.ReadOnly = true;
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtAge.Text = student.Age.ToString();
                txtGender.Text = student.Gender;
                txtClassName.Text = student.ClassName;
                txtGrade.Text = student.Grade;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("Enter valid id. (Numbers only)");
                return;
            }
            if(!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Enter valid age. (Numbers only)");
                return;
            }
            if (!isUpdate && StudentDB.studentList.Any(stu => stu.StudentID == id))
            {
                MessageBox.Show("Student already added.");
                return;
            }
            if (isUpdate)
            {
                StudentDB.UpdateStudent(new Student(id, txtFirstName.Text, txtLastName.Text, age, txtGender.Text, txtClassName.Text, txtGrade.Text));
                MessageBox.Show("Student Updated");
            }
            else
            {
                StudentDB.AddStudent(new Student(id, txtFirstName.Text, txtLastName.Text, age, txtGender.Text, txtClassName.Text, txtGrade.Text));
                MessageBox.Show("Student Added");
            }
            Home home = (Home)Application.OpenForms["Home"];
            home.ShowStudent();
            home.Show();
            this.Dispose();
        }
    }
}