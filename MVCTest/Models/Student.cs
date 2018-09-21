using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrolmentDate { get; set; }
        public virtual ICollection<Enrolment> Enrolments{ get; set; }

    }   
}