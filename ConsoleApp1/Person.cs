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
            if (fname is null) throw new ArgumentNullException(nameof(fname));
            if (lname is null) throw new ArgumentNullException(nameof(fname));
            this.Firstname = fname;
            this.LastName = lname;
        }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}



