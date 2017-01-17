using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Person
    {
        public IFromatter PersonFromatter { get; private set; }
        public String Name { get; set; }
        public int Age { get; set; }

        public Person(IFromatter PersonFromatter)
        {
            this.PersonFromatter = PersonFromatter;
        }

        public override string ToString()
        {
            return this.PersonFromatter.Format(this);
        }
    }
}
