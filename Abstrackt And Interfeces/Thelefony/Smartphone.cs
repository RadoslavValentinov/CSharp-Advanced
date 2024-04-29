using System;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public Smartphone(string model)
        {
            Model = model;
        }

        public string Model { get; set; }


        public string Calling(string model)
        {
            return $"Calling... {model}";
        }

        public string Browsing(string model)
        {
            return $"Browsing: {model}!";
        }

        public string Dialing(string model)
        {
            return $"Dialing... {model}";
        }
    }

}
