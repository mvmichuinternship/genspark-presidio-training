using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RequestTrackerModelLibrary
{
    public class RequestSolution
    {
        [Key]
        public int SolId { get; set; }
        public int RequestId { get; set; }
        public Request RequestData { get; set; }
        public string SolName { get; set; } = string.Empty;
        public string SolDescription { get; set;} = string.Empty;
        public int SolvedBy { get; set; }
        public Employee Sol_Employee {  get; set; }
        public DateTime SolvedDate { get; set; }
        public bool IsSolved { get; set; } = false;
        public string? RequestRaiserComment { get; set; }
        public ICollection<Feedback> FeedbackProvided { get; set; }

    }
}
