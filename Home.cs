namespace assignment_2_C_
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ShowStudent();
        }
        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (rbAdd.Checked)
            {
                AddStudent student = new AddStudent(false,null);
                student.ShowDialog();
            }else if (rbUpdate.Checked)
            {
                if(StudentDB.studentList.Count != 0 && lbStudent.SelectedIndex >= 0)
                {
                    AddStudent student = new AddStudent(true, StudentDB.studentList[lbStudent.SelectedIndex]);
                    student.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Add/Select Student First.");
                }
            }else if (rbAssignment.Checked)
            {
                if (StudentDB.studentList.Count != 0 && lbStudent.SelectedIndex >= 0)
                {
                    AddAssignment addAssignment = new AddAssignment(lbStudent.SelectedIndex, StudentDB.studentList[lbStudent.SelectedIndex]);
                    addAssignment.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Add/Select Student First.");
                }
            }else if(rbDelete.Checked)
            {
                if (StudentDB.studentList.Count != 0 && lbStudent.SelectedIndex >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to remove this student?", "Alert", MessageBoxButtons.OKCancel);
                    if(dialogResult == DialogResult.OK)
                    {
                        StudentDB.RemoveStudent(lbStudent.SelectedIndex);
                        MessageBox.Show("Student Removed Successfully");
                        ShowStudent();
                    }
                }
                else
                {
                    MessageBox.Show("Add/Select Student First.");
                }
            }else if (rbExit.Checked)
            {
                this.Close();
            }
        }

        public void ShowStudent(int index = 0)
        {
            lbStudent.Items.Clear();
            foreach(var item in StudentDB.studentList)
            {
                lbStudent.Items.Add("Student ID: " + item.StudentID + " | Name: " + item.FirstName + " " + item.LastName + " | Age: " + item.Age + " | Gender: " + item.Gender + " | ClassName: " + item.ClassName + " | Grade: " + item.Grade);
            }

            if (lbStudent.Items.Count > 0)
            {
                lbStudent.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("No more students to remove. Please add some to perform this operation.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMax.Text = "";
                txtTotal.Text = "";
            }
        }

        public void calculate()
        {
            double total = 0;
            double max = 0;
            foreach (var ass in StudentDB.studentList[lbStudent.SelectedIndex].Assignments)
            {
                if (ass != null)
                {
                    total += ass.ScoreObtained;
                    max += ass.MaximumScore;
                }
            }
            txtTotal.Text = total.ToString();
            txtMax.Text = max.ToString();
        }

        private void lbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}