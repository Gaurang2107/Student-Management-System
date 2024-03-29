using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2_C_
{
    public partial class AddAssignment : Form
    {
        int index;
        Student student;
        public AddAssignment(int index, Student student)
        {
            InitializeComponent();
            this.student = student;
            this.index = index;
        }

        private void AddAssignment_Load(object sender, EventArgs e)
        {
            lblStudent.Text = "Student ID: " + student.StudentID.ToString() + " | Student Name: " + student.FirstName;
            ShowAssignment();
        }

        public void ShowAssignment()
        {
            lbAssignment.Items.Clear();
            foreach (var ass in student.Assignments)
            {
                if (ass != null)
                {
                    lbAssignment.Items.Add("Assignment ID: " + ass.AssignmentID.ToString() + " |Score Obtained: " + ass.ScoreObtained.ToString() + " |Maximum Score: " + ass.MaximumScore.ToString());
                }
            }
        }

        public void Clear()
        {
            txtID.Text = "";
            txtObtained.Text = "";
            txtMaximum.Text = "";
        }

        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdd.Checked)
            {
                Clear();
                btnAdd.Text = "Add";
                txtID.ReadOnly = false;
                txtObtained.ReadOnly = false;
                txtMaximum.ReadOnly = false;
            }
        }

        private void rbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (lbAssignment.SelectedIndex >= 0)
            {
                Clear();
                btnAdd.Text = "Update";
                txtID.ReadOnly = true;
                txtObtained.ReadOnly = false;
                txtMaximum.ReadOnly = false;
                txtID.Text = student.Assignments[lbAssignment.SelectedIndex].AssignmentID.ToString();
                txtObtained.Text = student.Assignments[lbAssignment.SelectedIndex].ScoreObtained.ToString();
                txtMaximum.Text = student.Assignments[lbAssignment.SelectedIndex].MaximumScore.ToString();
            }
            else
            {
                MessageBox.Show("Add/Select select assignment to update.");
            }
        }

        private void rbFind_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            btnAdd.Text = "Find";
            txtID.ReadOnly = false;
            txtObtained.ReadOnly = true;
            txtMaximum.ReadOnly = true;
        }

        private void rbRemove_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            btnAdd.Text = "Remove";
            txtID.ReadOnly = true;
            txtObtained.ReadOnly = true;
            txtMaximum.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            double obtained = 0, maximum = 0;
            if (rbAdd.Checked || rbUpdate.Checked)
            {
                if (!int.TryParse(txtID.Text, out id) || !double.TryParse(txtObtained.Text, out obtained) || !double.TryParse(txtMaximum.Text, out maximum))
                {
                    MessageBox.Show("Enter Valid values.");
                    return;
                }
                if (obtained > maximum)
                {
                    MessageBox.Show("Obtaied marks can not be grater than maximum marks.");
                    return;
                }
            }
            if (rbAdd.Checked)
            {
                StudentDB.AddAssignment(student, index, new Assignment(id, obtained, maximum));
                MessageBox.Show("Assignment Added.");
                ShowAssignment();
                Clear();
            }
            else if (rbUpdate.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to update this?", "Alert!", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    StudentDB.UpdateAssignment(index, lbAssignment.SelectedIndex, obtained, maximum);
                    MessageBox.Show("Assignment Updated.");
                    ShowAssignment();
                    Clear();
                }
            }
            else if (rbFind.Checked)
            {
                if(!int.TryParse(txtID.Text, out id))
                {
                    MessageBox.Show("Enter Valid values.");
                    return;
                }
                Assignment[] assignment = StudentDB.studentList[index].Assignments;
                if (assignment != null)
                {
                    for(int i = 0; i < assignment.Length; i++)
                    {
                        if (assignment[i] != null && assignment[i].AssignmentID == id)
                        {
                            txtObtained.Text = assignment[i].ScoreObtained.ToString();
                            txtMaximum.Text = assignment[i].MaximumScore.ToString();
                            return;
                        }
                    }
                    MessageBox.Show("No match found.");
                }
                else
                {
                    MessageBox.Show("No assignment found with this ID.");
                }
            }else if (rbRemove.Checked)
            {
                if(lbAssignment.SelectedIndex >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to remove this?", "Alert!", MessageBoxButtons.OKCancel);
                    if(dialogResult == DialogResult.OK)
                    {
                        StudentDB.RemoveAssignment(index, lbAssignment.SelectedIndex);
                        MessageBox.Show("Assignment Removed Successfully.");
                        ShowAssignment();
                        Clear() ;
                    }
                }
                else
                {
                    MessageBox.Show("Add/Select select assignment to remove.");
                }
            }
        }

        private void lbAssignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Home form1 = (Home)Application.OpenForms["Home"];
            form1.calculate();
            form1.Show();
        }
    }
}