using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class SimpleFormatter : IFromatter
    {
        public string Format(Person _Person)
        {
            return String.Format("{0}, {1} Years Old.", _Person.Name, _Person.Age);
        }
    }
}
