using System;
using System.Collections.Generic;
using System.Text;
using Birthdate.Interfeces;

namespace Birthdate.classes
{
    public class Citizen : IIdentifiable,IBirthable, IName, IBuyer
    {
        private int age;

        private int DefautBuyPrice = 10;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);

        }

        public string Id { get; private set; }

        public DateTime Birthdate { get; private set; }

        public string Name { get;  set; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += DefautBuyPrice;
        }
    }
}
