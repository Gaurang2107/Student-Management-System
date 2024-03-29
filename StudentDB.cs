using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_C_
{
    public class StudentDB
    {
        public static List<Student> studentList = new List<Student>();

        public static void ReadStudentsFromFile()
        {
            try
            {
                string[] lines = File.ReadAllLines("C:\\Users\\gdham\\source\\repos\\assignment_2_C#\\students.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 7) // Check if the line has all required fields
                    {
                        studentList.Add(new Student(Convert.ToInt32(parts[0]), parts[1], parts[2], Convert.ToInt32(parts[3]), parts[4], parts[5], parts[6]));
                    }
                    else
                    {
                        MessageBox.Show("Invalid data format in file: " + line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading student data: " + ex.Message);
            }
        }

        public static void SaveStudents()
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream("C:\\Users\\gdham\\source\\repos\\assignment_2_C#\\students.txt", FileMode.Create, FileAccess.Write)))
            {
                foreach (Student item in studentList)
                {
                    textOut.Write(item.StudentID + ",");
                    textOut.Write(item.FirstName + ",");
                    textOut.Write(item.LastName + ",");
                    textOut.Write(item.Age + ",");
                    textOut.Write(item.Gender + ",");
                    textOut.Write(item.ClassName + ",");
                    textOut.Write(item.Grade + "\n");
                }
            }
        }
        public static void AddStudent(Student student)
        {
            studentList.Add(student);
            SaveStudents();
        }
        public static void UpdateStudent(Student student)
        {
            Student findStudent = studentList.Find(st => st.StudentID == student.StudentID);
            findStudent.FirstName = student.FirstName;
            findStudent.LastName = student.LastName;
            findStudent.Age = student.Age;
            findStudent.Gender = student.Gender;
            findStudent.ClassName = student.ClassName;
            findStudent.Grade = student.Grade;

            SaveStudents();

        }
        public static void RemoveStudent(int index)
        {
            studentList.RemoveAt(index);
            SaveStudents();
        }
        public static void AddAssignment(Student student,int index,Assignment assignment)
        {
            for(int i = 0; i < student.Assignments.Length; i++)
            {
                if (student.Assignments[i] != null && student.Assignments[i].AssignmentID == assignment.AssignmentID)
                {
                    MessageBox.Show("Duplicate assignment found.");
                    return;
                }
            }
            if(studentList[index] != null)
            {
                for (int i = 0; i < studentList[index].Assignments.Length; i++)
                {
                    if (studentList[index].Assignments[i] == null)
                    {
                        studentList[index].Assignments[i] = assignment;
                        break;
                    }
                }
            }
        }
        public static void UpdateAssignment(int studentIndex, int assignmentIndex, double ScoreObtained, double MaximumScore)
        {
            studentList[studentIndex].Assignments[assignmentIndex].ScoreObtained = ScoreObtained;
            studentList[studentIndex].Assignments[assignmentIndex].MaximumScore = MaximumScore;
        }
        public static void RemoveAssignment(int studentIndex, int assignmentIndex)
        {
            studentList[studentIndex].Assignments[assignmentIndex] = null;
        }
    }
}