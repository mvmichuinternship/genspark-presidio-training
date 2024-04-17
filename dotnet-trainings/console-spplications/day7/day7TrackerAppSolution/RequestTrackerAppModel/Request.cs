﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestTrackerAppModel
{
    public class Request
    {
        public int Id { get; set; }
        public string RequestText { get; set; }
        public int Raised_By { get; set; }
        public string Status { get; set; }
        public int Closed_By { get; set; }
        public DateTime RaisedDate { get; set; } = DateTime.Now;
        public DateTime ClosedDate { get; set; }

        public bool Equals(Request? other)
        {
            return Id.Equals(other.Id);
        }
    }
}
