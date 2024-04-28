using System;
using System.Collections.Generic;
using System.Text;
using Birthdate.Interfeces;

namespace Birthdate.classes
{
    public class Rebel : IName, IBuyer
    {
        private int DefautBuyPrice = 5;
        public Rebel(string name, int age, string groups)
        {
            Name = name;
            Age = age;
            Groups = groups;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Groups { get; set; }
        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += DefautBuyPrice;
        }
    }
}
