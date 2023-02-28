using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinssLogic.Models
{
    public class Student : StudentBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        //public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
