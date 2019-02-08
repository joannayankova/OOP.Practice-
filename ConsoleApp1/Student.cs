using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        private int _id { get; set; }

        public Student(string fname, string lname) : base(fname, lname)
        {

        }

        public Student(string fname,string lname,int id):base(fname,lname)
        {
            this._id = id;
        }





    }
}
