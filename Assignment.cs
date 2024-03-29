using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_C_
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public double ScoreObtained { get; set; }
        public double MaximumScore { get; set; }
        public Assignment(int AssignmentID, double ScoreObtained, double MaximumScore)
        {
            this.AssignmentID = AssignmentID;
            this.ScoreObtained = ScoreObtained;
            this.MaximumScore = MaximumScore;
        }
    }
}