using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcodef
{
    public class student
    {
        public student()//  بنعرف اوبجكت واسند له قيم باشره 
        {
            this.Subjects = new List<studentsubject>();
        }


        public int ID { get; set; }
        public string Name { get; set; }
        //اسناد القيمه با set
        //getاخذ القيمه

        /*
                private int myVar;//كتبت باالاختصار propfull

                public int MyProperty
                {
                    get { return myVar; }
                    set { myVar = value; }
                }
             */

        public List <studentsubject> Subjects{ get; set; }//m to m
    }
}
