using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcodef
{
    public class card
    {

        public int id { get; set; }
        public string? description { get; set; }

        //بيتعرف على اساس f.k
        public int StudentsId { get; set; }
        public student students { get; set; }
    }
}
