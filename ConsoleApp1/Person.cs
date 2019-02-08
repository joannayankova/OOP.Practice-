using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public Person(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;
        }

        public string Fname { get; set; }
        public string Lname { get; set; }


    }
}



