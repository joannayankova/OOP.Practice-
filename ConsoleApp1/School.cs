using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class School
    {
        public School(List<Class> classes)
        {
            Classes = classes;
        }

        public List<Class> Classes { get; private set; }
    }
}
