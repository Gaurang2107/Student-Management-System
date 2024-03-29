using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_C_
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ClassName { get; set; }
        public string Grade { get; set; }

        public Assignment[] Assignments = new Assignment[5];
        public Student(int StudentID, string FirstName, string LastName, int Age, string Gender, string ClassName, string Grade)
        {
            this.StudentID = StudentID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Gender = Gender;
            this.ClassName = ClassName;
            this.Grade = Grade;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Student other = (Student)obj;
            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase);
        }
        public override int GetHashCode()
        {
            return FirstName.ToLower().GetHashCode();
        }
    }
}