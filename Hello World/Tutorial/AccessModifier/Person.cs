using System;

namespace AccessModifier
{
    public class Person
    {
        public DateTime Birthday { get; private set; }

        public Person(DateTime birthday)
        {
            this.Birthday = birthday;
        }

        public int Age
        {
           get
            {
                var timeSpan = DateTime.Today - this.Birthday;
                return timeSpan.Days / 365;
            }
        }
    }
}
