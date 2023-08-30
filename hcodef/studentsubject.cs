using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcodef
{
    public class studentsubject
    {
        public int Id { get; set; }
        public int studentId { get; set; }
        public student students { get; set; }

        public int subjectId { get; set; }
        public Subject subjects { get; set; }
    }
}
