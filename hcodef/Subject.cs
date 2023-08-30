using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcodef
{
    public class Subject
    {

        public Subject()
        {
            this.Students =new List<studentsubject>();
        }
        public int ID { get; set; }
        public string Name { get; set; }


        public int TeachersId { get; set; }
        public Teacher Teachers { get; set; }

       public List<studentsubject> Students { get; set; }//m to m
    }
}
