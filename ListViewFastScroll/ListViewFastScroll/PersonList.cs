using System.Collections.Generic;

namespace ListViewFastScroll
{
    public class PersonList : List<Person>
    {
        public string Heading { get; set; }
        public List<Person> Persons => this;
    }
}