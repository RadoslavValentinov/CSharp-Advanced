using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet: Ibirthdates
    {
        public Pet(string name, string birthdates)
        {
            Name = name;
            Birthdates = birthdates;
        }
        public string Name { get; set; }

        public string Birthdates { get; set; }
    }
}
