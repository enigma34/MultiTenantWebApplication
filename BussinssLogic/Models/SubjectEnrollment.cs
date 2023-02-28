using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinssLogic.Models
{
    public class SubjectEnrollment
    {
        public int Id { get; set; }
        public string SubjectsList { get; set; }
        //public Student student { get; set; }
        public int StudentId { get; set; }
    }
}
