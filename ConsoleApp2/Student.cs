using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student : Human, IComparable<Student>
    {
        public double Mark { get; set; }

        public Student(string fname, string lname) : base(fname, lname)
        {
        }

        public Student(double mark, string fname, string lname) : base(fname, lname)
        {
            this.Mark = mark;
        }

        public int CompareTo(Student student)
        {


            return this.Mark.CompareTo(student.Mark);

        }
    }

}
