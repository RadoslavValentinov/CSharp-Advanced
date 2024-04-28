using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizens : Iindetification,Ibirthdates
    {
        public Citizens(string name, int age, string id, string birthdates)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdates = birthdates;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdates { get; set; }
    }
}
