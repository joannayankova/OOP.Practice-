using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        public int Id { get; private set; }

        public Student(string fname, string lname) : base(fname, lname)
        {

        }
        public Student(string fname,string lname,int id):base(fname,lname)
        {
           Id = id;
        }
    }
}
