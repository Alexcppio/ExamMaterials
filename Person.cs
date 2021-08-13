using System;
using System.Collections.Generic;
using System.Text;

namespace HW_files_combine
{
    public class Person
    {
        public string SurnameAndInitials { get; }
        public DateTime Date { get; }
        public Person(string surnameAndInitials, DateTime date)
        {
            SurnameAndInitials = surnameAndInitials;
            Date = date;
        }
        public override string ToString() => $"{SurnameAndInitials} {Date.ToShortDateString()}";
    }
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y) => x.SurnameAndInitials == y.SurnameAndInitials;
        public int GetHashCode(Person person) => person.SurnameAndInitials == null ? 0 : person.SurnameAndInitials.GetHashCode();
    }
}
