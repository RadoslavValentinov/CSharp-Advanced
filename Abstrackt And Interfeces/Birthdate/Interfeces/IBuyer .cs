﻿namespace Birthdate.Interfeces
{
    public interface IBuyer
    {
        public string  Name { get; set; }
        public int Food { get; set; }
        void BuyFood();
    }
}