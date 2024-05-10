using System;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person :IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string names,int ages,string towns)
        {
            name = names;
            age = ages;
            town = towns;
        }

        public string Name => name;

        public int Age => age;

        public string Town => town;


        public int CompareTo(Person other)
        {
            int result =Name.CompareTo(other.Name);
            if (result==0)
            {
                result = Age.CompareTo(other.Age);
            }

            if (result==0)
            {
                result = Town.CompareTo(other.Town);
            }
            return result;
        }
    }
}
