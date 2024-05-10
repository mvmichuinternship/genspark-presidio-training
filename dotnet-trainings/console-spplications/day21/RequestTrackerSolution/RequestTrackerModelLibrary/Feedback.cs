using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerModelLibrary
{
    public class Feedback
    {
        [Key]
        public int FId { get; set; }
        public string FeedBack {  get; set; }
        public float Ratings { get; set; }
        public int SolId {  get; set; }
        public RequestSolution Solution { get; set; }
        public DateTime FeedbackDate { get; set; }
        public bool IsHelpful { get; set; }
        public int EmployeeId {  get; set; }
        public Employee EmployeeDetails { get; set; }

    }
}
