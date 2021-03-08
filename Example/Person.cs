using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return (FirstName + " " + LastName);
            }
        }
        public int Id { get; set; }
        public bool IsFemale { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return (int)((DateTime.Now - Birthday).TotalDays / 365.25);
            }
        }

        public Person() { }

        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public Person(string firstName, string lastName, int id, bool isFemale, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            IsFemale = isFemale;
            Birthday = birthday;
        }

        public bool ChangeFirstName(Person person, string newFirstName)
        {
            person.FirstName = newFirstName;
            return true;
        }
    }
}

