using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public Person(string firstName, string lastName)
        {
            if (IsNameValid(firstName) == false) throw new ArgumentNullException(nameof(firstName));
            if (IsNameValid(lastName) == false) throw new ArgumentNullException(nameof(lastName));

            Firstname = firstName.Trim();
            LastName = lastName.Trim();
        }

        public string Firstname { get; private set; } // private 
        public string LastName { get; private set; } // private

        public void ChangeFirstName(string firstName)
        {
            if (IsNameValid(firstName) == false) throw new ArgumentNullException(nameof(firstName));

            Firstname = firstName.Trim();
        }

        public void ChangeLastName(string lastName)
        {
            if (IsNameValid(lastName) == false) throw new ArgumentNullException(nameof(lastName));

            LastName = lastName.Trim();
        }

        private bool IsNameValid(string name)
        {
            return string.IsNullOrWhiteSpace(name) == false;
        }
    }
}
