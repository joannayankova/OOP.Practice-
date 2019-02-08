using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public  class Human 
    {
        public Human(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }

        public string Fname { get; set; }
        public string Lname { get; set; }


    }
}
