using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class PersonDetails
    {
        static void Main(string[] args)
        {

        }

        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        struct Person
        {
            public string FirstName;
            public string LastName;
            public string Title;

            public Person(string FirstName, string LastName, string Title)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Title = Title;
            }

            public static Person getDetails()
            {
                return new Person();
            }
        }
    }
}
