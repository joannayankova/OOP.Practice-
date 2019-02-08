using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee : Human, IComparable<Employee>
    {
        public int _wage { get; private set; }
        
        public int WorkingHours { get; set; }

        public Employee(string fname, string lname) : base(fname, lname)
        {
        }

        public Employee(string fname, string lname,int wage, int workingHours) : base(fname, lname)
        {
            this._wage = wage;
            this.WorkingHours = workingHours;
        }

        public double CalculateHourlyWage ()
        {
            double HourlyWage = (double)(this._wage / this.WorkingHours);
            return HourlyWage;
        }

        public int CompareTo(Employee other)
        {
            return other._wage.CompareTo(this._wage);
        }
    }
}
