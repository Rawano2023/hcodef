using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcodef
{
   public class Teacher
    {
        //تعريف كونستركتر بحيث عند الاستعلام على اسم استاذ يجلب موادة
        public Teacher()
        {
            this.Subjects = new List<Subject>();    
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
